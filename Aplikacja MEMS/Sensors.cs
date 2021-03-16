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
        byte sensorNr;
        byte[] ODR;

        public abstract void DrawPlot();
        public abstract void Get();
        public abstract void Set();
        public abstract void OpenRegister();
    }
}
