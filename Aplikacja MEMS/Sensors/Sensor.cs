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
    public abstract class Sensor
    {
        public static byte enableByte = 0x77;
        public static byte enableInterruptByte = 0x01;
        public Label sensorName;
        public byte active;
        public byte sensorNr;
        public byte[,] ODR;
        public SerialPort serialPort;
        public ComboBox cBoxDeviceList;
        public SensorRegister register;

        public abstract void DrawPlot();
        public abstract void Get();
        public void OpenRegister(string name)
        {
            if (register.Visible == false)
            {
                register = new SensorRegister();
                register.Text = "Rejestr " + name;
                register.Visible = true;
            }
            else
            {
                register.TopMost = true;
                register.TopMost = false;
            }
        }

        // Pobieranie listy dostępnych sensrów na płytce
        public void GetSensorsList()
        {
            byte[] response = new byte[serialPort.ReadBufferSize];

            // Wysłanie zapytanie o sensory
            byte[] parameters = new byte[] { 0x14, sensorNr };
            serialPort.Write(Communication.Query(0x50, parameters), 0, 7);

            // Oczekiwanie, aby płytka zdążyła odpowiedzieć
            Thread.Sleep(50);

            // Odbiór odpowiedzi
            serialPort.Read(response, 0, serialPort.ReadBufferSize);

            // Dekodowanie odpowiedzi
            ASCIIEncoding ascii = new ASCIIEncoding();
            string bufor = string.Empty;

            int begin = 0;
            for (int i = 0; response[i] != 0x14; i++)
            {
                begin = i + 3;
            }

            // Wyszukiwanie znaku przecinka, tlumaczenie oraz tworzenie listy urządzen na string
            for (int i = 5; i < (response.Length - 2); i++)
            {
                switch (response[i])
                {
                    case 0x2C:
                        bufor = ascii.GetString(response, begin, i - begin);
                        cBoxDeviceList.Items.Add(bufor);
                        bufor = string.Empty;
                        begin = i + 1;
                        break;
                }
            }

            // Dodawanie ostatniego sensora (po nim nie ma znaku przecinka
            bufor = ascii.GetString(response, begin, (response.Length - 4) - begin);
            cBoxDeviceList.Items.Add(bufor);

            cBoxDeviceList.SelectedIndex = 0;
        }

        // Ustawianie wybranego sensora do pracy
        public void SetSensor()
        {
            BackgroundWorker bgWorkWrite = new BackgroundWorker();
            bgWorkWrite.DoWork += new System.ComponentModel.DoWorkEventHandler(bgWorkWrite_DoWork);

            // Tworzenie ramki
            byte[] parameters = new byte[3];
            parameters[0] = 0x15;
            parameters[1] = sensorNr;
            parameters[2] = (byte)cBoxDeviceList.SelectedIndex;

            byte[] query = Communication.Query(0x50, parameters);

            bgWorkWrite.RunWorkerAsync(argument: query);

            cBoxDeviceList.Enabled = false;
        }

        // Włączanie/wyłączanie sensora
        public void SetEnable(bool enabled)
        {
            // Podnoszenie/opuszczanie flagi włączenia sensora
            if (enabled)
                enableByte += active;
            else
                enableByte -= active;

            // Tworzenie ramki
            byte[] parameters = new byte[8];
            parameters[0] = enableByte;
            parameters[1] = enableInterruptByte;
            parameters[2] = parameters[3] = parameters[4] = parameters[5] = parameters[6] = parameters[7] = 0x00;

            byte[] query = Communication.Query(0x08, parameters);

            BackgroundWorker bgWorkWrite = new BackgroundWorker();
            bgWorkWrite.DoWork += new System.ComponentModel.DoWorkEventHandler(bgWorkWrite_DoWork);
            bgWorkWrite.RunWorkerAsync(argument: query);
        }

        // Ustawianie ODR
        public void SetODR(int index)
        {
            if (serialPort.IsOpen)
            {
                byte[] parameters = new byte[] { 0x07, sensorNr, ODR[index, 0], ODR[index, 1], ODR[index, 2], ODR[index, 3] }; 
                
                byte[] query = Communication.Query(0x50, parameters);

                BackgroundWorker bgWorkWrite = new BackgroundWorker();
                bgWorkWrite.DoWork += new System.ComponentModel.DoWorkEventHandler(bgWorkWrite_DoWork);
                bgWorkWrite.RunWorkerAsync(argument: query);
            }
        }

        public void SetParameter(string address, string value)
        {
            try
            {
            byte a = (byte)(Int32.Parse(address));
            byte v = (byte)(Int32.Parse(value));

            byte[] parameters = new byte[] { 0x03, sensorNr, a, v};

            byte[] query = Communication.Query(0x50, parameters);

            BackgroundWorker bgWorkWrite = new BackgroundWorker();
            bgWorkWrite.DoWork += new System.ComponentModel.DoWorkEventHandler(bgWorkWrite_DoWork);
            bgWorkWrite.RunWorkerAsync(argument: query);
            }
            catch (Exception exc) { };
        }

        public void ReadParameter(string address)
        {
            try
            {
                byte a = (byte)(Int32.Parse(address));

                byte[] parameters = new byte[] { 0x02, sensorNr, a};

                byte[] query = Communication.Query(0x50, parameters);

                BackgroundWorker bgWorkWrite = new BackgroundWorker();
                bgWorkWrite.DoWork += new System.ComponentModel.DoWorkEventHandler(bgWorkWrite_DoWork);
                bgWorkWrite.RunWorkerAsync(argument: query);
            }
            catch (Exception exc) { };

        }

        // Dodatkowy wątek do wysyłania danych przez dany czujnik (obiekt)
        private void bgWorkWrite_DoWork(object sender, DoWorkEventArgs e)
        {
            byte[] query = (byte[])e.Argument;
            serialPort.Write(query, 0, query.Length);
        }
    }
}
