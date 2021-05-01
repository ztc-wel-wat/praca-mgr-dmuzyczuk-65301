using System;
using System.Threading;

namespace Aplikacja_MEMS.Sensors
{
    class EnvSensor : Sensor
    {
        int counter = 0;
        float[,] data = new float[1000000, 2];

        public EnvSensor(byte sensorNumber, byte sensorActivate, string name, int sensWidth, float sensOdr)
        {
            sensorName = name;
            activate = sensorActivate;
            sensorNr = sensorNumber;
            isEnabled = false;
            type = "Env";
            width = sensWidth;
            odr = sensOdr;
        }

        public override void AddData(object data)
        {
            ParameterizedThreadStart addDataStart = new ParameterizedThreadStart(AddNewData);
            Thread addData = new Thread(addDataStart);
            addData.Start(data);
        }

        public override void ClearData()
        {
            this.data = new float[1000000, 2];
            counter = 0;
        }

        public override string GetData()
        {
            string toReturn = sensorName + "\n" + 1 + "\n"; ;

            for (int i = 0; i < counter; i++)
            {
                toReturn += data[i, 0].ToString() + "|";
                toReturn += data[i, 1].ToString() + "|\n";
            }

            return toReturn;
        }

        private void AddNewData(object data)
        {
            try
            {
                this.data[counter, 0] = ((float[])data)[0];
                this.data[counter, 1] = ((float[])data)[1];

                counter++;
                plot.AddPoints((float[])data);
            }
            catch
            {
                counter = 0;
            }
        }
    }
}
