using System;
using System.Collections.Generic;
using System.Text;

namespace desataya.Classes
{
    class Prokat
    {
        public int id_samokata { get; set; }
        public int id_tarifa { get; set; }
        public int id_polzovatelya { get; set; }
        public string vzyat_adres;
        public string otdan_adres;

        public Prokat(int a, int b, int c, string d, string v)
        {
            id_samokata = a;
            id_tarifa = b;
            id_polzovatelya = c;
            vzyat_adres = d;
            otdan_adres = v;
        }
    }
}
