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
        static Loading loading = new Loading();
        static ThreadStart startBar = new ThreadStart(StartProgressBar);

        public static SerialPort serialPort = new SerialPort();

        // BGWorker odbioru danych
        static ParameterizedThreadStart receiveByteStart;
        static Thread receiveByte;

        public static BackgroundWorker bgWorkReceive = new BackgroundWorker();
        private static bool receive = false;

        // Uruchomienie wątku paska ładowania
        private static void StartProgressBar()
        {
            loading = new Loading();
            Application.Run(loading);
        }

        // Pobieranie listy dostępnych portów MEMS
        public static List<AvailablePort> CheckAvaliablePorts()
        {
            List<AvailablePort> memsPorts = new List<AvailablePort>();
            string[] comPorts = SerialPort.GetPortNames();

            // Włączenie paska ładowania
            Thread progressBar = new Thread(startBar);
            progressBar.Start();
            Thread.Sleep(100);

            // Przepytanie wszystkich portów "Who are You"
            foreach (string name in comPorts)
            {
                OpenPort(name);
                ClearBuffer();

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
                    AvailablePort memsPort = new AvailablePort(name, Encoding.UTF8.GetString(response, 3, length - 5));

                    // Dodawanie nr portu i nazwy urządzenia do listy
                    memsPorts.Add(memsPort);
                }
                catch
                {
                    serialPort.ReadTimeout = -1;
                    serialPort.Close();
                }

                serialPort.ReadTimeout = -1;
                serialPort.Close();

                // Aktualizowanie paska ładowania
                loading.Update((int)((1 / comPorts.Length) * 100));
                Thread.Sleep(500);
            }

            if (comPorts.Length == 0)
                loading.Update(100);

            // Wyłączenie paska ładowania
            loading.Disable();

            return memsPorts;
        }

        public static void OpenPort(string name)
        {
            try
            {
                serialPort.PortName = name;
                serialPort.BaudRate = 921600;
                serialPort.ReadBufferSize = 16384;
                serialPort.Open();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void ClosePort()
        {
            if (serialPort.IsOpen)
            {
                StopRead();
                serialPort.DiscardInBuffer();
                serialPort.DiscardOutBuffer();
                serialPort.Close();
            }
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
            if (serialPort.IsOpen)
            {
                byte[] message = (byte[])e.Argument;
                serialPort.Write(message, 0, message.Length);
            }
        }

        // Odbiór danych
        public static byte[] ReadMessage()
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

        public static void Read(Queue<byte> data)
        {
            receive = true;
            receiveByteStart = new ParameterizedThreadStart(Receive);
            receiveByte = new Thread(receiveByteStart);
            receiveByte.Start(data);
        }

        public static void StopRead()
        {
            receive = false;
        }

        public static void Receive(object data)
        {
            byte readData;
            while (serialPort.IsOpen && receive)
            {
                try
                {
                    ((Queue<byte>)data).Enqueue((byte)serialPort.ReadByte());
                }
                catch { }
            }
        }

        public static void ClearBuffer()
        {
            Communication.Query((byte)CmdType.StopTransmition);
            Thread.Sleep(100);

            while (serialPort.BytesToRead > 0)
            {
                string clear = serialPort.ReadExisting();
            }
        }
    }
}
