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
        static BackgroundWorker bgWorkReceive;
        static BackgroundWorker bgWorkWrite;
        UserForm user;

        public Communication(UserForm u)
        {
            user = u;
        }

        public static byte[] Query(byte command, byte sensor, byte action, byte index, byte[] parameters)
        {
            byte[] query = new byte[2048];
            int complement = 0;

            query[0] = 0x32;
            query[1] = 0x01;
            query[2] = command;
            complement = 3;
            switch (command)
            {
                case 0x0C:
                    byte[] time = CurrentTime();

                    for (int i = 0; i < 3; i++)
                    {
                        query[i + 3] = time[i];
                    }

                    query[6] = 0x15;
                    query[7] = 0x02;
                    query[8] = 0x19;
                    query[9] = 0x04;
                    complement = 10;
                    break;

                case 0x02: // Poszukiwanie dostępnych urządzeń STM
                    complement = 3;
                    break;

                case 0x50: // Wykonaj...
                    query[3] = action;
                    query[4] = sensor;
                    switch (action)
                    {
                        case 0x14:  // Podaj listę dostępnych sensorów
                            complement = 5;
                            break;
                        case 0x15:  // Załaduj sensori o indexie...
                            query[5] = index;
                            complement = 6;
                            break;
                        case 0x07: // Ustaw ODR wybranego sensora
                            query[5] = parameters[0];
                            query[6] = parameters[1];
                            query[7] = parameters[2];
                            query[8] = parameters[3];
                            complement = 9;
                            break;
                        case 0x05: // Ustaw skalę wybranego sensora
                            query[5] = parameters[0];
                            query[6] = parameters[1];
                            query[7] = query[8] = 0x00;
                            complement = 9;
                            break;
                    }
                    break;

                case 0x08: // Zmien stan sensora
                    query[3] = sensor;
                    query[4] = 0x00;
                    query[5] = 0x00;
                    query[6] = 0x00;
                    query[7] = 0xF4;
                    query[8] = 0x01;
                    query[9] = 0x00;
                    query[10] = 0x00;
                    complement = 11;
                    break;
            }

            // Dodawanie sumy kontrolnej
            query[complement] = CheckSum(query, complement);
            query[complement + 1] = 0xf0;

            // Wstawianie danych do tablicy zwrotnej
            byte[] dataReturn = new byte[complement + 2];
            Array.Copy(query, dataReturn, complement + 2);

            return dataReturn;
        }

        public static byte[] readSensorList(byte[] data, SerialPort port, ProgressBar pb)
        {
            int counter = 0;
            byte[] response = new byte[port.ReadBufferSize];

            // Wyslanie zapytania o dostępne sensori
            port.Write(data, 0, 7);
            Thread.Sleep(100); // Uśpienie wątku, aby płytka zdążyła responseowiedzieć
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
            byte[] time = new byte[3];

            DateTime currentTime = DateTime.Now;
            time[0] = (byte)currentTime.Hour;
            time[1] = (byte)currentTime.Minute;
            time[2] = (byte)currentTime.Second;

            return time;
        }

        public void Odbior(SerialPort port)
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
        private void bgWorkReceive_DoWork(object sender, DoWorkEventArgs e)
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

                    foreach (byte b in dataReceive)
                    {
                        //  doWyswietlenia += b.ToString();
                    }

                    // user.WyswietlDane(doWyswietlenia);
                }
                catch (Exception exc) { }
            }
        }

    }
}
