using Aplikacja_MEMS.Sensors;
using Aplikacja_MEMS.Transmition;
using Aplikacja_MEMS.Analysis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace Aplikacja_MEMS
{
    public partial class UserForm : Form
    {
        List<Control> enableDisable = new List<Control>();
        List<ComboBox> clear = new List<ComboBox>();
        List<GroupBox> gBoxMEMSSensors = new List<GroupBox>();
        static List<Sensor> sensors = new List<Sensor>();
        List<CheckBox> checks = new List<CheckBox>();

        MotionSensor acc;
        MotionSensor gyr;
        MotionSensor mag;
        EnvSensor ther;
        EnvSensor hum;
        EnvSensor pre;

        public static bool showText = true;

        static Queue<byte> addData;
        static Queue<byte[]> frames;
        static Queue<byte[]> checkedFrames;
        static Queue<byte[]> sensorsData;
        static Queue<string> toShow;
        static Data<byte[]> command;

        public UserForm()
        {
            InitializeComponent();

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

        private void CheckPorts()
        {
            // Pobieranie listyt dostępnych urządzeń MEMS
            List<AvailablePort> memsPorts = ComTransmition.CheckAvaliablePorts();
            int counter = 0;

            foreach (Control c in gBoxInfo.Controls)
            {
                if ((string)(c.Tag) == "port")
                {
                    gBoxInfo.Controls.Remove(c);
                }
            }
            cBoxPorts.Items.Clear();
            // Tworzenie listy etykiet z urządzeniami MEMS
            foreach (AvailablePort port in memsPorts)
            {
                // Dodawanie etykiety urządzenia MEMS
                labelCOM = new Label
                {
                    AutoSize = true,
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                    Location = new System.Drawing.Point(20, 89 + (counter * 15)),
                    Name = "label" + port,
                    Size = new System.Drawing.Size(146, 17),
                    Text = port.portNr + ": " + port.deviceName,
                    Tag = "port",
                    Visible = true
                };
                gBoxInfo.Controls.Add(this.labelCOM);

                // Dodawanie portu do listy dostępnych portów
                cBoxPorts.Items.Add(port.portNr);
            }

            if (cBoxPorts.Items.Count > 0)
                labelNoBoards.Visible = false; // Ukrycie informacji o braku urządzeń
            else
                labelNoBoards.Visible = true;
        }
        private System.Windows.Forms.Label labelCOM;

        private void UserForm_Load(object sender, EventArgs e)
        {
            CheckPorts();
            rtBoxHeader.AppendText("-----------------------------------------------------------------------------------------------------------------------------\n" +
                                  "Czas przesłania| Ciśń. | Temp.| Wilg.|    Akcelerometr    |         Żyroskop         |     Magnetometr    |Przerwania| Nowe \n" +
                                  "   [h:m:s.us]  | [hPa] | [°C] |  [%] | [mg] | [mg] | [mg] | [mdps] | [mdps] | [mdps] | [mG] | [mG] | [mG] |          | dane \n" +
                                  "-----------------------------------------------------------------------------------------------------------------------------\n");

            BringToFront();
        }

        // Wyświetlenie aplikacji na wierzchu, po załadowaniu
        private void UserForm_Shown(object sender, EventArgs e)
        {
            TopMost = false;
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

        public void MakeFrames()
        {
            Analysis.FrameAnalysis.Analysis(addData, frames);
        }

        public void CheckSum()
        {
            Analysis.FrameAnalysis.CheckSum(frames, checkedFrames);
        }


        public void AssignFrames()
        {
            Analysis.FrameAnalysis.AssignFrames(checkedFrames, command, sensorsData);
        }
        private void AddText()
        {
             FrameAnalysis.SensorData(sensorsData, sensors, rTBoxData, showText);
        }

        private void NewCommandToShow(object sender, EventArgs e)
        {
            byte[] data = ((Data<byte[]>)sender).Dequeue();
            foreach (Sensor s in sensors)
            {
                if (s.sensorNr == data[4])
                {
                    foreach (Control c in tabPageSensors.Controls)
                    {
                        if (c is GroupBox && (string)c.Tag == s.sensorName)
                        {
                            TextBox tBox = (TextBox)(c.Controls[4].Controls[2]);
                            tBox.Invoke((Action)delegate
                            {
                                tBox.Text = data[6].ToString("X2");
                            });
                        }
                    }
                }
            }
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

                if (ChceckDevices(cBoxPressure, (byte)SensId.PressureSensor))
                {
                    pre = new EnvSensor((byte)SensId.PressureSensor, (byte)SetSensor.PresEnable, "Barometr", 8, float.Parse(cBoxPreODR.Text));
                    sensors.Add(pre);
                    gBoxMEMSSensors.Add(gBoxPressure);
                }

                if (ChceckDevices(cBoxThermometer, (byte)SensId.Thermometer))
                {
                    ther = new EnvSensor((byte)SensId.Thermometer, (byte)SetSensor.TherEnable, "Termometr", 7, float.Parse(cBoxTherODR.Text));
                    sensors.Add(ther);
                    gBoxMEMSSensors.Add(gBoxThermometer);
                }

                if (ChceckDevices(cBoxHumidity, (byte)SensId.HumiditySensor))
                {
                    hum = new EnvSensor((byte)SensId.HumiditySensor, (byte)SetSensor.HumEnable, "Higrometr", 7, float.Parse(cBoxHumODR.Text));
                    sensors.Add(hum);
                    gBoxMEMSSensors.Add(gBoxHumidity);
                }

                if (ChceckDevices(cBoxAccelerometer, (byte)SensId.Accelerometer))
                {
                    acc = new MotionSensor((byte)SensId.Accelerometer, (byte)SetSensor.AccEnable, "Akcelerometr", 7, float.Parse(cBoxAccODR.Text));
                    sensors.Add(acc);
                    gBoxMEMSSensors.Add(gBoxAccelerometer);
                }

                if (ChceckDevices(cBoxGyroscope, (byte)SensId.Gyroscope))
                {
                    gyr = new MotionSensor((byte)SensId.Gyroscope, (byte)SetSensor.GyrEnable, "Żyroskop", 9, float.Parse(cBoxGyrODR.Text));
                    sensors.Add(gyr);
                    gBoxMEMSSensors.Add(gBoxGyroscope);
                }

                if (ChceckDevices(cBoxMagnetometer, (byte)SensId.Magnetometer))
                {
                    mag = new MotionSensor((byte)SensId.Magnetometer, (byte)SetSensor.MagEnable, "Magnetometr", 7, float.Parse(cBoxMagODR.Text));
                    sensors.Add(mag);
                    gBoxMEMSSensors.Add(gBoxMagnetometer);
                }

                addData = new Queue<byte>();
                frames = new Queue<byte[]>();
                checkedFrames = new Queue<byte[]>();
                sensorsData = new Queue<byte[]>();
                toShow = new Queue<string>();

                Analysis.FrameAnalysis.Enable();
                ComTransmition.Read(addData);

                ThreadStart makeFramesStart = new ThreadStart(MakeFrames);
                Thread makeFrames = new Thread(makeFramesStart);
                makeFrames.Priority = ThreadPriority.Highest;
                makeFrames.Start();

                ThreadStart checkSumStart = new ThreadStart(CheckSum);
                Thread checkSum = new Thread(checkSumStart);
                checkSum.Priority = ThreadPriority.Highest;
                checkSum.Start();

                ThreadStart assignFrameStart = new ThreadStart(AssignFrames);
                Thread assignFrame = new Thread(assignFrameStart);
                assignFrame.Priority = ThreadPriority.Highest;
                assignFrame.Start();

                ThreadStart addTextStart = new ThreadStart(AddText);
                Thread addText = new Thread(addTextStart);
                addText.Start();

                foreach (Sensor s in sensors)
                    s.OpenPlot();

                command = new Data<byte[]>();
                command.Changed += new EventHandler(this.NewCommandToShow);

                // Włączanie/wyłączanie przycisków
                foreach (Control control in enableDisable)
                {
                    control.Enabled = true;
                }


                buttonOpen.Enabled = false;
                buttonStop.Enabled = false;
                cBoxPorts.Enabled = false;
                btnRefresh.Enabled = false;
                portOpenToolStripMenuItem.Enabled = false;

                progressBarCOM.Value = 100;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Wystąpił błąd podczas połączenia z portem szeregowym. Sprawdź parameters połączenia. \n" + exc.Message, "Błąd");
                Communication.Query((byte)CmdType.StopTransmition);
                ComTransmition.StopRead();
                ComTransmition.ClosePort();
                FrameAnalysis.Disable();

                progressBarCOM.Value = 0;

                // Włączanie/wyłączanie przycisków
                foreach (Control control in enableDisable)
                    control.Enabled = false;

                buttonOpen.Enabled = true;
                cBoxPorts.Enabled = true;
            }
        }

        private void buttonZamknij_Click(object sender, EventArgs e)
        {
            ComTransmition.StopRead();
            Communication.Query((byte)CmdType.StopTransmition);
            ComTransmition.ClosePort();
            FrameAnalysis.Disable();

            foreach (Sensor s in sensors)
            {
                s.ClosePlot();
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

            sensors.Clear();

            progressBarCOM.Value = 0;
            progressBarData.Value = 0;


            buttonOpen.Enabled = true;
            buttonStop.Enabled = true;
            cBoxPorts.Enabled = true;
            btnRefresh.Enabled = true;
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


                // Ustawienie wszystkich sensorów jako wyłączone
                Sensor.DisableAll();


                foreach (CheckBox cBox in checks)
                {
                    cBox.Checked = false;
                }


                foreach (Sensor s in sensors)
                {
                    s.isEnabled = false;
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

                foreach (Control c in tabPageSensors.Controls)
                    if (c is GroupBox gBox)
                        foreach (Control gBoxC in gBox.Controls)
                        {
                            if (gBoxC is ComboBox cBox && cBox.Name.Contains("ODR"))
                                SetOdr(cBox, null);

                            if (gBoxC is ComboBox cBoxScale && cBoxScale.Name.Contains("Scale"))
                                SetScale(cBoxScale, null);
                        }

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
            Sensor.DisableAll();

            // Odznaczanie checkboxów
            foreach (CheckBox cBox in checks)
            {
                cBox.Checked = false;
            }

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

        // Włączanie/wyłączanie czujników
        private void ChangeEnable(object sender, EventArgs e)
        {
            foreach (Sensor s in sensors)
            {
                if (s.sensorName == (string)((CheckBox)sender).Tag)
                {
                    s.SetEnable(((CheckBox)sender).Checked);
                    foreach (Control c in tabPageSensors.Controls)
                        if (c is GroupBox)
                        {
                            foreach (Control g in c.Controls)
                                if (g is ComboBox && g.Enabled && (string)g.Tag == s.sensorName && g.Name.Contains("ODR"))
                                {
                                    bool wasShown = showText;
                                    showText = s.SumOdr(float.Parse(g.Text));

                                    if (wasShown && !showText)
                                        rTBoxData.AppendText("Ustawiono zbyt duży ODR, aby wyświetlić parametry!\n");
                                }
                        }

                }

            }
        }

        private void włączWyłączPrzerwaniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sensor.ChangeInterrupt();
        }

        // Ustawianie ODR czujników 

        private void SetOdr(object sender, EventArgs e)
        {
            foreach (Sensor s in sensors)
            {
                if (s.sensorName == (string)((ComboBox)sender).Tag)
                {
                    s.SetOdr(BitConverter.GetBytes(float.Parse(((ComboBox)sender).Text)));
                    s.SumOdr(float.Parse(((ComboBox)sender).Text));
                }
            }
        }

        // Ustawianie zakresów 
        private void SetScale(object sender, EventArgs e)
        {
            foreach (Sensor s in sensors)
            {
                if (s is MotionSensor ms && s.sensorName == (string)((ComboBox)sender).Tag)
                    ms.SetScale(BitConverter.GetBytes(Int32.Parse(((ComboBox)sender).Text)));
            }
        }

        // Ustawianie parametrów rejestru
        private void SetRegParam(object sender, EventArgs e)
        {
            foreach (Sensor s in sensors)
            {
                if (s.sensorName == (string)((Button)sender).Tag)
                {
                    foreach (Control c in tabPageSensors.Controls)
                    {
                        if (c is GroupBox && c.Tag == ((Button)sender).Tag)
                        {
                            s.SetRegisterParameter(c.Controls[4].Controls[3].Text, c.Controls[4].Controls[2].Text);
                        }
                    }
                }
            }
        }

        // Pobieranie ustawień rejestrów    
        private void GetRegParam(object sender, EventArgs e)
        {
            foreach (Sensor s in sensors)
            {
                if (s.sensorName == (string)((Button)sender).Tag)
                {
                    foreach (Control c in tabPageSensors.Controls)
                    {
                        if (c is GroupBox && c.Tag == ((Button)sender).Tag)
                        {
                            s.GetRegisterParameter(c.Controls[4].Controls[3].Text);
                        }
                    }
                }
            }
        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            buttonZamknij_Click(this, null);
        }

        private void portOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonOtworz_Click(this, null);
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rTBoxData.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CheckPorts();
        }

        private void ShowPlot(object sender, EventArgs e)
        {
            foreach (Sensor s in sensors)
            {
                if ((string)((Button)sender).Tag == s.sensorName)
                    s.OpenPlot();
            }
        }
    }
}
