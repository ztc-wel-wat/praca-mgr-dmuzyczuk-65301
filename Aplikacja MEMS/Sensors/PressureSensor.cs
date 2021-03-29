//using System;
//using System.Collections.Generic;
//using System.IO.Ports;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Aplikacja_MEMS
//{
//    class Pressure : Sensor
//    {
//        public Pressure(SerialPort sp, ComboBox cbDeviceList, Label n)
//        {
//            sensorName = n;
//            sensorNr = 0x06;
//            serialPort = sp;
//            cBoxDeviceList = cbDeviceList;
//            active = 0x01;

//            ODR = new byte[,] { { 0x00, 0x00, 0x80, 0x3F }, { 0x00, 0x00, 0x20, 0x41 }, { 0x00, 0x00, 0xC8, 0x41 }, { 0x00, 0x00, 0x48, 0x42 }, { 0x00, 0x00, 0x96, 0x42 } };

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
