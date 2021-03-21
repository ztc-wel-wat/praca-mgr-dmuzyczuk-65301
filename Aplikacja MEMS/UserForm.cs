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
        List<Sensors> sensors = new List<Sensors>();
        List<CheckBox> checks = new List<CheckBox>();

        string[] comPorts;

        public static byte sensor = 0x77;
        Loading loading = new Loading();
        ThreadStart loadingBar;
        Thread bar;

        Accelerometer acc;
        Gyroscope gyr;
        Magnetometer mag;

        BackgroundWorker bgWorkWrite;

        byte[] parameters;

        int response = 0;
        byte[] resp = new byte[4096];

        public UserForm()
        {
            InitializeComponent();

            acc = new Accelerometer(serialPort, cBoxAccelerometer, 0x10, accNameLab);
            gyr = new Gyroscope(serialPort, cBoxGyroscope, 0x20, gyroNameLab);
            mag = new Magnetometer(serialPort, cBoxMagnetometer, 0x40, magNameLab);

            // Tworzenie listy sensorów
            sensors.Add(acc);
            sensors.Add(gyr);
            sensors.Add(mag);

            parameters = new byte[8];
            parameters[0] = 0x77;
            parameters[1] = 0x01;
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
                    awaiting.Wait(2000);

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

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Ładowanie progressBar podczas włączania aplikacji
            if (loading.progressBar.Value < 90)
            {
                if (comPorts.Length != 0)
                {
                    Action<int> updateAction = new Action<int>((value) => loading.progressBar.Value += 90 / comPorts.Length);
                    loading.progressBar.Invoke(updateAction, 32);
                }
            }
            else
            {
                Action<int> updateAction = new Action<int>((value) => loading.progressBar.Value = 100);
                loading.progressBar.Invoke(updateAction, 32);
            }
        }

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

                acc.GetSensorsList();
                mag.GetSensorsList();
                gyr.GetSensorsList();

                progressBarCOM.Value = 90;

                // Włączanie/wyłączanie przycisków
                foreach (Control control in enableDisable)
                {
                    control.Enabled = true;
                }

                buttonOpen.Enabled = false;
                buttonStop.Enabled = false;
                cBoxPorts.Enabled = false;

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
                // Wysłanie listy włączonych urządzeń
                byte[] parameters = new byte[8];
                parameters[0] = 0x77;
                parameters[1] = 0x01;
                parameters[2] = parameters[3] = parameters[4] = parameters[5] = parameters[6] = parameters[7] = 0x00;

                serialPort.Write(Communication.Query(0x08, parameters), 0, 13);

                // Rozpoczęcie pobierania danych
                Communication.Odbior(serialPort);

                // Wyswietlenie drugiej zakładki
                tabControlMain.SelectedIndex = 1;

                // Wstawianie nazwy sensora
                foreach(Sensors s in sensors)
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
            Communication.bgWorkReceive.CancelAsync();

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

        //private void chBoxZyroWlaczony_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chBoxGyroEnabled.Checked == true)
        //    {
        //        parameters[0] += 0x20;
        //    }
        //    else
        //    {
        //        parameters[0] -= 0x20;
        //    }

        //    serialPort.Write(Communication.Query(0x08, sensor, 0x00, 0x00, parameters), serialPort);

        //    gyroscope.enabled = chBoxGyroEnabled.Checked;
        //}

        //private void chBoxMagWlaczony_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chBoxMagEnabled.Checked == true)
        //    {
        //        sensor += 0x40;
        //    }
        //    else
        //    {
        //        sensor -= 0x40;
        //    }
        //    Sensor.SendMessage(Communication.Query(0x08, sensor, 0x00, 0x00, parameters), serialPort);

        //    magnetometer.enabled = chBoxMagEnabled.Checked;
        //}

        //private void chBoxTermWlaczony_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chBoxTermEnabled.Checked == true)
        //    {
        //        sensor += 0x02;
        //    }
        //    else
        //    {
        //        sensor -= 0x02;
        //    }
        //    Sensor.SendMessage(Communication.Query(0x08, sensor, 0x00, 0x00, parameters), serialPort);

        //    thermometer.enabled = chBoxTermEnabled.Checked;
        //}

        //private void chBoxBarWlaczony_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chBoxPreEnabled.Checked == true)
        //    {
        //        sensor += 0x01;
        //    }
        //    else
        //    {
        //        sensor -= 0x01;
        //    }
        //    Sensor.SendMessage(Communication.Query(0x08, sensor, 0x00, 0x00, parameters), serialPort);

        //    pressure.enabled = chBoxPreEnabled.Checked;
        //}

        //private void chBoxHigWlaczony_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chBoxHumEnabled.Checked == true)
        //    {
        //        sensor += 0x04;
        //    }
        //    else
        //    {
        //        sensor -= 0x04;
        //    }
        //    Sensor.SendMessage(Communication.Query(0x08, sensor, 0x00, 0x00, parameters), serialPort);

        //    humidity.enabled = chBoxHumEnabled.Checked;
        //}

        private void chBoxAkcWlaczony_CheckedChanged(object sender, EventArgs e)
        {
            acc.SetEnable(chBoxAccEnabled.Checked);
        }

        public void WyswietlDane(string doWyswietlenia)
        {
            bgWorkWrite = new BackgroundWorker();
            bgWorkWrite.DoWork += new System.ComponentModel.DoWorkEventHandler(bgWorkWrite_DoWork);
            bgWorkWrite.RunWorkerAsync(argument: doWyswietlenia);
        }
        private void bgWorkWrite_DoWork(object sender, DoWorkEventArgs e)
        {
            Action<int> updateAction = new Action<int>((value) => rTBoxData.Text += "Odebrano dane \n");
            rTBoxData.Invoke(updateAction, 32);
        }

        // Ustawianie ODR accelerometeru w comboBoxie
        private void cBoxAkcODR_SelectedIndexChanged(object sender, EventArgs e)
        {
            acc.SetODR(cBoxAccODR.SelectedIndex);
        }

        private void włączWszystkieCzujnikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parameters[0] = 0x77;
            parameters[1] = 0x01;
            sensor = 0x77;
            serialPort.Write(Communication.Query(0x08, parameters), 0, 13);
            foreach (CheckBox ch in checks)
            {
                ch.Checked = true;
            }
        }

        private void wyłączWszystkieCzujnikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parameters[0] = sensor = 0x00; 
            parameters[1] = 0x00;
            serialPort.Write(Communication.Query(0x08, parameters), 0, 13); 
            foreach (CheckBox ch in checks)
            {
                ch.Checked = false;
            }
        }

        // Ustawianie ODR żyroskopu w comboBoxie
        private void cBoxZyroODR_SelectedIndexChanged(object sender, EventArgs e)
        {
            gyr.SetODR(cBoxGyroODR.SelectedIndex);
        }

        // Ustawianie ODR magnetometeru w comboBoxie
        private void cBoxMagODR_SelectedIndexChanged(object sender, EventArgs e)
        {
            mag.SetODR(cBoxMagODR.SelectedIndex);
        }

        private void cBoxTermODR_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cBoxHigODR_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        // Ustawianie ODR pressureu w comboBoxie
        private void cBoxBarODR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                switch (cBoxPreODR.SelectedIndex)
                {
                    case 0:
                        parameters[0] = 0x00;
                        parameters[1] = 0x00;
                        parameters[2] = 0x80;
                        parameters[3] = 0x3F;
                        break;

                    case 1:
                        parameters[0] = 0x00;
                        parameters[1] = 0x00;
                        parameters[2] = 0x20;
                        parameters[3] = 0x41;
                        break;

                    case 2:
                        parameters[0] = 0x00;
                        parameters[1] = 0x00;
                        parameters[2] = 0xC8;
                        parameters[3] = 0x41;
                        break;

                    case 3:
                        parameters[0] = 0x00;
                        parameters[1] = 0x00;
                        parameters[2] = 0x48;
                        parameters[3] = 0x42;
                        break;

                    case 4:
                        parameters[0] = 0x00;
                        parameters[1] = 0x00;
                        parameters[2] = 0x96;
                        parameters[3] = 0x42;
                        break;
                }
            //    serialPort.Write(Communication.Query(0x50, 0x06, 0x07, 0x00, parameters), 0, 11);
            }
        }

        // Ustawianie zakresu Akcelerometru w comboBoxie
        private void cBoxAkcSkala_SelectedIndexChanged(object sender, EventArgs e)
        {
            acc.SetScale(cBoxAccScale.SelectedIndex);
        }

        // Ustawianie skali żyroskopu w comboBoxie
        private void cBoxZyroSkala_SelectedIndexChanged(object sender, EventArgs e)
        {
            gyr.SetScale(cBoxGyroScale.SelectedIndex);
        }

        private void chBoxGyroEnabled_Click(object sender, EventArgs e)
        {
            gyr.SetEnable(chBoxGyroEnabled.Checked);
        }

        private void chBoxMagEnabled_Click(object sender, EventArgs e)
        {
            mag.SetEnable(chBoxMagEnabled.Checked);
        }

        private void włączWyłączPrzerwaniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (parameters[1] == 0x00) parameters[1] = 0x01;
            else parameters[1] = 0x00;

            serialPort.Write(Communication.Query(0x08, parameters), 0, 13);

        }
    }
}
