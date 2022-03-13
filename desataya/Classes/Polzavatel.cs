using System;
using System.Collections.Generic;
using System.Text;

namespace desataya.Classes
{
    class Polzavatel
    {
        public readonly int id_polzovatelya;
        public string fio;
        public DateTime data_registracii;
        public string telefon;

        public Polzavatel(int a, string b, DateTime c, string v)
        {
            id_polzovatelya = a;
            fio = b;
            data_registracii = c;
            telefon = v;
        }

        public string VzyatSamokat(int a)
        {
            return "Пользователь " + id_polzovatelya.ToString() + " по имени " + fio.ToString() +" взял самокат под номером " + a.ToString();
        }
    }
}
