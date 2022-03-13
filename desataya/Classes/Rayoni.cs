using System;
using System.Collections.Generic;
using System.Text;

namespace desataya.Classes
{
    class Rayoni
    {
        public int id_rayona { get; set; }
        public string naimenovanie;

        public Rayoni(int a, string b)
        {
            this.id_rayona = a;
            this.naimenovanie = b;
        }
    }
}
