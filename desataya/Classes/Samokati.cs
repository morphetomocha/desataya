using System;
using System.Collections.Generic;
using System.Text;

namespace desataya.Classes
{
    class Samokati
    {
        public readonly int id_samokata;
        public string firma;
        public string sostoyanie;
        public int id_tarifa { get; set; }
        public int id_rayona { get; set; }

        public Samokati(int a, string b, string c, int d, int v)
        {
            this.id_samokata = a;
            this.firma = b;
            this.sostoyanie = c;
            this.id_tarifa = d;
            this.id_rayona = v;
        }

        public override string ToString()
        {
            return "Я самокат " + id_samokata.ToString() + " от фирмы " + firma.ToString();
        }
    }
}
