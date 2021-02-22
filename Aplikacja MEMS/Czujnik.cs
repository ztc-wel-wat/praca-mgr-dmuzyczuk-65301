using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja_MEMS
{
    class Czujnik
    {
        private string nazwa;
        private string model;
        private bool wlaczony = false;

        public Czujnik(string n, string m)
        {
            nazwa = n;
            model = m;

        }

    }
}
