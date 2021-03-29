using System;
namespace Aplikacja_MEMS.Sensors
{
    class EnvSensor : Sensor
    {
        byte[] data;
        public EnvSensor(byte sensorNumber, byte sensorActivate)
        {
            activate = sensorActivate;
            sensorNr = sensorNumber;
            isEnabled = false;
        }
    }
}
