using Aplikacja_MEMS.Sensors;
using Aplikacja_MEMS.Transmition;
using Aplikacja_MEMS.Analysis;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Aplikacja_MEMS.Forms;

namespace Aplikacja_MEMS
{
    public partial class UserForm : Form
    {
        static List<Control> enableDisable = new List<Control>();
        static List<ToolStripMenuItem> startTransmisionEnableDisable = new List<ToolStripMenuItem>();
        static List<ComboBox> clear = new List<ComboBox>();
        static List<GroupBox> gBoxMEMSSensors = new List<GroupBox>();
        static List<Sensor> sensors = new List<Sensor>();
        static List<Label> sensorNames = new List<Label>();
        List<CheckBox> checks = new List<CheckBox>();
        static List<Button> parameters = new List<Button>();
        static List<SensorRegister> registers = new List<SensorRegister>();

        static bool enabledRegister = false;

        MotionSensor acc;
        MotionSensor gyr;
        MotionSensor mag;
        EnvSensor ther;
        EnvSensor hum;
        EnvSensor pre;

        public static bool showText = true;

        static Command<byte[]> command;

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

            // Lista obiektów MenuStrip do włączania/Wyłączania
            startTransmisionEnableDisable.Add(EnableAllToolStripMenuItem);
            startTransmisionEnableDisable.Add(DisableAllToolStripMenuItem);
            startTransmisionEnableDisable.Add(otwórzPomiaryZPlikuToolStripMenuItem);
            startTransmisionEnableDisable.Add(włączWyłączPrzerwaniaToolStripMenuItem);

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

            // Przyciski obsługi rejestrów
            parameters.Add(buttonAccGet);
            parameters.Add(buttonAccSet);
            parameters.Add(buttonGyrGet);
            parameters.Add(buttonGyrSet);
            parameters.Add(buttonMagGet);
            parameters.Add(buttonMagSet);
            parameters.Add(buttonTherGet);
            parameters.Add(buttonTherSet);
            parameters.Add(buttonPreGet);
            parameters.Add(buttonPreSet);
            parameters.Add(buttonHumGet);
            parameters.Add(buttonHumSet);

            // Ustalenie listy checkBoxów
            checks.Add(chBoxAccEnabled);
            checks.Add(chBoxGyrEnabled);
            checks.Add(chBoxMagEnabled);
            checks.Add(chBoxTherEnabled);
            checks.Add(chBoxHumEnabled);
            checks.Add(chBoxPreEnabled);

            // Dodawanie etykiet wybranych sensorów
            sensorNames.Add(accNameLab);
            sensorNames.Add(terNameLab);
            sensorNames.Add(magNameLab);
            sensorNames.Add(gyrNameLab);
            sensorNames.Add(humNameLab);
            sensorNames.Add(presNameLab);
        }

        private void CheckPorts()
        {
            // Pobieranie listyt dostępnych urządzeń MEMS
            List<AvailablePort> memsPorts = ComTransmition.CheckAvaliablePorts();
            int counter = 0;

            // Usuwanie listy poprzednich dostępnych urządzeń
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

            // Wyświetlenia okna głównego  po ukryciu paska ładowania
            BringToFront();
        }

        // Wyświetlenie aplikacji na wierzchu, po załadowaniu
        private void UserForm_Shown(object sender, EventArgs e)
        {
            TopMost = false;
        }

        private bool ChceckDevices(ComboBox deviceList, byte sensor)
        {
            // Pobiearanie listy dostępnych sensorów danego rodzaju
            List<string> sensorDevices;
            sensorDevices = Communication.GetAvailableSensors(sensor);
            progressBarCOM.Value += 100 / 6;

            // Dodawanie dostępnych sensorów do odpowiednich ComboBoxów
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

            // Jeżeli brak odpowiedzi - brak czujnika - GroupBox w zakładce "czujniki MEMS" nie zostanie odblokowany
            else return false;
        }

        // Wypisanie wartości rejestru w GroupBoxie "Rejestr"
        private void NewCommandToShow(object sender, EventArgs e)
        {
            // Pobranie ramki z informacją
            byte[] data = ((Command<byte[]>)sender).Dequeue();

            // Przypisanie wartości do odpowiedniego TextBoxa
            foreach (Sensor s in sensors)
            {
                if (s.sensorNr == data[4]) // Odnalezienie odpowiedniego czujnika
                {
                    if (enabledRegister) // Jeżeli otwarty rejestr wartości wyświetlą się w oknie rejestru
                    {
                        s.AddToRegisters(data[5].ToString("X2"), data[6].ToString("X2"));
                    }
                    else
                        foreach (Control c in tabPageSensors.Controls)
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

        // Otwarcie portu szeregowego
        private void buttonOtworz_Click(object sender, EventArgs e)
        {
            try
            {
                //Czyszczenie listy poprzednich urzadzen
                foreach (ComboBox cBox in clear)
                    cBox.Items.Clear();

                // Wysłanie ustawień początkowych aplikacji
                Communication.Query((byte)CmdType.DataSet, cBoxPorts.Text);

                // Sprawdzanie dostępności poszczególnych sensorów
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

                // Tworzenie kolejki (Command) czułej na zdarzenie (pojawienie się nowej ramki z komendą rejestru)
                command = new Command<byte[]>();
                command.Changed += new EventHandler(this.NewCommandToShow);

                // Tworzenie referencji dla obiektu portu szeregowego
                object[] param = new object[] { command, sensors, rTBoxData };
                ComTransmition.Read(param);

                // Tworzenie okien wykresów 
                foreach (Sensor s in sensors)
                    if (s is EnvSensor)
                        s.OpenPlot(0);
                    else
                        foreach (Control c in tabPageSensors.Controls)
                            if (c is GroupBox gBox && (string)gBox.Tag == s.sensorName)
                                foreach (Control g in gBox.Controls)
                                    if (s is MotionSensor && g is ComboBox cBox && g.Name.Contains("Scale"))
                                        s.OpenPlot(Int32.Parse(cBox.Text));

                // Włączanie/wyłączanie przycisków
                foreach (Control control in enableDisable)
                    control.Enabled = true;

                buttonOpen.Enabled = false;
                buttonStop.Enabled = false;
                cBoxPorts.Enabled = false;
                btnRefresh.Enabled = false;
                portOpenToolStripMenuItem.Enabled = false;
                zamknijPortToolStripMenuItem.Enabled = true;

                rTBoxData.Text += "Poprawnie połączono z portem: " + cBoxPorts.Text + "\n";
                progressBarCOM.Value = 100;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Wystąpił błąd podczas połączenia z portem szeregowym. Sprawdź parameters połączenia. \n" + exc.Message, "Błąd");
                Communication.Query((byte)CmdType.StopTransmition);
                ComTransmition.StopRead();
                ComTransmition.ClosePort();

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

            foreach (Sensor s in sensors)
                s.ClosePlot();

            // Włączanie/wyłączanie przycisków
            foreach (Control control in enableDisable)
                control.Enabled = false;

            // Blokowanie groupBoxów
            foreach (GroupBox box in gBoxMEMSSensors)
                box.Enabled = false;

            // Czyszczenie listy czujników
            sensors.Clear();
            ClearRegisters();

            rTBoxData.Text += "Poprawnie zamknięto połączenie z portem " + cBoxPorts.Text + "\n";

            // Włączanie/ wyłączanie kontrolek
            progressBarCOM.Value = 0;
            progressBarData.Value = 0;

            buttonOpen.Enabled = true;
            cBoxPorts.Enabled = true;
            btnRefresh.Enabled = true;
            portOpenToolStripMenuItem.Enabled = true;
            zamknijPortToolStripMenuItem.Enabled = false;
            otwórzPomiaryZPlikuToolStripMenuItem.Enabled = true;

            włączWyłączPrzerwaniaToolStripMenuItem.Enabled = false;
            DisableAllToolStripMenuItem.Enabled = false;
            EnableAllToolStripMenuItem.Enabled = false;
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

                // Odznaczanie wszystkich checkBoxów "Włączony"
                foreach (CheckBox cBox in checks)
                    cBox.Checked = false;

                // Ustawienie parametru wyłączenie płytki
                foreach (Sensor s in sensors)
                    s.isEnabled = false;

                // Wyswietlenie drugiej zakładki
                tabControlMain.SelectedIndex = 1;

                // Wstawianie nazwy sensora
                foreach (Control c in gBoxSensors.Controls)
                    if (c is ComboBox cBox)
                        foreach (Label lab in sensorNames)
                            if (cBox.Tag == lab.Tag)
                                lab.Text = cBox.Text;

                // Odblokowanie groupBoxów
                foreach (GroupBox box in gBoxMEMSSensors)
                    box.Enabled = true;

                // Odblokowywanie comboBoxów dostępnych sensorów
                foreach (ComboBox combo in clear)
                    combo.Enabled = false;

                // Blokowanie/odblokowywanie odpowiednich opcji w pasku menu
                foreach (ToolStripMenuItem menuItem in startTransmisionEnableDisable)
                    menuItem.Enabled = !menuItem.Enabled;

                buttonStart.Enabled = false;
                buttonStop.Enabled = true;

                // Wysyłanie początkowych ustawień zakresów oraz ODR
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
                cBox.Checked = false;

            // Blokowanie groupBoxów
            foreach (GroupBox box in gBoxMEMSSensors)
                box.Enabled = false;

            // Odblokowywanie comboBoxów dostepnych sensorów
            foreach (ComboBox combo in clear)
                combo.Enabled = true;

            // Blokowanie/odblokowywanie odpowiednich opcji w pasku menu
            foreach (ToolStripMenuItem menuItem in startTransmisionEnableDisable)
                menuItem.Enabled = !menuItem.Enabled;

            buttonStart.Enabled = true;
            buttonStop.Enabled = false;

            // Czyszczenie rejestrów oraz listy rejestrów
            ClearRegisters();

            progressBarData.Value = 0;
        }


        // Włączanie/wyłączaqnie czujników
        private void włączWszystkieCzujnikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sensor.EnableAll();
            foreach (CheckBox ch in checks)
                ch.Checked = true;
        }

        private void wyłączWszystkieCzujnikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sensor.DisableAll();
            foreach (CheckBox ch in checks)
                ch.Checked = false;
        }

        // Włączanie/wyłączanie czujników
        private void ChangeEnable(object sender, EventArgs e)
        {
            foreach (Sensor s in sensors)
                if (s.sensorName == (string)((CheckBox)sender).Tag)
                {
                    s.SetEnable(((CheckBox)sender).Checked); // Wysłanie informacji do płytki

                    // Sprawdzenie czy sumaryczny ODR nie jest za wysoki i ewentualne blokowanie TextBoxa z zakładki "Datalog"
                    foreach (Control c in tabPageSensors.Controls)
                        if (c is GroupBox)
                            foreach (Control g in c.Controls)
                                if (g is ComboBox && g.Enabled && (string)g.Tag == s.sensorName && g.Name.Contains("ODR"))
                                {
                                    bool wasShown = showText;
                                    showText = s.SumOdr(sender, float.Parse(g.Text));

                                    if (wasShown && !showText)
                                        rTBoxData.AppendText("Ustawiono zbyt duży ODR, aby wyświetlić parametry!\n");
                                }
                }

        }

        // Włączanie/ wyłączanie wysyłania przerwań przez płytkę
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
                    bool wasShown = showText;

                    s.SetOdr(BitConverter.GetBytes(float.Parse(((ComboBox)sender).Text)));
                    showText = s.SumOdr(sender, float.Parse(((ComboBox)sender).Text));

                    if (wasShown && !showText)
                        rTBoxData.AppendText("Ustawiono zbyt duży ODR, aby wyświetlić parametry!\n");
                }
            }
        }

        // Ustawianie zakresów 
        private void SetScale(object sender, EventArgs e)
        {
            foreach (Sensor s in sensors)
                if (s is MotionSensor ms && s.sensorName == (string)((ComboBox)sender).Tag)
                {
                    ms.SetScale(BitConverter.GetBytes(Int32.Parse(((ComboBox)sender).Text)));
                    ms.SetPlotScale(Int32.Parse(((ComboBox)sender).Text));
                }
        }

        // Ustawianie parametrów rejestru
        private void SetRegParam(object sender, EventArgs e)
        {
            foreach (Sensor s in sensors)
                if (s.sensorName == (string)((Button)sender).Tag)
                    foreach (Control c in tabPageSensors.Controls)
                        if (c is GroupBox && c.Tag == ((Button)sender).Tag)
                            s.SetRegisterParameter(c.Controls[4].Controls[3].Text, c.Controls[4].Controls[2].Text);

        }

        // Pobieranie ustawień rejestrów    
        private void GetRegParam(object sender, EventArgs e)
        {
            foreach (Sensor s in sensors)
                if (s.sensorName == (string)((Button)sender).Tag)
                    foreach (Control c in tabPageSensors.Controls)
                        if (c is GroupBox && c.Tag == ((Button)sender).Tag)
                            s.GetRegisterParameter(c.Controls[4].Controls[3].Text);

        }

        // Zamknięcie portu przed wyłączeniem aplikacji
        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            buttonZamknij_Click(this, null);
        }

        // Otwarcie połączenia z portem przez pasek menu
        private void portOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonOtworz_Click(this, null);
        }

        // Zamknięcie aplikacji przez pasek menu
        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Usuwanie okien rejestrów (podczas rozłączania z portem)
        private void ClearRegisters()
        {
            foreach (SensorRegister sr in registers)
                sr.ExitRegister();

            registers.Clear();
        }

        // Czyszczenie Datalogu
        private void button1_Click(object sender, EventArgs e)
        {
            rTBoxData.Text = "";
        }

        // Odświeżanie listy dostępnych urządzeń (groupBox "Informacje")
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CheckPorts();
        }

        // Tworzenie/ wyświetlanie okna wykresów
        private void ShowPlot(object sender, EventArgs e)
        {
            foreach (Sensor s in sensors)
                if ((string)((Button)sender).Tag == s.sensorName)
                    s.OpenPlot(0);
        }

        // Czyszczenie danych czujników (pasek menu)
        private void CleartSensorData(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Czy na pewno chcesz usunąć dane oraz wykresy z tego czujnika?", "Usuń dane", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                foreach (Sensor s in sensors)
                    if ((string)(((ToolStripMenuItem)sender).Tag) == s.sensorName)
                    {
                        s.ClearData();
                        s.ClearPlot();
                    }
        }

        // Czyszczenie wykresów czujników (pasek menu)
        private void ClearSensorPlot(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Czy na pewno chcesz usunąć wykresy z tego czujnika?", "Usuń wykres", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                foreach (Sensor s in sensors)
                    if ((string)(((ToolStripMenuItem)sender).Tag) == s.sensorName)
                        s.ClearPlot();
        }

        // Zapisywanie parametrów czujników (pasek menu)
        private void SaveSensorParameters(object sender, EventArgs e)
        {
            string toSave = string.Empty;
            string fileName = string.Empty;

            // Dobieranie wybranego czujnika
            foreach (Sensor s in sensors)
                if ((sender is ToolStripMenuItem && (string)((ToolStripMenuItem)sender).Tag == s.sensorName) || (sender is Sensor sens && sens.sensorName == s.sensorName))
                {
                    toSave = s.GetData(); // Pobieranie danych czujnika
                    fileName = s.sensorName + DateTime.Today.ToString(" MMM-dd") + ".mem"; // Tworzenie proponowanej nazwy pliku
                }

            // Tworzenie obiektu okna dialogowego
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Zapisz dane czujnika",
                Filter = "Pliki aplikacji MEMS | *.mem",
                FileName = fileName,
                DefaultExt = "*.mem"
            };

            // Zapis pliku na dysku
            if (toSave != string.Empty && saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                    sw.Write(toSave);
            }
            else if (toSave == string.Empty)
                MessageBox.Show("Brak danych do zapisania!", "Błąd zapisu danych", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Rysoiwanie wykresu z pliku
        private void otwórzPomiaryZPlikuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            // Otwieranie okna dialogowego
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Dane aplikacji MEM (*.mem)|*.mem|Wszystkie pliki (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        filePath = openFileDialog.FileName;
                        var fileStream = openFileDialog.OpenFile();

                        // Pobieranie danych z pliku
                        using (StreamReader reader = new StreamReader(fileStream))
                            fileContent = reader.ReadToEnd();

                        // Sczytywanie danych podstawowych (rodzaj czujnika oraz ilość parametrów)
                        string sensorName = fileContent.Substring(0, fileContent.IndexOf("\n"));
                        fileContent = fileContent.Remove(0, fileContent.IndexOf("\n") + 1);

                        string buffer = string.Empty;

                        buffer = fileContent.Substring(0, 1);
                        fileContent = fileContent.Remove(0, 2);

                        // Tworzenie okna wykresu
                        Plot plot = new Plot(sensorName, 1);
                        plot.Load -= plot.Plot_Load;
                        plot.WindowState = FormWindowState.Normal;
                        plot.Show();

                        // Rysuj wykres...
                        switch (buffer)
                        {
                            case "1": // ...z jednym parametrem
                                while (fileContent.Length > 0)
                                {
                                    float[] parameter = new float[2];
                                    parameter[0] = float.Parse(fileContent.Substring(0, fileContent.IndexOf("|")));
                                    fileContent = fileContent.Remove(0, fileContent.IndexOf("|") + 1);

                                    parameter[1] = float.Parse(fileContent.Substring(0, fileContent.IndexOf("|")));
                                    fileContent = fileContent.Remove(0, fileContent.IndexOf("\n") + 1);

                                    plot.AddPoints(parameter);
                                }
                                break;

                            case "3": // ...z trzema parametrami
                                while (fileContent.Length > 0)
                                {
                                    int[] parameter = new int[4];
                                    for (int i = 0; i < 4; i++)
                                    {
                                        parameter[i] = Int32.Parse(fileContent.Substring(0, fileContent.IndexOf("|")));
                                        fileContent = fileContent.Remove(0, fileContent.IndexOf("|") + 1);
                                    }
                                    fileContent = fileContent.Remove(0, 1);

                                    plot.AddPoints(parameter);
                                }
                                break;

                            default:
                                plot.Close();
                                plot.Dispose();
                                MessageBox.Show("Błąd ładowania pliku. Wybrany plik nie zgadza się z wymaganiami!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                return;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Błąd ładowania pliku. Wybrany plik nie zgadza się z wymaganiami!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Otwarcie okna "O programie"
        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        // Włączanie textBoxów w GroupBoxach "Rejestr" (przy zamknięciu okna rejestru)
        public static void EnableParameterButtons()
        {
            bool allDisable = true;
            foreach (SensorRegister sReg in registers)
                if (sReg.Visible)
                    allDisable = false;

            if (allDisable)
            {
                enabledRegister = false;
                foreach (Button btn in parameters)
                    btn.Enabled = true;
            }
        }

        // Otwarcie okna rejestru
        private void buttonRegisterOpen_Click(object sender, EventArgs e)
        {

            foreach (Control c in tabPageSensors.Controls)
            {
                if (c is GroupBox gBox && c.Tag == ((Button)sender).Tag)
                {
                    foreach (Control g in gBox.Controls)
                    {
                        if (g is Label lab && g.Name.Contains("NameLab")) // Pobieranie nazwy sensora
                        {
                            string regName = lab.Text;
                            bool search = false;
                            foreach (SensorRegister sReg in registers) // Sprawdzanie czy okno zostało utworzone
                                if (sReg.Text == regName)
                                {
                                    search = true;
                                    sReg.Visible = true;

                                    foreach (Button btn in parameters)
                                        btn.Enabled = false;

                                    enabledRegister = true;
                                }

                            if (search != true)  // Jeżeli nie stworzono okna rejestru
                                if (File.Exists(regName + ".txt")) // Sprawdzanie dostępności pliku do stworzenia rejestru
                                {
                                    foreach (Sensor s in sensors)
                                        if ((string)(lab.Tag) == s.sensorName)
                                        {
                                            // Tworzenie okna rejestru
                                            SensorRegister sensorRegister = new SensorRegister(regName, s);
                                            registers.Add(sensorRegister);

                                            s.AssignRegister(sensorRegister);
                                            sensorRegister.Show();

                                            foreach (Button btn in parameters)
                                                btn.Enabled = false;

                                            enabledRegister = true;
                                        }

                                }
                                else
                                {
                                    MessageBox.Show("Brak danych rejestru w bazie plików.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                        }
                    }
                }
            }
        }

        // Zmiana indeksu wybranego czujnika danego typu
        private void ChangeDeviceIndex(object sender, EventArgs e)
        {
            foreach (Sensor s in sensors)
                if ((string)((ComboBox)sender).Tag == s.sensorName)
                    s.selectedDeviceIndex = ((ComboBox)sender).SelectedIndex;
        }

        // Okno "Pomoc"
        private void pomocToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Forms.Help help = new Forms.Help();
            help.ShowDialog();
        }

        // Zapisanie danych z wszystkich czujników
        private void zapiszWszystkieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Sensor s in sensors)
                SaveSensorParameters(s, null);
        }

        // Czyszczenie wykresów z wszystkich czujników
        private void wyczyśćWszystkieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Czy na pewno chcesz usunąć wykresy ze wszystkich czujników?", "Usuń wykresy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                foreach (Sensor s in sensors)
                    s.ClearPlot();
        }

        // Czyszczenie danych z wszystkich czujników
        private void wyczyśćWszystkieToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Czy na pewno chcesz usunąć dane oraz wykresy ze wsystkich czujników?", "Usuń dane", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                foreach (Sensor s in sensors)
                {
                    s.ClearData();
                    s.ClearPlot();
                }
        }

        // Zamknięcie połączenia z portem szeregowym z poziomu paska menu
        private void zamknijPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonZamknij_Click(this, null);
        }
    }
}
