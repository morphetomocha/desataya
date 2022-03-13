using System;
using System.Collections.Generic;
using System.Text;

namespace desataya.Classes
{
    class Tarif
    {
        public readonly int id_tarifa;
        public string naimenovanie;
        public int skidka;

        public Tarif(int a, string b, int c)
        {
            id_tarifa = a;
            naimenovanie = b;
            skidka = c;
        }
    }
}
