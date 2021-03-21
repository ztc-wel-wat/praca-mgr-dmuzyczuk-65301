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
    class Communication
    {
        public static BackgroundWorker bgWorkReceive;

        public static byte[] Query(byte command, byte[] parameters)
        {
            byte[] query = new byte[13];
            Array.Clear(query, 0, query.Length);
           
            int complement = 0;

            query[0] = 0x32;
            query[1] = 0x01;
            query[2] = command;
            complement = 3;
            switch (command)
            {
                case 0x0C:                                              // Ustawienie aktualnej daty i czasu
                    byte[] time = CurrentTime();
                    Array.Copy(time, 0, query, 3, time.Length);
                    complement = 10;
                    break;

                case 0x02:                                              // Przedstaw się
                    complement = 3;
                    break;

                case 0x50:                                              // Wykonaj...5
                    query[3] = parameters[0];                           // Subkomenda
                    query[4] = parameters[1];                           // Czujnik
                    switch (parameters[0])
                    {
                        case 0x14:                                      // Podaj listę dostępnych sensorów
                            complement = 5;
                            break;
                        case 0x15:                                      // Załaduj sensori o indexie...
                            query[5] = parameters[2];
                            complement = 6;
                            break;
                        case 0x07:                                      // Ustaw ODR wybranego sensora
                            query[5] = parameters[2];
                            query[6] = parameters[3];
                            query[7] = parameters[4];
                            query[8] = parameters[5];
                            complement = 9;
                            break;
                        case 0x05:                                      // Ustaw zakres wybranego sensora
                            query[5] = parameters[0];
                            query[6] = parameters[1];
                            query[7] = query[8] = 0x00;
                            complement = 9;
                            break;

                        case 0x02:                                      // Pobierz parametr rejestru
                            break;

                        case 0x03:                                      // Ustaw parametr rejestru
                            break;
                    }
                    break;

                case 0x08:                                              // Włącz przesył danych
                    query[3] = parameters[0];
                    query[4] = parameters[1];
                    query[5] = query[6] = query[7] = query[8] = query[9] = query[10] = 0x00;
                    complement = 11;
                    break;

                case 0x09:                                             // Wyłącz przesył danych
                    break;
            }

            // Dodawanie sumy kontrolnej
            query[complement] = CheckSum(query, complement);
            query[complement + 1] = 0xF0;

            // Wstawianie danych do tablicy zwrotnej
            byte[] dataSend = new byte[complement + 2];
            Array.Copy(query, dataSend, complement + 2);

            return dataSend;
        }

        public static byte[] readSensorList(byte[] data, SerialPort port, ProgressBar pb)
        {
            int counter = 0;
            byte[] response = new byte[port.ReadBufferSize];

            // Wyslanie zapytania o dostępne sensori
            port.Write(data, 0, data.Length);
            Thread.Sleep(100); // Uśpienie wątku, aby płytka zdążyła odpowiedzieć
            // Odebranie listy sensorów (w bajtach)
            counter = port.Read(response, 0, port.ReadBufferSize);

            // Przekopiowanie do tablicy o dopasowanym rozmiarze
            byte[] responseReturn = new byte[counter];
            Array.Copy(response, responseReturn, counter);

            pb.Value += 10;

            return responseReturn;
        }

        private static byte CheckSum(byte[] data, int dlugosc)
        {
            // Obliczanie sumy kontrolnej (przedostatni bajt ramki)
            byte value = 0xFF;
            for (int i = 0; i < dlugosc; i++)
            {
                value -= data[i];
            }

            // Dopełnienie do 0x100
            value += 0x01;

            return value;
        }

        private static byte[] CurrentTime()
        {
            byte[] time = new byte[7];

            DateTime currentTime = DateTime.Now;
            time[0] = (byte)currentTime.Hour;
            time[1] = (byte)currentTime.Minute;
            time[2] = (byte)currentTime.Second;
            time[3] = (byte)currentTime.Millisecond;
            time[4] = (byte)currentTime.Month;
            time[5] = (byte)currentTime.Day;
            time[6] = (byte)currentTime.Year;

            return time;
        }

        public static void Odbior(SerialPort port)
        {
            bgWorkReceive = new BackgroundWorker();
            bgWorkReceive.WorkerSupportsCancellation = true;
            bgWorkReceive.DoWork += new System.ComponentModel.DoWorkEventHandler(bgWorkReceive_DoWork);
            bgWorkReceive.RunWorkerAsync(argument: port);
        }

        public void StopRecieve()
        {
            if (bgWorkReceive.IsBusy)
                bgWorkReceive.CancelAsync();
        }
        public static void bgWorkReceive_DoWork(object sender, DoWorkEventArgs e)
        {
            SerialPort port = (SerialPort)e.Argument;
            byte[] data = new byte[4096];

            while (true)
            {
                try
                {
                    int byteCount = port.Read(data, 0, 4096);
                    byte[] dataReceive = new byte[byteCount];
                    Array.Copy(data, dataReceive, byteCount);
                }
                catch (Exception exc) { }
            }
        }
    }
}
