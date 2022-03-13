using System;
using System.Collections.Generic;
using System.Text;

namespace desataya.Classes
{
    class Mastera
    {
        public int id_rabotnika;
        public int id_samokata;
        public string vid_rabot;
        public DateTime data_rabot;

        public Mastera(int a, int b, string c, DateTime v)
        {
            id_rabotnika = a;
            id_samokata = b;
            vid_rabot = c;
            data_rabot = v;
        }
    }
}
