using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja_MEMS.Forms
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            rTBoxAboutData.AppendText("Wersja programu: \n"
                + "Data ostatniej aktualizacji: \n"
                + "Autor: sierż. pchor. inż. Dawid MUZYCZUK");

            rTBoxAbout.AppendText("        Aplikacja  MEMS  czujnika  IKS01A2  jest  oprogramowaniem  komputerowym  zaprojektowanym   w  ramach   pracy   magisterskiej   pt.  \" Aplikacja  do  współpracy      z czujnikami w systemach wbudowanych i analizy zarejestrowanych danych pomiarowych\". \n" +
                "          Oprogramowanie  to  umożliwia komunikajcę z czujnikami otoczenia,  zaprojektowanych  w  oparciu  o  protokół komunikacyjny firmy STMicroelectronics (Unicleo).  Poprzez  aplikację możliwe jest wyświetlanie  w  czasie  rzeczywistym obecnych wyników pomiarów wysyłanych przez płytkę, zapisywanie ich, a także wyświetlanie danych z zapisanych wcześniej plików. Dodatkowo możliwe jest rysowanie wykresów w oparciu o otrzymywane wyniki pomiarów.\n" +
                "       Aplikacja została tak zaprojektowana, aby w sposób jak najefektywniejszy przetwarzać dane z naciskiem na obsługę czasu rzeczywistego.");
        }
    }
}
