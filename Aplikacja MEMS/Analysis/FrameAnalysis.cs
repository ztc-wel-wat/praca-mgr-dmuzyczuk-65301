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
            byte[] buffer = new byte[128];
            int counter = 0;

            while (true)
            {
                byte[] qData = data.Dequeue();

                counter = 0;

                NotFrameEnd:
                while (buffer[counter] != (byte)Frame.Identificators.ApplicationId)
                    counter++;

                
                for(int i = 0;  buffer[counter] != (byte)Frame.Identificators.FrameEnd && counter < qData.Length; i++)
                {
                    buffer[i] = qData[counter];
                    counter++;
                }

                if(qData[counter] == 0x0F && counter+1 == qData.Length)
                {
                    byte[] frameBuffer = new byte[counter + 1];
                    Array.Copy(buffer, frameBuffer, counter + 1);
                    frames.Enqueue(frameBuffer);
                }
                else if (qData[counter] == 0x0F && counter + 1 != qData.Length)
                {
                    byte[] frameBuffer = new byte[counter + 1];
                    Array.Copy(buffer, frameBuffer, counter + 1);
                    frames.Enqueue(frameBuffer);
                    goto NotFrameEnd;
                }


            }


           // for (int i = 0; i < data.Length; i++)
           // {
           //     Action<int> updateAction = new Action<int>((value) => ritchTextBox.Text += data[i].ToString("X2") + " ");
           //     ritchTextBox.Invoke(updateAction, 32);
           // }

        }


    }
}
