using System.Threading;

namespace Aplikacja_MEMS.Sensors
{
    class EnvSensor : Sensor
    {
        int counter = 0;
        float[] data = new float[10000000];

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
            this.data = new float[10000000];
            counter = 0;
        }

        public override string GetData()
        {
            string toReturn = sensorName + "\n" + 1 + "\n"; ;

            for(int i = 0; i< counter; i++)
            {
                toReturn += data[i].ToString() + "\n";
            }

            return toReturn;
        }

        private void AddNewData(object data)
        {
            this.data[counter] = (int)data;

            counter++;
            plot.AddPoints((float)data);
        }
    }
}
