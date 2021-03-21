using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja_MEMS
{
    class Termometer : Sensor
    {
        public Termometer(SerialPort sp, ComboBox cbDeviceList, Label n)
        {
            sensorName = n;
            sensorNr = 0x04;
            serialPort = sp;
            cBoxDeviceList = cbDeviceList;
            active = 0x02;

            ODR = new byte[,] { { 0x00, 0x00, 0x80, 0x3F }, { 0x00, 0x00, 0xE0, 0x40 }, { 0x00, 0x00, 0x48, 0x41 } };

        }
        public override void DrawPlot()
        {
            MessageBox.Show("Trwa rysowanie wykresu", "Magnetometr");
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
