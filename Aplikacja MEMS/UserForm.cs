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
            wlaczWylacz.Add(buttonStop);
            wlaczWylacz.Add(cBoxPorty);

            ladowaniePaska = new ThreadStart(StartPaska);
            pasek = new Thread(ladowaniePaska);
            pasek.Start();

        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            BackgroundWorker bgW = new BackgroundWorker();
            // Tworzenie tablicy bajtów wyszukującej dostępnych urządzeń MEMS
            byte[] inicjalizacja = new byte[5];
            inicjalizacja[0] = 0x32;
            inicjalizacja[1] = 0x01;
            inicjalizacja[2] = 0x02;
            inicjalizacja[3] = 0xcb;
            inicjalizacja[4] = 0xf0;

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
                    serialPort.Write(inicjalizacja, 0, 5);

                    // Wysłanie zapytania
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
                    if(serialPort.IsOpen)
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
            if(ladowanie.progressBar.Value < 90)
            {
                Action<int> updateAction = new Action<int>((value) => ladowanie.progressBar.Value += 90 / portyCOM.Length);
                ladowanie.progressBar.Invoke(updateAction, 32);
            }
            else {
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
            

        }
    }
}
