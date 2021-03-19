using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja_MEMS
{
    class Accelerometer : Sensors
    {
        public Accelerometer(SerialPort sp, ComboBox cbDeviceList, byte a)
        {
            sensorNr = 0x01;
            serialPort = sp;
            cBoxDeviceList = cbDeviceList;
            active = a;
        }

        public override void DrawPlot()
        {
            MessageBox.Show("Trwa rysowanie wykresu", "Akcelerometr");
        }
        public override void Get()
        {

        }

        public override void Set()
        {

        }
        
        public override void OpenRegister()
        {

        }

    }
}
