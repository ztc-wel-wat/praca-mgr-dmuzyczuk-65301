namespace Aplikacja_MEMS
{
    class MotionSensor : Sensor
    {
        byte[] data;

        public MotionSensor(byte sensorNumber, byte sensorActivate, string name, int sensWidth)
        {
            sensorName = name;
            activate = sensorActivate;
            sensorNr = sensorNumber;
            isEnabled = false;
            type = "Motion";
            width = sensWidth;
    }

        public void SetScale(byte[] parameter)
        {
            Communication.Query((byte)CmdType.SensorCmd, (byte)SubCmdType.SetSensorScale, this.sensorNr, parameter);
        }

    }
}
