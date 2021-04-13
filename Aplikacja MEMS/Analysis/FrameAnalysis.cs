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
            int bytes = 0;

            // Na wypadek pustej kolejki
            while (data.Count == 0)
            {
                Thread.Sleep(20);
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

        SameItem: // Ciąg dalszy ramki (w przypadku ramki w dwóch tablicach z kolejki)
            // Przypisywanioe bajtów do buffora
            for (int i = 0; ((counterStop) < qData.Length) && (qData[counterStop] != (byte)Frame.Identificators.FrameEnd); i++)
            {
                buffer[i] = qData[counterStop];
                counterStop++;
                bytes++;
            }

        // Sprawdzanie czy...
        Check:
            // Ramka kończy się razem z obecnie przetwarzaną tablicą tablicą
            if ((counterStop + 1 == qData.Length) && (qData[counterStop] == (byte)Frame.Identificators.FrameEnd))
            {
                AddData(buffer, bytes, frames);

                bytes = 0;
                goto NextItem;
            }
            // Ramka kończy się, ale obecnie przetwarzana tablica wciąż zawiera dane
            else if ((counterStop + 1< qData.Length) && (qData[counterStop] == (byte)Frame.Identificators.FrameEnd))
            {
                AddData(buffer, bytes, frames);

                counter = ++counterStop;
                bytes = 0;
                goto SameItem;
            }
            // Ramka nie kończy się w obecnie przetwarzanej tablicy
            else
            {
            TryRead: // Próba pobrania kolejnej tablicy
                while (data.Count == 0)
                {
                    Thread.Sleep(200);
                }
                qData = data.Dequeue();
                if (qData == null) goto TryRead;

                // Określenie od którego bajtu w bufforze należy przypisywać kolejne bajny z nowej tablicy
                int startCount = counterStop - counter;

                int i = 0;
                // Przypisywanie bajtów
                for (i = 0; i < qData.Length && qData[i] != (byte)Frame.Identificators.FrameEnd; i++)
                {
                    buffer[startCount] = qData[i];
                    startCount++;
                    bytes++;
                }
                counterStop += i - 1;
                goto Check; // Ponowne sprawdzenie
            }
        }

        private static void AddData(byte[] source, int length, Queue<byte[]> destination)
        {
            source[length] = (byte)Frame.Identificators.FrameEnd;
            byte[] addFrame = new byte[length + 1];
            Array.Copy(source, addFrame, addFrame.Length);
            destination.Enqueue(addFrame);
        }
    }
}
