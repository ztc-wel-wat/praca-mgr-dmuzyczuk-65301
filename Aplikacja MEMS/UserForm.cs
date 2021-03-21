using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja_MEMS
{
    public partial class UserForm : Form
    {
        List<Control> enableDisable = new List<Control>();
        List<ComboBox> clear = new List<ComboBox>();
        List<GroupBox> gBoxMEMSSensors = new List<GroupBox>();
        List<Sensor> sensors = new List<Sensor>();
        List<CheckBox> checks = new List<CheckBox>();

        string[] comPorts;

        Loading loading = new Loading();
        ThreadStart loadingBar;
        Thread bar;

        Accelerometer acc;
        Gyroscope gyr;
        Magnetometer mag;
        Termometer ter;
        Humidity hig;
        Pressure pre;

        BackgroundWorker bgWorkWrite;

        byte[] parameters;
        int response = 0;
        byte[] resp = new byte[4096];

        public UserForm()
        {
            InitializeComponent();
            Sensor.enableByte = 0x77;
            Sensor.enableInterruptByte = 0x01;

            acc = new Accelerometer(serialPort, cBoxAccelerometer, accNameLab);
            gyr = new Gyroscope(serialPort, cBoxGyroscope,  gyroNameLab);
            mag = new Magnetometer(serialPort, cBoxMagnetometer,  magNameLab);
            ter = new Termometer(serialPort, cBoxThermometer,  terNameLab);
            hig = new Humidity(serialPort, cBoxHumidity, higNameLab);
            pre = new Pressure(serialPort, cBoxPressure, barNameLab);

            // Tworzenie listy sensorów
            sensors.Add(acc);
            sensors.Add(gyr);
            sensors.Add(mag);
            sensors.Add(ter);
            sensors.Add(hig);
            sensors.Add(pre);

            // Tworezenie zmiennych pomocniczych
            parameters = new byte[8];
            parameters[0] = Sensor.enableByte;
            parameters[1] = Sensor.enableInterruptByte;
            parameters[2] = parameters[3] = parameters[4] = parameters[5] = parameters[6] = parameters[7] = 0x00;

            // Ustawienie rozmiaru groupBoxów
            gBoxInfo.Height = tabPageGeneral.Height / 3;
            gBoxConnection.Height = tabPageGeneral.Height / 3;
            gBoxSensors.Height = tabPageGeneral.Height / 3;

            // Tworzenie listy kontrolek aktywowanych/dezaktywowanych podczas otwierania portu
            enableDisable.Add(cBoxAccelerometer);
            enableDisable.Add(cBoxPressure);
            enableDisable.Add(cBoxHumidity);
            enableDisable.Add(cBoxMagnetometer);
            enableDisable.Add(cBoxThermometer);
            enableDisable.Add(cBoxGyroscope);
            enableDisable.Add(buttonStart);
            enableDisable.Add(buttonClose);
            enableDisable.Add(cBoxPorts);
            enableDisable.Add(buttonStart);
            enableDisable.Add(buttonStop);

            // Lista comboboxów do wyczyszczenia po ponownym załądowaniu portu COM
            clear.Add(cBoxAccelerometer);
            clear.Add(cBoxPressure);
            clear.Add(cBoxHumidity);
            clear.Add(cBoxMagnetometer);
            clear.Add(cBoxThermometer);
            clear.Add(cBoxGyroscope);

            // Lista groupBoxów do włączania/wyłączania podczas przesyłu danych
            gBoxMEMSSensors.Add(gBoxAccelerometer);
            gBoxMEMSSensors.Add(gBoxPressure);
            gBoxMEMSSensors.Add(gBoxHumidity);
            gBoxMEMSSensors.Add(gBoxMagnetometer);
            gBoxMEMSSensors.Add(gBoxTermometer);
            gBoxMEMSSensors.Add(gBoxGyroscope);

            // Parametry poczatkowe w listach wybieranych zakładki "Czujniki MEMS"
            cBoxAccODR.Text = cBoxAccODR.Items[0].ToString();
            cBoxPreODR.Text = cBoxPreODR.Items[0].ToString();
            cBoxMagODR.Text = cBoxMagODR.Items[0].ToString();
            cBoxGyroODR.Text = cBoxGyroODR.Items[0].ToString();
            cBoxTermODR.Text = cBoxTermODR.Items[0].ToString();
            cBoxHumODR.Text = cBoxHumODR.Items[0].ToString();

            cBoxAccScale.Text = cBoxAccScale.Items[0].ToString();
            cBoxMagScale.Text = cBoxMagScale.Items[0].ToString();
            cBoxGyroScale.Text = cBoxGyroScale.Items[0].ToString();

            // Włączenie paska ładowania dostępnych urządzeń
            loadingBar = new ThreadStart(StartPaska);
            bar = new Thread(loadingBar);
            bar.Start();

            // Ustalenie listy checkBoxów
            checks.Add(chBoxAccEnabled);
            checks.Add(chBoxGyroEnabled);
            checks.Add(chBoxMagEnabled);
            checks.Add(chBoxTermEnabled);
            checks.Add(chBoxHumEnabled);
            checks.Add(chBoxPreEnabled);
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            BackgroundWorker bgW = new BackgroundWorker();

            // Załądowanie listy wszystkich dostępnych portów COM
            comPorts = SerialPort.GetPortNames();
            List<string> MEMSPorts = new List<string>();

            int licznik = 0;
            // Tworzenie listy portów COM z prespiętym urządzeniem MEMS
            foreach (string port in comPorts)
            {
                bgW = new BackgroundWorker();

                try
                {
                    // Otwarcie portu
                    serialPort.PortName = port;
                    serialPort.Open();

                    // Czyszczenie bufora systemowego
                    serialPort.ReadExisting();

                    // Wysłanie zapytania do urządzenia 
                    serialPort.Write(Communication.Query(0x02, null), 0, 5);

                    // Pobranie odpowiedzi z bufora COM
                    Task awaiting = Await();
                    awaiting.Wait(2000);            // oczekiwanie 2 sek. na odpowiedź urządzenia

                    // Dodawanie spisu dostępnych urządzeń (napis w boxie "Informacje")
                    if (response > 0)
                    {
                        labelNoBoards.Visible = false; // Ukrycie informacji o braku urządzeń

                        labelCOM = new Label();
                        labelCOM.AutoSize = true;
                        labelCOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                        labelCOM.Location = new System.Drawing.Point(20, 85 + (licznik * 15));
                        labelCOM.Name = "label" + port;
                        labelCOM.Size = new System.Drawing.Size(146, 17);
                        labelCOM.Text = port + ": " + Encoding.UTF8.GetString(resp, 3, response - 5);
                        labelCOM.Visible = true;
                        gBoxInfo.Controls.Add(this.labelCOM);
                        MEMSPorts.Add(port);

                    }
                    serialPort.Close();
                }
                catch (Exception exc)
                {
                    if (serialPort.IsOpen)
                        serialPort.Close();
                }

                bgW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
                bgW.RunWorkerAsync();
                Thread.Sleep(300);
            }


            // Metoda oczekująca na odpowiedz urządzenia pod zadanym portem
            async Task<byte[]> Await()
            {
                response = serialPort.Read(resp, 0, serialPort.ReadBufferSize);
                return resp;
            }

            // Przypisanie listy dostępnych portów COM z podłączonymi urządzeniami MEMS do okna wybory (comboBox)
            foreach (string port in MEMSPorts)
            {
                cBoxPorts.Items.Add(port);
            }

            bgW = new BackgroundWorker();
            bgW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            bgW.RunWorkerAsync();
            Thread.Sleep(500);

            // Zamknięcie okna ładowania aplikacji
            Action<int> updateAction1 = new Action<int>((value) => loading.Close());
            loading.Invoke(updateAction1, 32);
        }
        private System.Windows.Forms.Label labelCOM;

        // Wyszukiwanie urządzeń (progress bar po włączeniu)
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Ładowanie progressBar podczas włączania aplikacji
            if (loading.progressBar.Value < 90)
            {
                if (comPorts.Length != 0)
                {
                    // Dodawanie paska progressbara
                    Action<int> updateAction = new Action<int>((value) => loading.progressBar.Value += 90 / comPorts.Length);
                    loading.progressBar.Invoke(updateAction, 32);
                }
            }
            else
            {
                // 100% paska 
                Action<int> updateAction = new Action<int>((value) => loading.progressBar.Value = 100);
                loading.progressBar.Invoke(updateAction, 32);
            }
        }

        // Wyświetlenie ap[likacji na wierzchu, po załadowaniu
        private void UserForm_Shown(object sender, EventArgs e)
        {
            this.TopMost = false;
        }

        private void buttonOtworz_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] resp = new byte[serialPort.ReadBufferSize];

                serialPort.PortName = cBoxPorts.Text;
                serialPort.Open();

                // Czyszczenie listy poprzednich urzadzen
                foreach (ComboBox cBox in clear)
                {
                    cBox.Items.Clear();
                }
                
                // Wysłanie ustawień początkowych aplikacji
                serialPort.Write(Communication.Query(0x0C, null), 0, 12);

                buttonOpen.Enabled = false;
                cBoxPorts.Enabled = false;

                
                foreach(Sensor s in sensors)
                {
                    s.GetSensorsList();
                }

                progressBarCOM.Value = 90;

                // Włączanie/wyłączanie przycisków
                foreach (Control control in enableDisable)
                {
                    control.Enabled = true;
                }

                buttonOpen.Enabled = false;
                buttonStop.Enabled = false;
                cBoxPorts.Enabled = false;

                // Rozpoczęcie pobierania danych
                Communication.Read(serialPort);

                progressBarCOM.Value = 100;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Wystąpił błąd podczas połączenia z portem szeregowym. Sprawdź parameters połączenia.", "Błąd");
                if (serialPort.IsOpen)
                    serialPort.Close();

                progressBarCOM.Value = 0;

                // Włączanie/wyłączanie przycisków
                foreach (Control control in enableDisable)
                {
                    control.Enabled = false;
                }

                buttonOpen.Enabled = true;
                cBoxPorts.Enabled = true;
            }
        }
        private void buttonZamknij_Click(object sender, EventArgs e)
        {
            // Wstrzymanie wysylania informacji przez płytkę
            serialPort.Write(Communication.Query(0x09, null), 0, 5);

            if (serialPort.IsOpen)
                serialPort.Close();

            Communication.StopRecieve();

            progressBarCOM.Value = 0;

            // Włączanie/wyłączanie przycisków
            foreach (Control control in enableDisable)
            {
                control.Enabled = false;
            }

            // Blokowanie groupBoxów
            foreach (GroupBox box in gBoxMEMSSensors)
            {
                box.Enabled = false;
            }

            progressBarData.Value = 0;

            buttonOpen.Enabled = true;
            cBoxPorts.Enabled = true;
        }


        // Włączenie okna ładowania aplikacji
        private void StartPaska()
        {
            Application.Run(loading);
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                // Ustawienie indeksów wybranych sensorów
                foreach(Sensor s in sensors)
                {
                    s.SetSensor();
                }


                // Wysłanie listy włączonych urządzeń
                byte[] parameters = new byte[8];
                parameters[0] = 0x77;
                parameters[1] = 0x01;
                parameters[2] = parameters[3] = parameters[4] = parameters[5] = parameters[6] = parameters[7] = 0x00;

                serialPort.Write(Communication.Query(0x08, parameters), 0, 13);

                // Wyswietlenie drugiej zakładki
                tabControlMain.SelectedIndex = 1;

                // Wstawianie nazwy sensora
                foreach(Sensor s in sensors)
                {
                    s.sensorName.Text = s.cBoxDeviceList.Items[s.cBoxDeviceList.SelectedIndex].ToString();
                }


                // Odblokowanie groupBoxów
                foreach (GroupBox box in gBoxMEMSSensors)
                {
                    box.Enabled = true;
                }

                // Odblokowywanie comboBoxów dostępnych sensorów
                foreach (ComboBox combo in clear)
                {
                    combo.Enabled = false;
                }

                buttonStart.Enabled = false;
                buttonStop.Enabled = true;
                EnableAllToolStripMenuItem.Enabled = true;
                DisableAllToolStripMenuItem.Enabled = true;

                progressBarData.Value = 100;
            }
            catch (Exception exc)
            {
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            // Wstrzymanie wysylania informacji przez płytkę
            serialPort.Write(Communication.Query(0x09, null), 0, 5);

            // Blokowanie groupBoxów
            foreach (GroupBox box in gBoxMEMSSensors)
            {
                box.Enabled = false;
            }

            // Odblokowywanie comboBoxów dostepnych sensorów
            foreach (ComboBox combo in clear)
            {
                combo.Enabled = true;
            }

            EnableAllToolStripMenuItem.Enabled = false;
            DisableAllToolStripMenuItem.Enabled = false;
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;

            progressBarData.Value = 0;
        }

        // Włączanie/wyłączaqnie czujników
        private void włączWszystkieCzujnikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parameters[0] = Sensor.enableByte = 0x77;
            parameters[1] = Sensor.enableInterruptByte;
            serialPort.Write(Communication.Query(0x08, parameters), 0, 13);
            foreach (CheckBox ch in checks)
            {
                ch.Checked = true;
            }
        }

        private void wyłączWszystkieCzujnikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parameters[0] = Sensor.enableByte = 0x00;
            parameters[1] = Sensor.enableInterruptByte;
            serialPort.Write(Communication.Query(0x08, parameters), 0, 13);
            foreach (CheckBox ch in checks)
            {
                ch.Checked = false;
            }
        }

        private void chBoxAkcWlaczony_CheckedChanged(object sender, EventArgs e)
        {
            acc.SetEnable(chBoxAccEnabled.Checked);
        }

        private void chBoxGyroEnabled_Click(object sender, EventArgs e)
        {
            gyr.SetEnable(chBoxGyroEnabled.Checked);
        }

        private void chBoxMagEnabled_Click(object sender, EventArgs e)
        {
            mag.SetEnable(chBoxMagEnabled.Checked);
        }


        private void chBoxHumEnabled_Click(object sender, EventArgs e)
        {
            hig.SetEnable(chBoxHumEnabled.Checked);
        }

        private void chBoxPreEnabled_Click(object sender, EventArgs e)
        {
            pre.SetEnable(chBoxPreEnabled.Checked);
        }

        private void chBoxTermEnabled_Click(object sender, EventArgs e)
        {
            ter.SetEnable(chBoxTermEnabled.Checked);
        }

        private void włączWyłączPrzerwaniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Sensor.enableInterruptByte == 0x00) parameters[1] = Sensor.enableInterruptByte = 0x01;
            else parameters[1] = Sensor.enableInterruptByte = 0x00;

            serialPort.Write(Communication.Query(0x08, parameters), 0, 13);
        }

        // Ustawianie ODR czujników 
        private void cBoxAkcODR_SelectedIndexChanged(object sender, EventArgs e)
        {
            acc.SetODR(cBoxAccODR.SelectedIndex);
        }

        private void cBoxZyroODR_SelectedIndexChanged(object sender, EventArgs e)
        {
            gyr.SetODR(cBoxGyroODR.SelectedIndex);
        }

        private void cBoxMagODR_SelectedIndexChanged(object sender, EventArgs e)
        {
            mag.SetODR(cBoxMagODR.SelectedIndex);
        }

        private void cBoxTermODR_SelectedIndexChanged(object sender, EventArgs e)
        {
            ter.SetODR(cBoxTermODR.SelectedIndex);
            hig.SetODR(cBoxHumODR.SelectedIndex);

            cBoxHumODR.SelectedIndex = cBoxTermODR.SelectedIndex;
        }

        private void cBoxHigODR_SelectedIndexChanged(object sender, EventArgs e)
        {
            ter.SetODR(cBoxTermODR.SelectedIndex); 
            hig.SetODR(cBoxHumODR.SelectedIndex);

            cBoxTermODR.SelectedIndex = cBoxHumODR.SelectedIndex;
        }

        private void cBoxBarODR_SelectedIndexChanged(object sender, EventArgs e)
        {
            pre.SetODR(cBoxPreODR.SelectedIndex);
        }

        // Ustawianie zakresów 
        private void cBoxAkcSkala_SelectedIndexChanged(object sender, EventArgs e)
        {
            acc.SetScale(cBoxAccScale.SelectedIndex);
        }

        private void cBoxZyroSkala_SelectedIndexChanged(object sender, EventArgs e)
        {
            gyr.SetScale(cBoxGyroScale.SelectedIndex);
        }

        private void cBoxMagScale_SelectedIndexChanged(object sender, EventArgs e)
        {
            mag.SetScale(cBoxMagScale.SelectedIndex);
        }
    }
}
