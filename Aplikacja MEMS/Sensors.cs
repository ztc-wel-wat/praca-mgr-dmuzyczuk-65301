﻿using System;
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
    public abstract class Sensors
    {
        string sensorName;
        public byte active;
        public static byte sensorNr;
        byte[] ODR;
        string[] sensorList;
        public SerialPort serialPort;
        public ComboBox cBoxDeviceList;

        public abstract void DrawPlot();
        public abstract void Get();
        public abstract void Set();
        public abstract void OpenRegister();

        public void GetSensorsList()
        {
            List<string> sensors = new List<string>();
            byte[] response = new byte[serialPort.ReadBufferSize];
            byte[] parameters = new byte[] { 0x14, sensorNr };
            serialPort.Write(Communication.Query(0x50, parameters), 0, 7);

            Thread.Sleep(100);

            serialPort.Read(response, 0, serialPort.ReadBufferSize);

            ASCIIEncoding ascii = new ASCIIEncoding();
            string bufor = string.Empty;
            int begin = 10;

            // Wyszukiwanie znaku przecinka, tlumaczenie oraz tworzenie listy urządzen na string
            for (int i = 5; i < (response.Length - 2); i++)
            {
                switch (response[i])
                {
                    case 0x2C:
                        bufor = ascii.GetString(response, begin, i - begin);
                        sensors.Add(bufor);
                        bufor = string.Empty;
                        begin = i + 1;
                        break;
                }
            }

            // Dodawanie ostatniego sensora (po nim nie ma znaku przecinka
            bufor = ascii.GetString(response, begin, (response.Length - 2) - begin);
            sensors.Add(bufor);

            // Aktualizowanie comboboxów wyboru sensora
            foreach (string sensor in sensors)
            {
                cBoxDeviceList.Items.Add(sensor);
            }

            cBoxDeviceList.Text = cBoxDeviceList.Items[0].ToString();
        }

        public void SetSensor()
        {
            BackgroundWorker bgWorkWrite = new BackgroundWorker();
            bgWorkWrite.DoWork += new System.ComponentModel.DoWorkEventHandler(bgWorkWrite_DoWork);

            byte[] parameters = new byte[3];
            parameters[0] = 0x15;
            parameters[1] = sensorNr;
            parameters[2] = (byte)cBoxDeviceList.SelectedIndex;

            byte[] query = Communication.Query(0x50, parameters);

            bgWorkWrite.RunWorkerAsync(argument: query);

            cBoxDeviceList.Enabled = false;
        }

        public void SetEnable(bool enabled)
        {
            if (enabled)
                UserForm.sensor += active;
            else
                UserForm.sensor -= active;

            byte[] parameters = new byte[8];
            parameters[0] = UserForm.sensor;
            parameters[1] = 0x01;
            parameters[2] = parameters[3] = parameters[4] = parameters[5] = parameters[6] = parameters[7] = 0x00;

            byte[] query = Communication.Query(0x08, parameters);

            BackgroundWorker bgWorkWrite = new BackgroundWorker();
            bgWorkWrite.DoWork += new System.ComponentModel.DoWorkEventHandler(bgWorkWrite_DoWork);
            bgWorkWrite.RunWorkerAsync(argument: query);
        }

        private void bgWorkWrite_DoWork(object sender, DoWorkEventArgs e)
        {
            byte[] query = (byte[])e.Argument;
            serialPort.Write(query, 0, query.Length);
        }
    }
}
