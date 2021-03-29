//using System;
//using System.Collections.Generic;
//using System.IO.Ports;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Aplikacja_MEMS
//{
//    class Magnetometer : MotionSensor
//    {
//        public Magnetometer(SerialPort sp, ComboBox cbDeviceList, Label n)
//        {
//            sensorName = n;
//            sensorNr = 0x03;
//            serialPort = sp;
//            cBoxDeviceList = cbDeviceList;
//            active = 0x40;

//            ODR = new byte[,] { { 0x00, 0x00, 0x20, 0x41 }, { 0x00, 0x00, 0xA0, 0x41 }, { 0x00, 0x00, 0x48, 0x42 }, { 0x00, 0x00, 0xC8, 0x42 } };

//            register = new SensorRegister();
//        }
//        public override void DrawPlot()
//        {
//            MessageBox.Show("Trwa rysowanie wykresu", "Magnetometr");
//        }
//        public override void Get()
//        {

//        }
//    }
//}
