using System.Threading;

namespace Aplikacja_MEMS.Sensors
{
    class EnvSensor : Sensor
    {
        byte[] data;

        public EnvSensor(byte sensorNumber, byte sensorActivate, string name, int sensWidth)
        {
            sensorName = name;
            activate = sensorActivate;
            sensorNr = sensorNumber;
            isEnabled = false; 
            type = "Env";
            width = sensWidth;
        }

        public override void AddData(object data)
        {
            ParameterizedThreadStart addDataStart = new ParameterizedThreadStart(AddNewData);
            Thread addData = new Thread(addDataStart);
            addData.Start(data);
        }

        private void AddNewData(object data)
        {
            this.plot.AddPoints((float)data);
        }
    }
}
