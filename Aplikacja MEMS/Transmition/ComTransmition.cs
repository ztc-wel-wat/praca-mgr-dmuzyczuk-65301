using Aplikacja_MEMS.Analysis;
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
            catch
            {
                return;
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
                byte[] buffer = new byte[(int)Frame.FrameParameters.MaxFrameLength];
                int counter = 0;

                for (int i = 0; i < message.Length - 1; i++)
                {
                    if (message[i] == (byte)Frame.Identificators.FrameEnd || message[i] == 0xF1)
                    {
                        buffer[counter] = 0xF1;
                        counter++;

                        switch(message[i])
                        {
                            case 0xF0:
                                buffer[counter] = 0xF2;
                                break;
                            case 0xF1:
                                buffer[counter] = 0xF1;
                                break;
                        }
                    }
                    else buffer[counter] = message[i];
                    
                    counter++;
                }

                buffer[counter] = (byte)Frame.Identificators.FrameEnd;
                counter++;

                byte[] checkedMessage = new byte[counter];
                Array.Copy(buffer, checkedMessage, counter);

                serialPort.Write(checkedMessage, 0, checkedMessage.Length);
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
                return null;
        }

        public static void Read(object data)
        {
            receive = true;
            receiveByteStart = new ParameterizedThreadStart(Receive);
            receiveByte = new Thread(receiveByteStart);
            receiveByte.Priority = ThreadPriority.Highest;
            receiveByte.Start(data);
        }

        public static void StopRead()
        {
            receive = false;
        }

        public static void Receive(object parameters)
        {
            object[] param = (object[])parameters;

            Command<byte[]> command = (Command<byte[]>)(param[0]);
            List<Sensor> sensors = (List<Sensor>)(param[1]);
            RichTextBox rtBox = (RichTextBox)(param[2]);

            while (serialPort.IsOpen && receive)
            {
                try
                {
                    byte[] buffer = new byte[(int)Frame.FrameParameters.MaxFrameLength];
                    int counter = 0;
                    byte chSum = 0x00;

                    byte add = (byte)(serialPort.ReadByte());
                    
                    // Dodawanie kolejnych bajtów do buffora
                    while (add != (byte)Frame.Identificators.FrameEnd)
                    {
                        if(add == 0xF1)
                        {
                            add = (byte)(serialPort.ReadByte());
                            switch (add)
                            {
                                case 0xF1:
                                    add = 0xF1;
                                    break;
                                case 0xF2:
                                    add = 0xF0;
                                    break;
                            }
                        }

                        buffer[counter] = add;
                        counter++;
                        chSum += add;

                        add = (byte)(serialPort.ReadByte());
                    }

                    // Sprawdzanie sumy kontrolnej
                    if(chSum == 0x00)
                    {
                        byte[] frame = new byte[counter-1];
                        Array.Copy(buffer, frame, counter-1);

                        // Przypisywanie ramki (dane / komenda)
                        if (frame[2] == (byte)CmdType.SensorResp && frame[3] == (byte)SubCmdType.GetRegisterValue)
                            command.Enqueue(frame);

                        else if (frame[2] == (byte)CmdType.ResponseData)
                        {
                            // Wypisywanie danych
                            if (frame != null)
                            {
                                int sensorIndex = 0;
                                int startIndex = 9;

                                int inted = (System.BitConverter.ToInt32(frame, 3)) * 10;
                                DateTime timestamp = new DateTime(inted);

                                string showText = timestamp.ToString("H:mm:ss.ffffff") + " |";

                                foreach (Sensor s in sensors)
                                {
                                    showText += Analysis.FrameAnalysis.AddText(frame, sensorIndex, s, startIndex, inted);
                                    sensorIndex++;
                                }

                                if ((frame[7] & (1 << 6)) != 0)
                                {
                                    showText += "   0x" + frame[9].ToString("X2") + "   |";
                                    startIndex += 4;
                                }
                                else showText += "          |";

                                if (UserForm.showText)
                                {
                                    rtBox.Invoke((Action)delegate
                                    {
                                        rtBox.Text += (showText + "0x" + frame[7].ToString("X2") + "\n");
                                    });
                                }
                            }
                        }
                    }
                }
                catch { }
            }
        }

        public static void ClearBuffer()
        {
            Communication.Query((byte)CmdType.StopTransmition);
            Thread.Sleep(100);

            while (serialPort.IsOpen && serialPort.BytesToRead > 0)
            {
                string clear = serialPort.ReadExisting();
            }
        }
    }
}
