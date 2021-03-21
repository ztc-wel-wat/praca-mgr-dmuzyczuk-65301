using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja_MEMS
{
    abstract class Motion : Sensors
    {
        public byte[,] scale;
        public void SetScale(int index)
        {
            if (serialPort.IsOpen)
            {
                byte[] parameters = new byte[] { 0x05, sensorNr, scale[index, 0], scale[index, 1], scale[index, 2], scale[index, 3] };

                byte[] query = Communication.Query(0x50, parameters);

                BackgroundWorker bgWorkWrite = new BackgroundWorker();
                bgWorkWrite.DoWork += new System.ComponentModel.DoWorkEventHandler(bgWorkWrite_DoWork);
                bgWorkWrite.RunWorkerAsync(argument: query);
            }
        }

        private void bgWorkWrite_DoWork(object sender, DoWorkEventArgs e)
        {
            byte[] query = (byte[])e.Argument;
            serialPort.Write(query, 0, query.Length);
        }
    }
}
