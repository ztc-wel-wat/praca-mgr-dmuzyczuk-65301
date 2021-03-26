using Aplikacja_MEMS.Transmition;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
        public static bool semafor = false;


        Loading loading = new Loading();
        ThreadStart loadingBar;
        Thread bar;

        Accelerometer acc;
        Gyroscope gyr;
        Magnetometer mag;
        Termometer ter;
        Humidity hig;
        Pressure pre;

        byte[] parameters;
        int response = 0;
        byte[] resp = new byte[4096];

        public UserForm()
        {
            InitializeComponent();
            Sensor.enableByte = 0x77;
            Sensor.enableInterruptByte = 0x01;

            acc = new Accelerometer(serialPort, cBoxAccelerometer, accNameLab);
            gyr = new Gyroscope(serialPort, cBoxGyroscope, gyroNameLab);
            mag = new Magnetometer(serialPort, cBoxMagnetometer, magNameLab);
            ter = new Termometer(serialPort, cBoxThermometer, terNameLab);
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
            List<AvailablePort> memsPorts = new List<AvailablePort>();

            // Pobieranie listyt dostępnych urządzeń MEMS
            memsPorts = ComTransmition.CheckAvaliablePorts();
            int counter = 0;

            // Tworzenie listy etykiet z urządzeniami MEMS
            foreach (AvailablePort port in memsPorts)
            {
                try
                {
                    labelNoBoards.Visible = false; // Ukrycie informacji o braku urządzeń

                    // Dodawanie etykiety urządzenia MEMS
                    labelCOM = new Label();
                    labelCOM.AutoSize = true;
                    labelCOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                    labelCOM.Location = new System.Drawing.Point(20, 85 + (counter * 15));
                    labelCOM.Name = "label" + port;
                    labelCOM.Size = new System.Drawing.Size(146, 17);
                    labelCOM.Text = port.portNr + ": " + port.deviceName;
                    labelCOM.Visible = true;
                    gBoxInfo.Controls.Add(this.labelCOM);

                    // Dodawanie portu do listy dostępnych portów
                    cBoxPorts.Items.Add(port.portNr);
                }
                catch (Exception exc)
                {
                }
            }
        }
        private System.Windows.Forms.Label labelCOM;

        // Wyświetlenie aplikacji na wierzchu, po załadowaniu
        private void UserForm_Shown(object sender, EventArgs e)
        {
            this.TopMost = false;
        }

        private void buttonOtworz_Click(object sender, EventArgs e)
        {
            try
            {

                // Czyszczenie listy poprzednich urzadzen
                foreach (ComboBox cBox in clear)
                {
                    cBox.Items.Clear();
                }

                // Wysłanie ustawień początkowych aplikacji
                ComTransmition.OpenPort(cBoxPorts.Text);
                Communication.Query((byte)CmdType.DataSet);

                buttonOpen.Enabled = false;
                cBoxPorts.Enabled = false;

                //foreach (Sensor s in sensors)
                //{
                //    s.GetSensorsList();
                //    progressBarCOM.Value += 15;
                //}

                // Włączanie/wyłączanie przycisków
                foreach (Control control in enableDisable)
                {
                    control.Enabled = true;
                }

                buttonOpen.Enabled = false;
                buttonStop.Enabled = false;
                cBoxPorts.Enabled = false;

                // Rozpoczęcie pobierania danych
                ComTransmition.Read();

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
            semafor = true;
            serialPort.Write(Communication.Query(0x09, null), 0, 5);


            // Wstrzymanie wstrzymania informacji przez płytkę
            serialPort.Write(Communication.Query(0x09, null), 0, 5);


            if (serialPort.IsOpen)
            {
                serialPort.DiscardInBuffer();
                serialPort.DiscardOutBuffer();
                serialPort.Close();
            }

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

            progressBarCOM.Value = 0;
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
                foreach (Sensor s in sensors)
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
                foreach (Sensor s in sensors)
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

            if (serialPort.IsOpen)
            {
                try
                {
                    float a = float.Parse(cBoxAccODR.Text);
                    byte[] par = BitConverter.GetBytes(a);
                    MessageBox.Show(par[0].ToString() + par[1].ToString() + par[2].ToString() + par[3].ToString());
                }
                catch (Exception exc) { }
            }
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

        // Ustawianie parametrów rejestru
        private void buttonAccSet_Click(object sender, EventArgs e)
        {
            acc.SetParameter(tBoxAccAddress.Text, tBoxAccValue.Text);
        }

        private void buttonGyroSet_Click(object sender, EventArgs e)
        {
            gyr.SetParameter(tBoxGyroAddress.Text, tBoxGyroValue.Text);
        }

        private void buttonMagSet_Click(object sender, EventArgs e)
        {
            mag.SetParameter(tBoxMagAddress.Text, tBoxMagValue.Text);
        }

        private void buttonTermSet_Click(object sender, EventArgs e)
        {
            ter.SetParameter(tBoxTermAddress.Text, tBoxTermValue.Text);
        }

        private void buttonPreSet_Click(object sender, EventArgs e)
        {
            pre.SetParameter(tBoxPreAddress.Text, tBoxPreValue.Text);
        }

        private void buttonHumSet_Click(object sender, EventArgs e)
        {
            hig.SetParameter(tBoxHumAddress.Text, tBoxHumValue.Text);
        }

        // Pobieranie ustawień rejestrów    
        private void buttonAccGet_Click(object sender, EventArgs e)
        {
            acc.ReadParameter(tBoxAccAddress.Text);
        }

        private void buttonGyroGet_Click(object sender, EventArgs e)
        {
            gyr.ReadParameter(tBoxGyroAddress.Text);
        }

        private void buttonMagGet_Click(object sender, EventArgs e)
        {
            mag.ReadParameter(tBoxMagAddress.Text);
        }

        private void buttonTermGet_Click(object sender, EventArgs e)
        {
            ter.ReadParameter(tBoxTermAddress.Text);
        }

        private void buttonPreGet_Click(object sender, EventArgs e)
        {
            pre.ReadParameter(tBoxPreAddress.Text);
        }

        private void buttonHumGet_Click(object sender, EventArgs e)
        {
            hig.ReadParameter(tBoxHumAddress.Text);
        }

        // Otwarcie okien rejestrtów
        private void buttonAccOpen_Click(object sender, EventArgs e)
        {
            acc.OpenRegister("Akcelerometr");
        }

        private void buttonGyroOpen_Click(object sender, EventArgs e)
        {

            gyr.OpenRegister("Żyroskop");
        }

        private void buttonMagOpen_Click(object sender, EventArgs e)
        {
            mag.OpenRegister("Magnetometr");
        }

        private void buttonTermOpen_Click(object sender, EventArgs e)
        {
            ter.OpenRegister("Termometr");
        }

        private void buttonPreOpen_Click(object sender, EventArgs e)
        {
            pre.OpenRegister("Barometr");
        }

        private void buttonHumOpen_Click(object sender, EventArgs e)
        {
            hig.OpenRegister("Hogrometr");
        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                // Wstrzymanie wstrzymania informacji przez płytkę
                serialPort.Write(Communication.Query(0x09, null), 0, 5);
                serialPort.DiscardInBuffer();
                serialPort.DiscardOutBuffer();
                serialPort.Close();
            }
        }
    }
}
