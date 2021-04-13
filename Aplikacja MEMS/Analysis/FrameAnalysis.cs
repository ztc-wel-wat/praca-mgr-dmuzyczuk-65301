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
        public static void Analysis(Queue<byte> data, Queue<byte[]> frames)
        {
            while (true)
            {
                byte[] buffer = new byte[16384];
                int count = 0;

            NextByte: 
                // Oczekiwanie na wypadek pustej kolejki
                while (data.Count == 0)
                {
                    Thread.Sleep(100);
                }
                byte add = data.Dequeue();

                // Dodawanie kolejnych bajtów do buffora
                while (add != (byte)Frame.Identificators.FrameEnd)
                {
                    buffer[count] = add; 
                    count++;
                    goto NextByte;
                }


                // Dodanie ramki do kolejki
                byte[] frame = new byte[count];
                Array.Copy(buffer, frame, frame.Length);
                frames.Enqueue(frame);
            }
        }

        public static void CheckSum(Queue<byte[]> source, Queue<byte[]> destination)
        {
            while (true)
            {
                NextFrame:
                while(source.Count == 0) { }
                byte sum = 0x00;

                byte[] toCheck = source.Dequeue();
                if (toCheck == null) goto NextFrame;

                foreach(byte b in toCheck)
                {
                    sum += b;
                }

                if (sum == 0x00) destination.Enqueue(toCheck);
            }
        }
    }
}
