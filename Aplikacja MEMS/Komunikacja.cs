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
    class Komunikacja
    {
        static BackgroundWorker bgWorkOdbierz;
        static BackgroundWorker bgWorkWypisz;
        UserForm user;

        public Komunikacja(UserForm u)
        {
            user = u;
        }

        public static byte[] Zapytanie(byte komenda, byte czujnik, byte czynnosc, byte indeks, byte[] parametry)
        {
            byte[] zapytanie = new byte[2048];
            int dopelnienie = 0;

            zapytanie[0] = 0x32;
            zapytanie[1] = 0x01;
            zapytanie[2] = komenda;
            dopelnienie = 3;
            switch (komenda)
            {
                case 0x0C:
                    byte[] czas = ObecnyCzas();

                    for (int i = 0; i < 3; i++)
                    {
                        zapytanie[i + 3] = czas[i];
                    }

                    zapytanie[6] = 0x15;
                    zapytanie[7] = 0x02;
                    zapytanie[8] = 0x19;
                    zapytanie[9] = 0x04;
                    dopelnienie = 10;
                    break;

                case 0x02: // Poszukiwanie dostępnych urządzeń STM
                    dopelnienie = 3;
                    break;

                case 0x50: // Wykonaj...
                    zapytanie[3] = czynnosc;
                    zapytanie[4] = czujnik;
                    switch (czynnosc)
                    {
                        case 0x14:  // Podaj listę dostępnych czujników
                            dopelnienie = 5;
                            break;
                        case 0x15:  // Załaduj czujniki o indeksie...
                            zapytanie[5] = indeks;
                            dopelnienie = 6;
                            break;
                        case 0x07: // Ustaw ODR wybranego czujnika
                            zapytanie[5] = parametry[0];
                            zapytanie[6] = parametry[1];
                            zapytanie[7] = parametry[2];
                            zapytanie[8] = parametry[3];
                            dopelnienie = 9;
                            break;
                        case 0x05: // Ustaw skalę wybranego czujnika
                            zapytanie[5] = parametry[0];
                            zapytanie[6] = parametry[1];
                            zapytanie[7] = zapytanie[8] = 0x00;
                            dopelnienie = 9;
                            break;
                    }
                    break;

                case 0x08: // Zmien stan czujnika
                    zapytanie[3] = czujnik;
                    zapytanie[4] = 0x00;
                    zapytanie[5] = 0x00;
                    zapytanie[6] = 0x00;
                    zapytanie[7] = 0xF4;
                    zapytanie[8] = 0x01;
                    zapytanie[9] = 0x00;
                    zapytanie[10] = 0x00;
                    dopelnienie = 11;
                    break;
            }

            // Dodawanie sumy kontrolnej
            zapytanie[dopelnienie] = SumaKontrolna(zapytanie, dopelnienie);
            zapytanie[dopelnienie + 1] = 0xf0;

            // Wstawianie danych do tablicy zwrotnej
            byte[] zwroc = new byte[dopelnienie + 2];
            Array.Copy(zapytanie, zwroc, dopelnienie + 2);

            return zwroc;
        }

        public static byte[] OdbierzListyCzujnikow(byte[] dane, SerialPort port, ProgressBar pb)
        {
            int licznik = 0;
            byte[] odp = new byte[port.ReadBufferSize];

            // Wyslanie zapytania o dostępne czujniki
            port.Write(dane, 0, 7);
            Thread.Sleep(100); // Uśpienie wątku, aby płytka zdążyła odpowiedzieć
            // Odebranie listy czujników (w bajtach)
            licznik = port.Read(odp, 0, port.ReadBufferSize);

            // Przekopiowanie do tablicy o dopasowanym rozmiarze
            byte[] odpowiedz = new byte[licznik];
            Array.Copy(odp, odpowiedz, licznik);

            pb.Value += 10;

            return odpowiedz;
        }

        private static byte SumaKontrolna(byte[] dane, int dlugosc)
        {
            // Obliczanie sumy kontrolnej (przedostatni bajt ramki)
            byte wartosc = 0xFF;
            for (int i = 0; i < dlugosc; i++)
            {
                wartosc -= dane[i];
            }

            // Dopełnienie do 0x100
            wartosc += 0x01;

            return wartosc;
        }

        private static byte[] ObecnyCzas()
        {
            byte[] czas = new byte[3];

            DateTime obecnyCzas = DateTime.Now;
            czas[0] = (byte)obecnyCzas.Hour;
            czas[1] = (byte)obecnyCzas.Minute;
            czas[2] = (byte)obecnyCzas.Second;

            return czas;
        }

        public void Odbior(SerialPort port)
        {
            bgWorkOdbierz = new BackgroundWorker();
            bgWorkOdbierz.WorkerSupportsCancellation = true;
            bgWorkOdbierz.DoWork += new System.ComponentModel.DoWorkEventHandler(bgWorkOdbierz_DoWork);
            bgWorkOdbierz.RunWorkerAsync(argument: port);
        }

        public void StopOdbior()
        {
            if(bgWorkOdbierz.IsBusy)
            bgWorkOdbierz.CancelAsync();
        }
        private void bgWorkOdbierz_DoWork(object sender, DoWorkEventArgs e)
        {
            SerialPort port = (SerialPort)e.Argument;
            byte[] dane = new byte[4096];
            string doWyswietlenia = string.Empty;

            while (true)
            {
                try
                {
                    int liczbaBajtow = port.Read(dane, 0, 4096);
                    byte[] daneOdebrane = new byte[liczbaBajtow];
                    Array.Copy(dane, daneOdebrane, liczbaBajtow);

                    foreach (byte b in daneOdebrane)
                    {
                        doWyswietlenia += b.ToString();
                    }

                    user.WyswietlDane(doWyswietlenia);
                }
                catch (Exception exc) { }
            }
        }

    }
}
