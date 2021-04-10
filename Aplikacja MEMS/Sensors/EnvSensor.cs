using System;
namespace Aplikacja_MEMS.Sensors
{
    class EnvSensor : Sensor
    {
        byte[] data;

        public EnvSensor(byte sensorNumber, byte sensorActivate, string name)
        {
            sensorName = name;
            activate = sensorActivate;
            sensorNr = sensorNumber;
            isEnabled = false;
        }
    }
}
