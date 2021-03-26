using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Aplikacja_MEMS.Transmition
{
    static class ComTransmition
    {
        // Stałe paska ładowania
        static ThreadStart startBar = new ThreadStart(StartprogressBar);
        static Thread progressBar = new Thread(startBar);
        static Loading loading;

        public static SerialPort serialPort = new SerialPort();

        // BGWorker odbioru danych
        public static BackgroundWorker bgWorkReceive = new BackgroundWorker();

        // Uruchomienie wątku paska ładowania
        private static void StartprogressBar()
        {
            loading = new Loading();
            Application.Run(loading);
        }

        // Pobieranie listy dostępnych portów MEMS
        public static List<AvailablePort> CheckAvaliablePorts()
        {
            // Ustawienie parametrów portu COM
            serialPort.BaudRate = 921600;
            serialPort.ReadBufferSize = 16384;

            List<AvailablePort> memsPorts = new List<AvailablePort>();
            string[] comPorts = SerialPort.GetPortNames();

            // Włączenie paska ładowania
            progressBar.Start();

            // Przepytanie wszystkich portów "Who are You"
            foreach (string s in comPorts)
            {
                serialPort.PortName = s;
                serialPort.Open();

                // Wysłanie zapytania
                Communication.Query((byte)CmdType.WhoAreYou);
                byte[] response = new byte[serialPort.ReadBufferSize];
                try
                {
                    // Oczekiwanie do 2sek na odpowiedź
                    serialPort.ReadTimeout = 300;
                    Thread.Sleep(300);

                    // Pobieranie odpowiedzi od urządzenia
                    int length = serialPort.Read(response, 0, response.Length);
                    AvailablePort memsPort = new AvailablePort(s, Encoding.UTF8.GetString(response, 3, length - 5));

                    // Dodawanie nr portu i nazwy urządzenia do listy
                    memsPorts.Add(memsPort);
                }
                catch (TimeoutException timeout)
                {
                    serialPort.ReadTimeout = -1;
                }

                serialPort.Close();

                // Aktualizowanie paska ładowania
                loading.Update((int)((1 / comPorts.Length) * 100));
                Thread.Sleep(500);
            }

            // Wyłączenie paska ładowania
            loading.Disable();

            return memsPorts;
        }

        public static void OpenPort(string name)
        {
            serialPort.PortName = name;
            serialPort.BaudRate = 921600;
            serialPort.ReadBufferSize = 16384;

            serialPort.Open();
        }


        // Nadwanie wiadomości
        public static void SendMessage(byte[] message)
        {
            BackgroundWorker bgWorkSend = new BackgroundWorker();
            bgWorkSend.DoWork += new System.ComponentModel.DoWorkEventHandler(bgWorkSend_DoWork);
            bgWorkSend.WorkerSupportsCancellation = true;
            bgWorkSend.WorkerReportsProgress = true;
            bgWorkSend.RunWorkerAsync(argument: message);
        }

        private static void bgWorkSend_DoWork(object sender, DoWorkEventArgs e)
        {
            byte[] message = (byte[])e.Argument;
            serialPort.Write(message, 0, message.Length);
        }

        // Odbiór danych
        public static byte[] ReadMessage()
        {
            try
            {
                byte[] message = new byte[serialPort.ReadBufferSize];
                int length = serialPort.Read(message, 0, serialPort.ReadBufferSize);

                if (length > 0)
                {
                    byte[] retMessage = new byte[length];
                    Array.Copy(message, retMessage, length);

                    return retMessage;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception exc)
            {
                return null;
            }
        }

        public static void Read()
        {
            bgWorkReceive.DoWork += new System.ComponentModel.DoWorkEventHandler(bgWorkReceive_DoWork);
            bgWorkReceive.WorkerSupportsCancellation = true;
            bgWorkReceive.WorkerReportsProgress = true;
            bgWorkReceive.RunWorkerAsync();
        }

        public static void bgWorkReceive_DoWork(object sender, DoWorkEventArgs e)
        {
            byte[] data = new byte[serialPort.ReadBufferSize];
            while (!UserForm.semafor)
            {
                try
                {
                    serialPort.Read(data, 0, data.Length);
                }
                catch (Exception exc) { }
            }
        }

    }
}
