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
    }
}
