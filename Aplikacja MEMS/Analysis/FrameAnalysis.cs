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

        NextItem:
            int counter = 0;
           
            while(data.Count == 0)
            {
                Thread.Sleep(200);
            }
               qData = data.Dequeue();

            if (qData == null) goto NextItem;

            try
            {
                for (int i = 0; (qData[i] != (byte)Frame.Identificators.ApplicationId) && (qData[i + 1] != (byte)Frame.Identificators.SensorBoardId); i++)
                    counter++;
            }
            catch (IndexOutOfRangeException indexOut)
            {
                goto NextItem;
            }

            int counterStop = counter;
            buffer[0] = qData[counter];

        SameItem:
            for (int i = 1; ((++counterStop) < qData.Length) && ((qData[i] == (byte)Frame.Identificators.ApplicationId) && (qData[i + 1] == (byte)Frame.Identificators.SensorBoardId)); i++)
            {
                buffer[i] = qData[counterStop];
            }
            counterStop--;

        Check:
            if ((counterStop + 1 == qData.Length) && (qData[counterStop] == (byte)Frame.Identificators.FrameEnd))
            {
                buffer[++counterStop] = 0x0F;
                byte[] addFrame = new byte[counterStop + 1];
                Array.Copy(buffer, addFrame, counterStop + 1);
                frames.Enqueue(addFrame);
                goto NextItem;
            }
            else if (((counterStop) < qData.Length) && (qData[counterStop] == (byte)Frame.Identificators.FrameEnd))
            {
                buffer[++counterStop - counter] = 0x0F;
                byte[] addFrame = new byte[counterStop + 1 - counter];
                Array.Copy(buffer, addFrame, addFrame.Length);
                frames.Enqueue(addFrame);
                counter = ++counterStop;
                goto SameItem;
            }
            else
            {
            TryRead:
               while(data.Count == 0)
                {
                    Thread.Sleep(1000);
                }
                    qData = data.Dequeue();
                int startCount = ++counterStop - counter;

                counter = counterStop = 0;

                buffer[startCount] = qData[counter];

                for (int i = startCount + 1; ((++counterStop) < qData.Length) && ((qData[counterStop] != (byte)Frame.Identificators.FrameEnd)); i++)
                {
                    buffer[i] = qData[counterStop];
                }

                goto Check;
            }

            // for (int i = 0; i < data.Length; i++)
            // {
            //     Action<int> updateAction = new Action<int>((value) => ritchTextBox.Text += data[i].ToString("X2") + " ");
            //     ritchTextBox.Invoke(updateAction, 32);
            // }

        }


    }
}
