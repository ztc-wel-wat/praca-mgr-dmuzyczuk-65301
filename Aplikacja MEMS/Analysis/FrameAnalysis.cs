using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplikacja_MEMS.Frame;

namespace Aplikacja_MEMS.Analysis
{
    class FrameAnalysis
    {
        public static void Analysis(Queue<byte[]> data, Queue<byte[]> frames)
        {
            byte[] buffer = new byte[16384];
            byte[] qData;

        NextItem: // Kolejna tablica z kolejki odebranych
            int counter = 0;

            // Na wypadek pustej kolejki
            while (data.Count == 0)
            {
            }
            qData = data.Dequeue();

            // Na wypadek pobrania pustej tablicy
            if (qData == null) goto NextItem;

            // Poszukiwanie początku ramki
            try
            {
                for (int i = 0; (qData[i] != (byte)Frame.Identificators.ApplicationId); i++)
                    counter++;
            }
            catch (IndexOutOfRangeException indexOut)
            {
                goto NextItem;
            }

            // Zmienne do ustawienia nr bajtu z początkiem ramki
            int counterStop = counter;
            buffer[0] = qData[counter];

        SameItem: // Ciąg dalszy ramki (w przypadku ramki w dwóch tablicach z kolejki)
            // Przypisywanioe bajtów do buffora
            for (int i = 1; ((counterStop+1) < qData.Length) && ((qData[i] == (byte)Frame.Identificators.ApplicationId) &&
                (qData[i + 1] == (byte)Frame.Identificators.SensorBoardId)); i++)
            {
                counterStop++;
                buffer[i] = qData[counterStop];
            }

            // Sprawdzanie czy...
        Check:
            // Ramka kończy się razem z obecnie przetwarzaną tablicą tablicą
            if ((counterStop + 1 == qData.Length) && (qData[counterStop] == (byte)Frame.Identificators.FrameEnd))
            {
                buffer[++counterStop] = (byte)Frame.Identificators.FrameEnd;
                byte[] addFrame = new byte[counterStop + 1];
                Array.Copy(buffer, addFrame, counterStop + 1);
                frames.Enqueue(addFrame);
                goto NextItem;
            }
            // Ramka kończy się, ale obecnie przetwarzana tablica wciąż zawiera dane
            else if (((counterStop) < qData.Length) && (qData[counterStop] == (byte)Frame.Identificators.FrameEnd))
            {
                buffer[++counterStop - counter] = (byte)Frame.Identificators.FrameEnd;
                byte[] addFrame = new byte[counterStop + 1 - counter];
                Array.Copy(buffer, addFrame, addFrame.Length);
                frames.Enqueue(addFrame);
                counter = ++counterStop;
                goto SameItem;
            }
            // Ramka nie kończy się w obecnie przetwarzanej tablicy
            else
            {
            TryRead: // Próba pobrania kolejnej tablicy
                while (data.Count == 0)
                {
                    Thread.Sleep(500);
                }
                qData = data.Dequeue();
                if (qData == null) goto TryRead;

                // Określenie od którego bajtu w bufforze należy przypisywać kolejne bajny z nowej tablicy
                int startCount = counterStop + 1 - counter;
                counter = counterStop = 0;
                buffer[startCount] = qData[counter];

                // Przypisywanie bajtów
                for (int i = startCount + 1; ((counterStop+1) < qData.Length) && ((qData[counterStop] != (byte)Frame.Identificators.FrameEnd)); i++)
                {
                    counterStop++;
                    buffer[i] = qData[counterStop];
                }
                goto Check; // Ponowne sprawdzenie
            }
        }
    }
}
