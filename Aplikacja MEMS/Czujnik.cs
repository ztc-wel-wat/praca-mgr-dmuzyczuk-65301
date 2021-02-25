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
    class Czujnik
    {
        private string nazwa;
        private string model;
        public bool wlaczony = true;
        private GroupBox informacje;
        private SerialPort port;
        private static byte[] wiadomosc;

        public Czujnik(string n, string m, GroupBox i, SerialPort p)
        {
            nazwa = n;
            model = m;
            informacje = i;
            port = p;

            informacje.Controls[0].Text = "Nazwa czujnika: " + model;
        }

        public static void SendMessage(byte[] doWyslania, SerialPort port)
        {
            wiadomosc = doWyslania;
            BackgroundWorker bgWorkWyslij = new BackgroundWorker();
            bgWorkWyslij.DoWork += new System.ComponentModel.DoWorkEventHandler(bgWorkWyslij_DoWork);
            bgWorkWyslij.RunWorkerAsync(argument: port);
        }

        private static void bgWorkWyslij_DoWork(object sender, DoWorkEventArgs e)
        {
            SerialPort port = (SerialPort)e.Argument;
            port.Write(wiadomosc, 0, wiadomosc.Length);
        }
    }
}
