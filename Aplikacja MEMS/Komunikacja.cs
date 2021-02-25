using System;
using System.Collections.Generic;
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

        public static byte[] Zapytanie(byte komenda, byte czujnik, byte czynnosc, byte indeks)
        {
            byte[] zapytanie = new byte[2048];
            int dopelnienie = 0;

            zapytanie[0] = 0x32;
            zapytanie[1] = 0x01;
            zapytanie[2] = komenda;
            dopelnienie = 3;
            switch (komenda)
            {
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
                    }
                    break;

                case 0x08:
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
            for(int i =0; i< dlugosc; i++)
            {
                wartosc -= dane[i];
            }

            // Dopełnienie do 0x100
            wartosc += 0x01;

            return wartosc;
        }

    }
}
