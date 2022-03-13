using System;
using System.Collections.Generic;
using System.Text;

namespace desataya.Classes
{
    class Razpolozenie
    {
        public int id_samokata { get; set; }
        public int id_rayona { get; set; }
        public string adres;

        public Razpolozenie(int a, int b, string c)
        {
            id_samokata = a;
            id_rayona = b;
            adres = c;
        }
    }
}
