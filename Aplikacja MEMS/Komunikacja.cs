using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplikacja_MEMS
{
    class Komunikacja
    {

        public static byte[] Zapytanie(byte komenda, UserForm panel, byte czujnik)
        {
            byte[] zapytanie = new byte[panel.serialPort.WriteBufferSize];
            int dopelnienie = 0;

            zapytanie[0] = 0x32;
            zapytanie[1] = 0x01;
            zapytanie[2] = komenda;

            switch (komenda)
            {
                case 0x02: // Poszukiwanie dostępnych urządzeń STM
                    dopelnienie = 3;
                    break;

                case 0x50: // Podaj liste dostępnych czujników...
                            zapytanie[3] = 0x14;
                            zapytanie[4] = czujnik;
                            dopelnienie = 5;
                    break;


            }

            zapytanie[dopelnienie] = SumaKontrolna(zapytanie, dopelnienie);
            zapytanie[dopelnienie + 1] = 0xf0;

            return zapytanie;
        }
        
        public static byte[] OdbierzListyCzujnikow(byte[] dane, UserForm panel)
        {
            int licznik = 0;
            byte[] odp = new byte[panel.serialPort.ReadBufferSize];

            // Wyslanie zapytania o dostępne czujniki
            panel.serialPort.Write(dane, 0, 7);
            Thread.Sleep(100); // Uśpienie wątku, aby płytka zdążyła odpowiedzieć
            // Odebranie listy czujników (w bajtach)
            licznik = panel.serialPort.Read(odp, 0, panel.serialPort.ReadBufferSize);

            // Przekopiowanie do tablicy o dopasowanym rozmiarze
            byte[] odpowiedz = new byte[licznik];
            Array.Copy(odp, odpowiedz, licznik);

            panel.progressBarCOM.Value += 10;

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
