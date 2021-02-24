using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja_MEMS
{
    class Czujnik
    {
        private string nazwa;
        private string model;
        private bool wlaczony = false;
        GroupBox informacje;

        public Czujnik(string n, string m, GroupBox i)
        {
            nazwa = n;
            model = m;
            informacje = i;

            informacje.Controls[0].Text = "Nazwa czujnika: " + model;
        }


    }
}
