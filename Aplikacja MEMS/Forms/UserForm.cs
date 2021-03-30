using Aplikacja_MEMS.Sensors;
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

        MotionSensor acc;
        MotionSensor gyr;
        MotionSensor mag;
        EnvSensor ther;
        EnvSensor hum;
        EnvSensor pre;

        public UserForm()
        {
            InitializeComponent();

            Sensor.enableByte = 0x77;
            Sensor.enableInterruptByte = 0x01;

            // Ustawienie rozmiaru groupBoxów
            gBoxInfo.Height = tabPageGeneral.Height / 3;
            gBoxConnection.Height = tabPageGeneral.Height / 3;
            gBoxSensors.Height = tabPageGeneral.Height / 3;

            // Tworzenie listy kontrolek aktywowanych/dezaktywowanych podczas otwierania portu
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

            // Parametry poczatkowe w listach wybieranych zakładki "Czujniki MEMS"
            cBoxAccODR.Text = cBoxAccODR.Items[0].ToString();
            cBoxPreODR.Text = cBoxPreODR.Items[0].ToString();
            cBoxMagODR.Text = cBoxMagODR.Items[0].ToString();
            cBoxGyrODR.Text = cBoxGyrODR.Items[0].ToString();
            cBoxTherODR.Text = cBoxTherODR.Items[0].ToString();
            cBoxHumODR.Text = cBoxHumODR.Items[0].ToString();

            cBoxAccScale.Text = cBoxAccScale.Items[0].ToString();
            cBoxMagScale.Text = cBoxMagScale.Items[0].ToString();
            cBoxGyrScale.Text = cBoxGyrScale.Items[0].ToString();

            // Ustalenie listy checkBoxów
            checks.Add(chBoxAccEnabled);
            checks.Add(chBoxGyrEnabled);
            checks.Add(chBoxMagEnabled);
            checks.Add(chBoxTherEnabled);
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
                Communication.Query((byte)CmdType.DataSet, cBoxPorts.Text);
                
                if(ChceckDevices(cBoxAccelerometer, (byte)SensId.Accelerometer))
                {
                    acc = new MotionSensor((byte)SensId.Accelerometer, (byte)SensId.AccEnable);
                    sensors.Add(acc);
                    gBoxMEMSSensors.Add(gBoxAccelerometer);
                }
                if (ChceckDevices(cBoxGyroscope, (byte)SensId.Gyroscope))
                {
                    gyr = new MotionSensor((byte)SensId.Gyroscope, (byte)SensId.GyrEnable);
                    sensors.Add(gyr);
                    gBoxMEMSSensors.Add(gBoxGyroscope);
                }
                if (ChceckDevices(cBoxMagnetometer, (byte)SensId.Magnetometer))
                {
                    mag = new MotionSensor((byte)SensId.Magnetometer, (byte)SensId.MagEnable);
                    sensors.Add(mag);
                    gBoxMEMSSensors.Add(gBoxMagnetometer);
                }
                if (ChceckDevices(cBoxThermometer, (byte)SensId.Thermometer))
                {
                    ther = new EnvSensor((byte)SensId.Thermometer, (byte)SensId.TherEnable);
                    sensors.Add(ther);
                    gBoxMEMSSensors.Add(gBoxThermometer);
                }
                if (ChceckDevices(cBoxHumidity, (byte)SensId.HumiditySensor))
                {
                    hum = new EnvSensor((byte)SensId.HumiditySensor, (byte)SensId.HumEnable);
                    sensors.Add(hum);
                    gBoxMEMSSensors.Add(gBoxHumidity);
                }
                if (ChceckDevices(cBoxPressure, (byte)SensId.PressureSensor))
                {
                    pre = new EnvSensor((byte)SensId.PressureSensor, (byte)SensId.PresEnable);
                    sensors.Add(pre);
                    gBoxMEMSSensors.Add(gBoxPressure);
                }

                buttonOpen.Enabled = false;
                cBoxPorts.Enabled = false;
                portOpenToolStripMenuItem.Enabled = false;

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
                ComTransmition.ClosePort();

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

        private bool ChceckDevices(ComboBox deviceList, byte sensor)
        {
            List<string> sensorDevices;
            sensorDevices = Communication.GetAvailableSensors(sensor);
            progressBarCOM.Value += 100 / 6;
            if (sensorDevices != null)
            {
                foreach (string s in sensorDevices)
                {
                    deviceList.Items.Add(s);
                }
                deviceList.SelectedIndex = 0;
                enableDisable.Add(deviceList);

                return true;
            }

            else return false;
        }


        private void buttonZamknij_Click(object sender, EventArgs e)
        {
            Communication.Query((byte)CmdType.StopTransmition);
            ComTransmition.StopRead();
            ComTransmition.ClosePort();

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

            sensors.Clear();

            progressBarCOM.Value = 0;
            progressBarData.Value = 0;
            buttonOpen.Enabled = true;
            cBoxPorts.Enabled = true;
            portOpenToolStripMenuItem.Enabled = true;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                // Ustawienie indeksów wybranych sensorów
                foreach (Sensor s in sensors)
                {
                    Communication.Query((byte)CmdType.SensorCmd, (byte)SubCmdType.SetWorkingSensor, s.sensorNr, (byte)s.selectedDeviceIndex);
                    progressBarData.Value += 10;
                }
                
                ComTransmition.Read();
                Sensor.EnableAll();

                foreach(Sensor s in sensors)
                {
                    s.isEnabled = true;
                }

                // Wyswietlenie drugiej zakładki
                tabControlMain.SelectedIndex = 1;

                // Wstawianie nazwy sensora
                accNameLab.Text = cBoxAccelerometer.Text;
                terNameLab.Text = cBoxThermometer.Text;
                magNameLab.Text = cBoxAccelerometer.Text;
                gyrNameLab.Text = cBoxGyroscope.Text;
                humNameLab.Text = cBoxHumidity.Text;
                presNameLab.Text = cBoxPressure.Text;


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
                buttonStop_Click(this, null);
                MessageBox.Show("Wystąpił błąd podczas próby wymiany danych z płytką. Sprawdź parametry i spróbuj ponownie. \n\nBłąd:\n" + exc.Message,
                    "Błąd!");
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            // Wstrzymanie wysylania informacji przez płytkę
            Communication.Query((byte)CmdType.StopTransmition);
            ComTransmition.StopRead();

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
            Sensor.EnableAll();
            foreach (CheckBox ch in checks)
            {
                ch.Checked = true;
            }
        }

        private void wyłączWszystkieCzujnikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sensor.DisableAll();
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
            gyr.SetEnable(chBoxGyrEnabled.Checked);
        }

        private void chBoxMagEnabled_Click(object sender, EventArgs e)
        {
            mag.SetEnable(chBoxMagEnabled.Checked);
        }


        private void chBoxHumEnabled_Click(object sender, EventArgs e)
        {
            hum.SetEnable(chBoxHumEnabled.Checked);
        }

        private void chBoxPreEnabled_Click(object sender, EventArgs e)
        {
            pre.SetEnable(chBoxPreEnabled.Checked);
        }

        private void chBoxTermEnabled_Click(object sender, EventArgs e)
        {
            ther.SetEnable(chBoxTherEnabled.Checked);
        }

        private void włączWyłączPrzerwaniaToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            Sensor.ChangeInterrupt();
        }

        // Ustawianie ODR czujników 
        private void cBoxAkcODR_SelectedIndexChanged(object sender, EventArgs e)
        {
            byte[] parameter = BitConverter.GetBytes(float.Parse(cBoxAccODR.Text));
            if(acc != null)
            acc.SetOdr(parameter);
        }

        private void cBoxGyrODR_SelectedIndexChanged(object sender, EventArgs e)
        {
            byte[] parameter = BitConverter.GetBytes(float.Parse(cBoxGyrODR.Text));
            if (gyr != null)
                gyr.SetOdr(parameter);

        }

        private void cBoxMagODR_SelectedIndexChanged(object sender, EventArgs e)
        {
            byte[] parameter = BitConverter.GetBytes(float.Parse(cBoxMagODR.Text));
            if (mag != null)
                mag.SetOdr(parameter);
        }

        private void cBoxTermODR_SelectedIndexChanged(object sender, EventArgs e)
        {
            byte[] parameter = BitConverter.GetBytes(float.Parse(cBoxTherODR.Text));
            if (ther != null)
            {
                ther.SetOdr(parameter);
                cBoxHumODR.SelectedIndex = cBoxTherODR.SelectedIndex;
            }
        }

        private void cBoxHigODR_SelectedIndexChanged(object sender, EventArgs e)
        {
            byte[] parameter = BitConverter.GetBytes(float.Parse(cBoxHumODR.Text));
            if (hum != null)
            {
                hum.SetOdr(parameter);
                cBoxTherODR.SelectedIndex = cBoxHumODR.SelectedIndex;
            }
        }

        private void cBoxBarODR_SelectedIndexChanged(object sender, EventArgs e)
        {
            byte[] parameter = BitConverter.GetBytes(float.Parse(cBoxPreODR.Text));
            if (pre != null)
                pre.SetOdr(parameter);
        }

        // Ustawianie zakresów 
        private void cBoxAkcSkala_SelectedIndexChanged(object sender, EventArgs e)
        {
            byte[] parameter = BitConverter.GetBytes(Int32.Parse(cBoxAccScale.Text));
            if (acc != null)
                acc.SetScale(parameter);
        }

        private void cBoxGyrSkala_SelectedIndexChanged(object sender, EventArgs e)
        {
            byte[] parameter = BitConverter.GetBytes(Int32.Parse(cBoxGyrScale.Text));
            if (gyr != null)
                gyr.SetScale(parameter);
        }

        // Ustawianie parametrów rejestru
        private void buttonAccSet_Click(object sender, EventArgs e)
        {
            acc.SetRegisterParameter(tBoxAccAddress.Text, tBoxAccValue.Text);
        }

        private void buttonGyrSet_Click(object sender, EventArgs e)
        {
            gyr.SetRegisterParameter(tBoxGyrAddress.Text, tBoxGyrValue.Text);
        }

        private void buttonMagSet_Click(object sender, EventArgs e)
        {
            mag.SetRegisterParameter(tBoxMagAddress.Text, tBoxMagValue.Text);
        }

        private void buttonTermSet_Click(object sender, EventArgs e)
        {
            ther.SetRegisterParameter(tBoxTherAddress.Text, tBoxTherValue.Text);
        }

        private void buttonPreSet_Click(object sender, EventArgs e)
        {
            pre.SetRegisterParameter(tBoxPreAddress.Text, tBoxPreValue.Text);
        }

        private void buttonHumSet_Click(object sender, EventArgs e)
        {
            hum.SetRegisterParameter(tBoxHumAddress.Text, tBoxHumValue.Text);
        }

        // Pobieranie ustawień rejestrów    
        private void buttonAccGet_Click(object sender, EventArgs e)
        {
            acc.GetRegisterParameter(tBoxAccAddress.Text);
        }

        private void buttonGyrGet_Click(object sender, EventArgs e)
        {
            gyr.GetRegisterParameter(tBoxGyrAddress.Text);
        }

        private void buttonMagGet_Click(object sender, EventArgs e)
        {
            mag.GetRegisterParameter(tBoxMagAddress.Text);
        }

        private void buttonTermGet_Click(object sender, EventArgs e)
        {
            ther.GetRegisterParameter(tBoxTherAddress.Text);
        }

        private void buttonPreGet_Click(object sender, EventArgs e)
        {
            pre.GetRegisterParameter(tBoxPreAddress.Text);
        }

        private void buttonHumGet_Click(object sender, EventArgs e)
        {
            hum.GetRegisterParameter(tBoxHumAddress.Text);
        }

        // Otwarcie okien rejestrtów
        private void buttonAccOpen_Click(object sender, EventArgs e)
        {
            acc.OpenRegister();
        }

        private void buttonGyroOpen_Click(object sender, EventArgs e)
        {

          
        }

        private void buttonMagOpen_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonTermOpen_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonPreOpen_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonHumOpen_Click(object sender, EventArgs e)
        {
           
        }
        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
                Communication.Query((byte)CmdType.StopTransmition);
                ComTransmition.ClosePort();
        }

        private void portOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonOtworz_Click(this, null);
        }
    }
}
