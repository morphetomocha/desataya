using System;
using System.Collections.Generic;
using System.Text;

namespace desataya.Classes
{
    class Rabotniki
    {
        public int id_rabotnika { get; set; }
        public string fio;
        public int stazh;
        public int id_dolzhnosti;

        public Rabotniki(int a, string b, int c, int v)
        {
            id_dolzhnosti = a;
            fio = b;
            stazh = c;
            id_dolzhnosti = v;
        }
    }
}
