using System.Threading;
using System.Windows.Forms;

namespace Aplikacja_MEMS
{
    class MotionSensor : Sensor
    {
        int counter = 0;
        int[,] data = new int[10000000, 4];

        public MotionSensor(byte sensorNumber, byte sensorActivate, string name, int sensWidth, float sensOdr)
        {
            sensorName = name;
            activate = sensorActivate;
            sensorNr = sensorNumber;
            isEnabled = false;
            type = "Motion";
            width = sensWidth;
            odr = sensOdr;
        }

        public override void AddData(object data)
        {
            ParameterizedThreadStart addDataStart = new ParameterizedThreadStart(AddNewData);
            Thread addData = new Thread(addDataStart);
            addData.Start(data);
        }

        private void AddNewData(object data)
        {
            try
            {
                for (int i = 0; i < 4; i++)
                    this.data[counter, i] = ((int[])data)[i];

                counter++;
                this.plot.AddPoints((int[])data);
            }
           catch
            {
                counter = 0;
            }
        }
        public void SetScale(byte[] parameter)
        {
            Communication.Query((byte)CmdType.SensorCmd, (byte)SubCmdType.SetSensorScale, this.sensorNr, parameter);
        }

        public override void ClearData()
        {
            this.data = new int[10000000, 3];
            counter = 0;
        }
        public override string GetData()
        {
            string toReturn = sensorName + "\n" + 3 + "\n";

            for (int i = 0; i < counter; i++)
            {
                for(int j=0; j<4; j++)
                toReturn += data[i,j].ToString() + "|";

                toReturn += "\n";
            }

            return toReturn;
        }
    }
}
