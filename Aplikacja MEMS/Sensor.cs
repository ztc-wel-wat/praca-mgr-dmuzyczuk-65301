using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja_MEMS
{
    class Sensor
    {
        private string name;
        private string model;
        public bool enabled = true;
        private GroupBox info;
        private SerialPort port;
        private static byte[] message;

        public Sensor(string n, string m, GroupBox i, SerialPort p)
        {
            name = n;
            model = m;
            info = i;
            port = p;

            info.Controls[0].Text = "Nazwa czujnika: " + model;
        }

        public static void SendMessage(byte[] toSend, SerialPort port)
        {
            message = toSend;
            BackgroundWorker bgWorkSend = new BackgroundWorker();
            bgWorkSend.DoWork += new System.ComponentModel.DoWorkEventHandler(bgWorkSend_DoWork);
            bgWorkSend.RunWorkerAsync(argument: port);
        }

        private static void bgWorkSend_DoWork(object sender, DoWorkEventArgs e)
        {
            SerialPort port = (SerialPort)e.Argument;
            port.Write(message, 0, message.Length);
        }
    }
}
