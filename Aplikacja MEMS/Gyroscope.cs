using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja_MEMS
{
    class Gyroscope : Motion
    {
        public Gyroscope(SerialPort sp, ComboBox cbDeviceList, byte a, Label n)
        {
            sensorName = n;
            sensorNr = 0x02;
            serialPort = sp;
            cBoxDeviceList = cbDeviceList;
            active = a;

            ODR = new byte[,] { { 0x00, 0x00, 0x48, 0x41 }, { 0x00, 0x00, 0xD0, 0x41 }, { 0x00, 0x00, 0x50, 0x42 }, { 0x00, 0x00, 0xD0, 0x42 }, { 0x00, 0x00, 0x50, 0x43 },
                { 0x00, 0x00, 0xD0, 0x43 }, { 0x00, 0x40, 0x50, 0x44 }, { 0x00, 0x80, 0xCF, 0x44 }, { 0x00, 0x20, 0x50, 0x45 }, { 0x00, 0x20, 0xD0, 0x45 } };

            scale = new byte[,] { { 0x7D, 0x00, 0x00, 0x00 }, { 0xFA, 0x00, 0x00, 0x00 }, { 0xF4, 0x01, 0x00, 0x00 }, { 0xE8, 0x03, 0x00, 0x00 }, { 0xD0, 0x07, 0x00, 0x00 } };
        }
        public override void DrawPlot()
        {
            MessageBox.Show("Trwa rysowanie wykresu", "Żyroskoop");
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
