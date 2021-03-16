using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja_MEMS
{
    public abstract class Sensors
    {
        string sensorName;
        bool active;
        public static byte sensorNr;
        byte[] ODR;
        string[] sensorList;
        Communication communication;

        public abstract void DrawPlot();
        public abstract void Get();
        public abstract void Set();
        public abstract void OpenRegister();

        public static byte[] GetSensorsList()
        {
            byte[] parameters = new byte[] { 0x14, sensorNr};
            return parameters;
        }
    }
}
