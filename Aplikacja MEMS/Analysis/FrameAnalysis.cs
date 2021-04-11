using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            int counter = 0;
            byte[] qData;

            NextItem:
            try
            {
                qData = data.Dequeue();
            }
            catch (Exception e)
            {
                goto NextItem;
            }

            while(qData == null)
            {
                qData = data.Dequeue();
            }

            SameItem:
            for (int i = 0; qData[i] != (byte)Frame.Identificators.ApplicationId; i++) 
                counter++;

            int counterStop = counter;

            for(int i = 0; qData[i] != (byte)Frame.Identificators.FrameEnd && counterStop < qData.Length; i++ )
            {
                buffer[i] = qData[counterStop];
                counterStop++;
            }
            buffer[counterStop] = qData[counterStop - counter];


            if(qData[counterStop] == (byte)Frame.Identificators.FrameEnd && counterStop + 1 == qData.Length)
            {
                byte[] addFrame = new byte[counterStop + 1];
                Array.Copy(buffer, addFrame, counterStop + 1);
                frames.Enqueue(addFrame);
                counter = 0;
                goto NextItem;
            }
            else if(qData[counterStop] == (byte)Frame.Identificators.FrameEnd && counterStop + 1 < qData.Length)
            {
                byte[] addFrame = new byte[counterStop + 1 - counter];
                Array.Copy(buffer, addFrame, addFrame.Length);
                frames.Enqueue(addFrame);
                counter = counterStop + 1;
                goto SameItem;
            }
            else if(qData[counterStop] != (byte)Frame.Identificators.FrameEnd)
            {
                goto NextItem;
            }


           // for (int i = 0; i < data.Length; i++)
           // {
           //     Action<int> updateAction = new Action<int>((value) => ritchTextBox.Text += data[i].ToString("X2") + " ");
           //     ritchTextBox.Invoke(updateAction, 32);
           // }

        }


    }
}
