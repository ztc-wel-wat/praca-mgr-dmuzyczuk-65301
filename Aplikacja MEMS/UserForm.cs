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
        List<Control> wlaczWylacz = new List<Control>();
        List<ComboBox> wyczysc = new List<ComboBox>();
        List<GroupBox> gBoxCzujnikiMEMS = new List<GroupBox>();
        List<Czujnik> czujniki = new List<Czujnik>();
        List<CheckBox> wlaczniki = new List<CheckBox>();

        string[] portyCOM;
        Ladowanie ladowanie = new Ladowanie();
        ThreadStart ladowaniePaska;
        Thread pasek;

        Komunikacja komunikacja;
        BackgroundWorker bgWorkWypisz;

        Czujnik akcelerometr;
        Czujnik zyroskop;
        Czujnik magnetometr;
        Czujnik termometr;
        Czujnik barometr;
        Czujnik higrometr;

        byte czujnik = 0x77;
        byte[] parametry = new byte[10];

        int odpowiedz = 0;
        byte[] odp = new byte[4096];

        public UserForm()
        {
            InitializeComponent();

            komunikacja = new Komunikacja(this);

            // Ustawienie rozmiaru groupBoxów
            gBoxInfo.Height = tabPageOgolne.Height / 3;
            gBoxPolaczenie.Height = tabPageOgolne.Height / 3;
            gBoxCzujniki.Height = tabPageOgolne.Height / 3;

            // Tworzenie listy kontrolek aktywowanych/dezaktywowanych podczas otwierania portu
            wlaczWylacz.Add(cBoxAkcelerometr);
            wlaczWylacz.Add(cBoxBarometr);
            wlaczWylacz.Add(cBoxHigrometr);
            wlaczWylacz.Add(cBoxMagnetometr);
            wlaczWylacz.Add(cBoxTermometr);
            wlaczWylacz.Add(cBoxZyroskop);
            wlaczWylacz.Add(buttonStart);
            wlaczWylacz.Add(buttonZamknij);
            wlaczWylacz.Add(cBoxPorty);
            wlaczWylacz.Add(buttonStart);
            wlaczWylacz.Add(buttonStop);

            // Lista comboboxów do wyczyszczenia po ponownym załądowaniu portu COM
            wyczysc.Add(cBoxAkcelerometr);
            wyczysc.Add(cBoxBarometr);
            wyczysc.Add(cBoxHigrometr);
            wyczysc.Add(cBoxMagnetometr);
            wyczysc.Add(cBoxTermometr);
            wyczysc.Add(cBoxZyroskop);

            // Lista groupBoxów do włączania/wyłączania podczas przesyłu danych
            gBoxCzujnikiMEMS.Add(gBoxAkcelerometr);
            gBoxCzujnikiMEMS.Add(gBoxBarometr);
            gBoxCzujnikiMEMS.Add(gBoxHigrometr);
            gBoxCzujnikiMEMS.Add(gBoxMagnetometr);
            gBoxCzujnikiMEMS.Add(gBoxTermometr);
            gBoxCzujnikiMEMS.Add(gBoxZyroskop);

            // Parametry poczatkowe w listach wybieranych zakładki "Czujniki MEMS"
            cBoxAkcODR.Text = cBoxAkcODR.Items[0].ToString();
            cBoxBarODR.Text = cBoxBarODR.Items[0].ToString();
            cBoxMagODR.Text = cBoxMagODR.Items[0].ToString();
            cBoxZyroODR.Text = cBoxZyroODR.Items[0].ToString();
            cBoxTermODR.Text = cBoxTermODR.Items[0].ToString();
            cBoxHigODR.Text = cBoxHigODR.Items[0].ToString();

            cBoxAkcSkala.Text = cBoxAkcSkala.Items[0].ToString();
            cBoxMagSkala.Text = cBoxMagSkala.Items[0].ToString();
            cBoxZyroSkala.Text = cBoxZyroSkala.Items[0].ToString();

            // Włączenie paska ładowania dostępnych urządzeń
            ladowaniePaska = new ThreadStart(StartPaska);
            pasek = new Thread(ladowaniePaska);
            pasek.Start();

            // Ustalenie listy checkBoxów
            wlaczniki.Add(chBoxAkcWlaczony);
            wlaczniki.Add(chBoxZyroWlaczony);
            wlaczniki.Add(chBoxMagWlaczony);
            wlaczniki.Add(chBoxTermWlaczony);
            wlaczniki.Add(chBoxHigWlaczony);
            wlaczniki.Add(chBoxBarWlaczony);
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            BackgroundWorker bgW = new BackgroundWorker();

            // Załądowanie listy wszystkich dostępnych portów COM
            portyCOM = SerialPort.GetPortNames();
            List<string> portyMEMS = new List<string>();

            int licznik = 0;
            // Tworzenie listy portów COM z podpiętym urządzeniem MEMS
            foreach (string port in portyCOM)
            {
                bgW = new BackgroundWorker();

                try
                {
                    // Otwarcie portu
                    serialPort.PortName = port;
                    serialPort.Open();

                    // Wysłanie zapytania do urządzenia 
                    serialPort.Write(Komunikacja.Zapytanie(0x02, 0x00, 0x00, 0x00, parametry), 0, 5);

                    // Pobranie odpowiedzi z bufora COM
                    Task oczekiwanie = Oczekuj();
                    oczekiwanie.Wait(2000);

                    // Dodawanie spisu dostępnych urządzeń (napis w boxie "Informacje")
                    if (odpowiedz > 0)
                    {
                        labelBrakPlytek.Visible = false; // Ukrycie informacji o braku urządzeń

                        labelCOM = new Label();
                        labelCOM.AutoSize = true;
                        labelCOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                        labelCOM.Location = new System.Drawing.Point(20, 85 + (licznik * 15));
                        labelCOM.Name = "label" + port;
                        labelCOM.Size = new System.Drawing.Size(146, 17);
                        labelCOM.Text = port + ": " + Encoding.UTF8.GetString(odp, 3, odpowiedz - 5);
                        labelCOM.Visible = true;
                        gBoxInfo.Controls.Add(this.labelCOM);
                        portyMEMS.Add(port);

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

            async Task Oczekuj()
            {
                odpowiedz = serialPort.Read(odp, 0, serialPort.ReadBufferSize);
            }

            // Przypisanie listy dostępnych portów COM z podłączonymi urządzeniami MEMS do okna wybory (comboBox)
            foreach (string port in portyMEMS)
            {
                cBoxPorty.Items.Add(port);
            }

            bgW = new BackgroundWorker();
            bgW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            bgW.RunWorkerAsync();
            Thread.Sleep(500);

            // Zamknięcie okna ładowania aplikacji
            Action<int> updateAction1 = new Action<int>((value) => ladowanie.Close());
            ladowanie.Invoke(updateAction1, 32);
        }
        private System.Windows.Forms.Label labelCOM;

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Ładowanie progressBar podczas włączania aplikacji
            if (ladowanie.progressBar.Value < 90)
            {
                Action<int> updateAction = new Action<int>((value) => ladowanie.progressBar.Value += 90 / portyCOM.Length);
                ladowanie.progressBar.Invoke(updateAction, 32);
            }
            else
            {
                Action<int> updateAction = new Action<int>((value) => ladowanie.progressBar.Value = 100);
                ladowanie.progressBar.Invoke(updateAction, 32);
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
                byte[] odp = new byte[serialPort.ReadBufferSize];

                serialPort.PortName = cBoxPorty.Text;
                serialPort.Open();

                // Czyszczenie listy poprzednich urzadzen
                foreach (ComboBox cBox in wyczysc)
                {
                    cBox.Items.Clear();
                }

                // Wysłanie ustawień początkowych aplikacji
                serialPort.Write(Komunikacja.Zapytanie(0x0C, 0x00, 0x00, 0x00, parametry), 0, 12);

                buttonOtworz.Enabled = false;
                cBoxPorty.Enabled = false;

                // Pobranie list czujnikow
                byte[] listaAkcelerometrow = Komunikacja.OdbierzListyCzujnikow(Komunikacja.Zapytanie(0x50, 0x01, 0x14, 0x00, parametry), serialPort, progressBarCOM); // Akcelerometry
                byte[] listaZyroskopow = Komunikacja.OdbierzListyCzujnikow(Komunikacja.Zapytanie(0x50, 0x02, 0x14, 0x00, parametry), serialPort, progressBarCOM); // Żyroskopy
                byte[] listaMagnetometrow = Komunikacja.OdbierzListyCzujnikow(Komunikacja.Zapytanie(0x50, 0x03, 0x14, 0x00, parametry), serialPort, progressBarCOM); // Magnetometry
                byte[] listaTermometrow = Komunikacja.OdbierzListyCzujnikow(Komunikacja.Zapytanie(0x50, 0x04, 0x14, 0x00, parametry), serialPort, progressBarCOM); // Termometry
                byte[] listaHigrometrow = Komunikacja.OdbierzListyCzujnikow(Komunikacja.Zapytanie(0x50, 0x05, 0x14, 0x00, parametry), serialPort, progressBarCOM); // Higrometry
                byte[] listaBarometrow = Komunikacja.OdbierzListyCzujnikow(Komunikacja.Zapytanie(0x50, 0x06, 0x14, 0x00, parametry), serialPort, progressBarCOM); // Barometry

                // Wypisanie list do combo boxów
                ZaladujListeUrzadzen("Akcelerometr", listaAkcelerometrow);
                ZaladujListeUrzadzen("Żyroskop", listaZyroskopow);
                ZaladujListeUrzadzen("Magnetometr", listaMagnetometrow);
                ZaladujListeUrzadzen("Termometr", listaTermometrow);
                ZaladujListeUrzadzen("Higrometr", listaHigrometrow);
                ZaladujListeUrzadzen("Barometr", listaBarometrow);

                progressBarCOM.Value = 90;
                // Włączanie/wyłączanie przycisków
                foreach (Control control in wlaczWylacz)
                {
                    control.Enabled = true;
                }

                buttonOtworz.Enabled = false;
                buttonStop.Enabled = false;
                cBoxPorty.Enabled = false;

                progressBarCOM.Value = 100;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Wystąpił błąd podczas połączenia z portem szeregowym. Sprawdź parametry połączenia.", "Błąd");
                if (serialPort.IsOpen)
                    serialPort.Close();

                progressBarCOM.Value = 0;

                // Włączanie/wyłączanie przycisków
                foreach (Control control in wlaczWylacz)
                {
                    control.Enabled = false;
                }

                buttonOtworz.Enabled = true;
                cBoxPorty.Enabled = true;
            }
        }
        private void buttonZamknij_Click(object sender, EventArgs e)
        {
            // Wstrzymanie wysylania informacji przez płytkę
            byte[] parametry = new byte[1];
            serialPort.Write(Komunikacja.Zapytanie(0x09, 0x00, 0x00, 0x00, parametry), 0, 5);

            if (serialPort.IsOpen)
                serialPort.Close();

            progressBarCOM.Value = 0;

            // Włączanie/wyłączanie przycisków
            foreach (Control control in wlaczWylacz)
            {
                control.Enabled = false;
            }

            // Blokowanie groupBoxów
            foreach (GroupBox box in gBoxCzujnikiMEMS)
            {
                box.Enabled = false;
            }

            progressBarDane.Value = 0;

            buttonOtworz.Enabled = true;
            cBoxPorty.Enabled = true;
        }

        private void ZaladujListeUrzadzen(string urzadzenie, byte[] dane)
        {
            List<string> czujniki = new List<string>();
            ASCIIEncoding ascii = new ASCIIEncoding();
            string bufor = string.Empty;
            int poczatek = 5;

            // Wyszukiwanie znaku przecinka, tlumaczenie oraz tworzenie listy urządzen na string
            for (int i = 5; i < (dane.Length - 2); i++)
            {
                switch (dane[i])
                {
                    case 0x2C:
                        bufor = ascii.GetString(dane, poczatek, i - poczatek);
                        czujniki.Add(bufor);
                        bufor = string.Empty; 
                        poczatek = i + 1;
                        break;
                }
            }

            // Dodawanie ostatniego czujnika (po nim nie ma znaku przecinka
            bufor = ascii.GetString(dane, poczatek, (dane.Length - 2) - poczatek);
            czujniki.Add(bufor);

            // Aktualizowanie comboboxów wyboru czujnika
            switch (urzadzenie)
            {
                case "Akcelerometr":
                    foreach (string czujnik in czujniki)
                    {
                        cBoxAkcelerometr.Items.Add(czujnik);
                    }
                    cBoxAkcelerometr.Text = cBoxAkcelerometr.Items[0].ToString();
                    break;

                case "Żyroskop":
                    foreach (string czujnik in czujniki)
                    {
                        cBoxZyroskop.Items.Add(czujnik);
                    }
                    cBoxZyroskop.Text = cBoxZyroskop.Items[0].ToString();
                    break;

                case "Magnetometr":
                    foreach (string czujnik in czujniki)
                    {
                        cBoxMagnetometr.Items.Add(czujnik);
                    }
                    cBoxMagnetometr.Text = cBoxMagnetometr.Items[0].ToString();
                    break;

                case "Termometr":
                    foreach (string czujnik in czujniki)
                    {
                        cBoxTermometr.Items.Add(czujnik);
                    }
                    cBoxTermometr.Text = cBoxTermometr.Items[0].ToString();
                    break;

                case "Higrometr":
                    foreach (string czujnik in czujniki)
                    {
                        cBoxHigrometr.Items.Add(czujnik);
                    }
                    cBoxHigrometr.Text = cBoxHigrometr.Items[0].ToString();
                    break;

                case "Barometr":
                    foreach (string czujnik in czujniki)
                    {
                        cBoxBarometr.Items.Add(czujnik);
                    }
                    cBoxBarometr.Text = cBoxBarometr.Items[0].ToString();
                    break;
            }
            progressBarCOM.Value += 5;
        }

        // Włączenie okna ładowania aplikacji
        private void StartPaska()
        {
            Application.Run(ladowanie);
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;

                // Blokowanie comboBoxów oraz wysyłanie informacji o wybranym czujniku
                foreach (ComboBox combo in wyczysc)
                {
                    combo.Enabled = false;
                    serialPort.Write(Komunikacja.Zapytanie(0x50, (byte)(i + 1), 0x15, (byte)combo.Items.IndexOf(combo.Text), parametry), 0, 8);
                    i++;
                }

                // Wysłanie listy włączonych urządzeń
                serialPort.Write(Komunikacja.Zapytanie(0x08, czujnik, 0x00, 0x00, parametry), 0, 13);

                akcelerometr = new Czujnik("Akcelerometr", cBoxAkcelerometr.Text, gBoxAkcelerometr, serialPort);
                zyroskop = new Czujnik("Żyroskop", cBoxZyroskop.Text, gBoxZyroskop, serialPort);
                magnetometr = new Czujnik("Magnetometr", cBoxMagnetometr.Text, gBoxMagnetometr, serialPort);
                termometr = new Czujnik("Termometr", cBoxTermometr.Text, gBoxTermometr, serialPort);
                barometr = new Czujnik("Barometr", cBoxBarometr.Text, gBoxBarometr, serialPort);
                higrometr = new Czujnik("Higrometr", cBoxHigrometr.Text, gBoxHigrometr, serialPort);

                czujniki.Add(akcelerometr);
                czujniki.Add(zyroskop);
                czujniki.Add(barometr);
                czujniki.Add(termometr);
                czujniki.Add(magnetometr);
                czujniki.Add(higrometr);

                // Rozpoczęcie pobierania danych
                komunikacja.Odbior(serialPort);

                // Wyswietlenie drugiej zakładki
                tabControlCzujniki.SelectedIndex = 1;

                // Odblokowanie groupBoxów
                foreach (GroupBox box in gBoxCzujnikiMEMS)
                {
                    box.Enabled = true;
                }

                // Odblokowywanie comboBoxów dostępnych czujników
                foreach (ComboBox combo in wyczysc)
                {
                    combo.Enabled = false;
                }

                buttonStart.Enabled = false;
                buttonStop.Enabled = true;
                włączWszystkieCzujnikiToolStripMenuItem.Enabled = true;
                wyłączWszystkieCzujnikiToolStripMenuItem.Enabled = true;

                progressBarDane.Value = 100;
            }
            catch (Exception exc)
            {
                // Wstrzymaj odbiór danych
                komunikacja.StopOdbior();
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            // Wstrzymanie wysylania informacji przez płytkę
            serialPort.Write(Komunikacja.Zapytanie(0x09, 0x00, 0x00, 0x00, parametry), 0, 5);

            // Blokowanie groupBoxów
            foreach (GroupBox box in gBoxCzujnikiMEMS)
            {
                box.Enabled = false;
            }

            // Odblokowywanie comboBoxów dostepnych czujników
            foreach (ComboBox combo in wyczysc)
            {
                combo.Enabled = true;
            }

            // Wstrzymaj odbiór danych
            komunikacja.StopOdbior();

            włączWszystkieCzujnikiToolStripMenuItem.Enabled = false;
            wyłączWszystkieCzujnikiToolStripMenuItem.Enabled = false;
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;

            progressBarDane.Value = 0;
        }

        private void chBoxZyroWlaczony_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxZyroWlaczony.Checked == true)
            {
                czujnik += 0x20;
            }
            else
            {
                czujnik -= 0x20;
            }
            Czujnik.SendMessage(Komunikacja.Zapytanie(0x08, czujnik, 0x00, 0x00, parametry), serialPort);

            zyroskop.wlaczony = chBoxZyroWlaczony.Checked;
        }

        private void chBoxMagWlaczony_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxMagWlaczony.Checked == true)
            {
                czujnik += 0x40;
            }
            else
            {
                czujnik -= 0x40;
            }
            Czujnik.SendMessage(Komunikacja.Zapytanie(0x08, czujnik, 0x00, 0x00, parametry), serialPort);

            magnetometr.wlaczony = chBoxMagWlaczony.Checked;
        }

        private void chBoxTermWlaczony_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxTermWlaczony.Checked == true)
            {
                czujnik += 0x02;
            }
            else
            {
                czujnik -= 0x02;
            }
            Czujnik.SendMessage(Komunikacja.Zapytanie(0x08, czujnik, 0x00, 0x00, parametry), serialPort);

            termometr.wlaczony = chBoxTermWlaczony.Checked;
        }

        private void chBoxBarWlaczony_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxBarWlaczony.Checked == true)
            {
                czujnik += 0x01;
            }
            else
            {
                czujnik -= 0x01;
            }
            Czujnik.SendMessage(Komunikacja.Zapytanie(0x08, czujnik, 0x00, 0x00, parametry), serialPort);

            barometr.wlaczony = chBoxBarWlaczony.Checked;
        }

        private void chBoxHigWlaczony_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxHigWlaczony.Checked == true)
            {
                czujnik += 0x04;
            }
            else
            {
                czujnik -= 0x04;
            }
            Czujnik.SendMessage(Komunikacja.Zapytanie(0x08, czujnik, 0x00, 0x00, parametry), serialPort);

            higrometr.wlaczony = chBoxHigWlaczony.Checked;
        }

        private void chBoxAkcWlaczony_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxAkcWlaczony.Checked == true)
            {
                czujnik += 0x10;
            }
            else
            {
                czujnik -= 0x10;
            }
            Czujnik.SendMessage(Komunikacja.Zapytanie(0x08, czujnik, 0x00, 0x00, parametry), serialPort);

            akcelerometr.wlaczony = chBoxAkcWlaczony.Checked;
        }

        public void WyswietlDane(string doWyswietlenia)
        {
            bgWorkWypisz = new BackgroundWorker();
            bgWorkWypisz.DoWork += new System.ComponentModel.DoWorkEventHandler(bgWorkWypisz_DoWork);
            bgWorkWypisz.RunWorkerAsync(argument: doWyswietlenia);
        }
        private void bgWorkWypisz_DoWork(object sender, DoWorkEventArgs e)
        {
           Action<int> updateAction = new Action<int>((value) => rTBoxDane.Text += "Odebrano dane \n");
           rTBoxDane.Invoke(updateAction, 32);
        }

        private void cBoxAkcODR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                switch (cBoxAkcODR.SelectedIndex)
                {
                    case 0:
                        parametry[0] = 0x00;
                        parametry[1] = 0x00;
                        parametry[2] = 0x48;
                        parametry[3] = 0x41;
                        break;

                    case 1:
                        parametry[0] = 0x00;
                        parametry[1] = 0x00;
                        parametry[2] = 0xD0;
                        parametry[3] = 0x41;
                        break;

                    case 2:
                        parametry[0] = 0x00;
                        parametry[1] = 0x00;
                        parametry[2] = 0x50;
                        parametry[3] = 0x42;
                        break;

                    case 3:
                        parametry[0] = 0x00;
                        parametry[1] = 0x00;
                        parametry[2] = 0xD0;
                        parametry[3] = 0x42;
                        break;

                    case 4:
                        parametry[0] = 0x00;
                        parametry[1] = 0x00;
                        parametry[2] = 0x50;
                        parametry[3] = 0x43;
                        break;

                    case 5:
                        parametry[0] = 0x00;
                        parametry[1] = 0x00;
                        parametry[2] = 0xD0;
                        parametry[3] = 0x43;
                        break;

                    case 6:
                        parametry[0] = 0x00;
                        parametry[1] = 0x40;
                        parametry[2] = 0x50;
                        parametry[3] = 0x44;
                        break;

                    case 7:
                        parametry[0] = 0x00;
                        parametry[1] = 0x80;
                        parametry[2] = 0xCF;
                        parametry[3] = 0x44;
                        break;

                    case 8:
                        parametry[0] = 0x00;
                        parametry[1] = 0x20;
                        parametry[2] = 0x50;
                        parametry[3] = 0x45;
                        break;

                    case 9:
                        parametry[0] = 0x00;
                        parametry[1] = 0x20;
                        parametry[2] = 0xD0;
                        parametry[3] = 0x45;
                        break;
                }
                serialPort.Write(Komunikacja.Zapytanie(0x50, 0x01, 0x07, 0x00, parametry), 0, 11);
            }
        }

        private void włączWszystkieCzujnikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serialPort.Write(Komunikacja.Zapytanie(0x08, 0x77, 0x00, 0x00, parametry), 0, 11);
            foreach (CheckBox ch in wlaczniki)
            {
                ch.Checked = true;
            }
        }

        private void wyłączWszystkieCzujnikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serialPort.Write(Komunikacja.Zapytanie(0x08, 0x00, 0x00, 0x00, parametry), 0, 11);
            foreach (CheckBox ch in wlaczniki)
            {
                ch.Checked = false;
            }
        }

        private void cBoxZyroODR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                switch (cBoxZyroODR.SelectedIndex)
                {
                    case 0:
                        parametry[0] = 0x00;
                        parametry[1] = 0x00;
                        parametry[2] = 0x48;
                        parametry[3] = 0x41;
                        break;

                    case 1:
                        parametry[0] = 0x00;
                        parametry[1] = 0x00;
                        parametry[2] = 0xD0;
                        parametry[3] = 0x41;
                        break;

                    case 2:
                        parametry[0] = 0x00;
                        parametry[1] = 0x00;
                        parametry[2] = 0x50;
                        parametry[3] = 0x42;
                        break;

                    case 3:
                        parametry[0] = 0x00;
                        parametry[1] = 0x00;
                        parametry[2] = 0xD0;
                        parametry[3] = 0x42;
                        break;

                    case 4:
                        parametry[0] = 0x00;
                        parametry[1] = 0x00;
                        parametry[2] = 0x50;
                        parametry[3] = 0x43;
                        break;

                    case 5:
                        parametry[0] = 0x00;
                        parametry[1] = 0x00;
                        parametry[2] = 0xD0;
                        parametry[3] = 0x43;
                        break;

                    case 6:
                        parametry[0] = 0x00;
                        parametry[1] = 0x40;
                        parametry[2] = 0x50;
                        parametry[3] = 0x44;
                        break;

                    case 7:
                        parametry[0] = 0x00;
                        parametry[1] = 0x80;
                        parametry[2] = 0xCF;
                        parametry[3] = 0x44;
                        break;

                    case 8:
                        parametry[0] = 0x00;
                        parametry[1] = 0x20;
                        parametry[2] = 0x50;
                        parametry[3] = 0x45;
                        break;

                    case 9:
                        parametry[0] = 0x00;
                        parametry[1] = 0x20;
                        parametry[2] = 0xD0;
                        parametry[3] = 0x45;
                        break;
                }
                serialPort.Write(Komunikacja.Zapytanie(0x50, 0x02, 0x07, 0x00, parametry), 0, 11);
            }
        }

        private void cBoxMagODR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                switch (cBoxMagODR.SelectedIndex)
                {
                    case 0:
                        parametry[0] = 0x00;
                        parametry[1] = 0x00;
                        parametry[2] = 0x20;
                        parametry[3] = 0x41;
                        break;

                    case 1:
                        parametry[0] = 0x00;
                        parametry[1] = 0x00;
                        parametry[2] = 0xA0;
                        parametry[3] = 0x41;
                        break;

                    case 2:
                        parametry[0] = 0x00;
                        parametry[1] = 0x00;
                        parametry[2] = 0x48;
                        parametry[3] = 0x42;
                        break;

                    case 3:
                        parametry[0] = 0x00;
                        parametry[1] = 0x00;
                        parametry[2] = 0xC8;
                        parametry[3] = 0x42;
                        break;
                }
                serialPort.Write(Komunikacja.Zapytanie(0x50, 0x03, 0x07, 0x00, parametry), 0, 11);
            }
        }

        private void cBoxTermODR_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZmianaODR(cBoxTermODR.SelectedIndex);
        }

        private void cBoxHigODR_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZmianaODR(cBoxHigODR.SelectedIndex);
        }
        private void ZmianaODR(int indeks)
        {
            cBoxTermODR.SelectedIndex = cBoxHigODR.SelectedIndex = indeks;
            if (serialPort.IsOpen)
            {
                switch (indeks)
                {
                    case 0:
                        parametry[0] = 0x00;
                        parametry[1] = 0x00;
                        parametry[2] = 0x80;
                        parametry[3] = 0x3F;
                        break;

                    case 1:
                        parametry[0] = 0x00;
                        parametry[1] = 0x00;
                        parametry[2] = 0xA0;
                        parametry[3] = 0x41;
                        break;

                    case 2:
                        parametry[0] = 0x00;
                        parametry[1] = 0x00;
                        parametry[2] = 0x48;
                        parametry[3] = 0x42;
                        break;
                }
                serialPort.Write(Komunikacja.Zapytanie(0x50, 0x05, 0x07, 0x00, parametry), 0, 11);
            }
        }

    }
}
