//using System;
//using System.Collections.Generic;
//using System.IO.Ports;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Aplikacja_MEMS
//{
//    class Humidity : Sensor
//    {
//        public Humidity(SerialPort sp, ComboBox cbDeviceList, Label n)
//        {
//            sensorName = n;
//            sensorNr = 0x05;
//            serialPort = sp;
//            cBoxDeviceList = cbDeviceList;
//            active = 0x04;

//            ODR = new byte[,] { { 0x00, 0x00, 0x80, 0x3F }, { 0x00, 0x00, 0xE0, 0x40 }, { 0x00, 0x00, 0x48, 0x41 } };

//            register = new SensorRegister();
//        }
//        public override void DrawPlot()
//        {
//            MessageBox.Show("Trwa rysowanie wykresu", "Higrometr");
//        }
//        public override void Get()
//        {

//        }

//    }
//}
