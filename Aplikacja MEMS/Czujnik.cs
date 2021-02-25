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
        private bool wlaczony = false;
        private GroupBox informacje;
        private SerialPort port;
        private byte[] wiadomosc;
        private int dlugosc = 0;

        private ThreadStart wyslijStart;
        private Thread wyslij;

        public Czujnik(string n, string m, GroupBox i, SerialPort p)
        {
            nazwa = n;
            model = m;
            informacje = i;
            port = p;

            informacje.Controls[0].Text = "Nazwa czujnika: " + model;
        }

        public void SendMessage(byte[] doWyslania)
        {
            wiadomosc = doWyslania;
            BackgroundWorker bgWorkSend = new BackgroundWorker();
            bgWorkSend.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkSend_DoWork);
            bgWorkSend.RunWorkerAsync();
        }

        private void bgWorkSend_DoWork(object sender, DoWorkEventArgs e)
        {
            port.Write(wiadomosc, 0, wiadomosc.Length);
        }


    }
}
