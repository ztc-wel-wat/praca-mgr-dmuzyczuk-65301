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
        List<GroupBox> czujniki = new List<GroupBox>();

        string[] portyCOM;
        Ladowanie ladowanie = new Ladowanie();
        ThreadStart ladowaniePaska;
        Thread pasek;


        public UserForm()
        {
            InitializeComponent();

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
            czujniki.Add(gBoxAkcelerometr);
            czujniki.Add(gBoxBarometr);
            czujniki.Add(gBoxHigrometr);
            czujniki.Add(gBoxMagnetometr);
            czujniki.Add(gBoxTermometr);
            czujniki.Add(gBoxŻyroskop);

            ladowaniePaska = new ThreadStart(StartPaska);
            pasek = new Thread(ladowaniePaska);
            pasek.Start();

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
                    serialPort.PortName = port;
                    serialPort.Open();

                    // Wysłanie zapytania do urządzenia 
                    serialPort.Write(Komunikacja.Zapytanie(0x02, this, 0x00, 0x00, 0x00), 0, 5);

                    // Pobranie odpowiedzi z bufora COM
                    byte[] odp = new byte[serialPort.ReadBufferSize];
                    int odpowiedz = serialPort.Read(odp, 0, serialPort.ReadBufferSize);



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

        // Włączenie okna ładowania aplikacji
        private void StartPaska()
        {
            Application.Run(ladowanie);
        }

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

                buttonOtworz.Enabled = false;
                cBoxPorty.Enabled = false;

                // Pobranie list czujnikow
                byte[] listaAkcelerometrow = Komunikacja.OdbierzListyCzujnikow(Komunikacja.Zapytanie(0x50, this, 0x01, 0x14, 0x00), this); // Akcelerometry
                byte[] listaZyroskopow = Komunikacja.OdbierzListyCzujnikow(Komunikacja.Zapytanie(0x50, this, 0x02, 0x14, 0x00), this); // Żyroskopy
                byte[] listaMagnetometrow = Komunikacja.OdbierzListyCzujnikow(Komunikacja.Zapytanie(0x50, this, 0x03, 0x14, 0x00), this); // Magnetometry
                byte[] listaTermometrow = Komunikacja.OdbierzListyCzujnikow(Komunikacja.Zapytanie(0x50, this, 0x04, 0x14, 0x00), this); // Termometry
                byte[] listaHigrometrow = Komunikacja.OdbierzListyCzujnikow(Komunikacja.Zapytanie(0x50, this, 0x05, 0x14, 0x00), this); // Higrometry
                byte[] listaBarometrow = Komunikacja.OdbierzListyCzujnikow(Komunikacja.Zapytanie(0x50, this, 0x06, 0x14, 0x00), this); // Barometry

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
            if (serialPort.IsOpen)
                serialPort.Close();

            progressBarCOM.Value = 0;


            // Włączanie/wyłączanie przycisków
            foreach (Control control in wlaczWylacz)
            {
                control.Enabled = false;
            }

            // Blokowanie groupBoxów
            foreach (GroupBox box in czujniki)
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
            string bufor = "";
            int poczatek = 5;

            // Wyszukiwanie znaku przecinka, tlumaczenie oraz tworzenie listy urządzen na string
            for (int i = 5; i < (dane.Length-2); i++)
            {
                switch (dane[i])
                {
                    case 0x2C:
                        bufor = ascii.GetString(dane, poczatek, i - poczatek);
                        czujniki.Add(bufor);
                        bufor = "";
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

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach(ComboBox combo in wyczysc)
            {
                byte[] buffer = new byte[serialPort.ReadBufferSize];
                serialPort.Write(Komunikacja.Zapytanie(0x50, this, (byte)(i+1), 0x15, (byte)combo.Items.IndexOf(combo.Text)), 0, 8);
               // serialPort.Read(buffer, 0, serialPort.ReadBufferSize);
                i++;
            }




            // Wyswietlenie drugiej zakładki
            tabControlCzujniki.SelectedIndex = 1;

            // Odblokowanie groupBoxów
            foreach(GroupBox box in czujniki)
            {
                box.Enabled = true;
            }

            buttonStart.Enabled = false;
            buttonStop.Enabled = true;

            progressBarDane.Value = 100;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            // Blokowanie groupBoxów
            foreach (GroupBox box in czujniki)
            {
                box.Enabled = false;
            }

            buttonStart.Enabled = true;
            buttonStop.Enabled = false;

            progressBarDane.Value = 0;
        }
    }
}
