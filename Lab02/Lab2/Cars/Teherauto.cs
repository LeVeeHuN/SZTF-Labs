using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Cars
{
    internal sealed class Teherauto : Haszongepjarmu
    {
        int szallithatoUtasokSzama;
        int teherbiras;
        bool ponyvazhato;

        public int SzallithatoUtasokSzama { get { return szallithatoUtasokSzama; } }
        public int Teherbiras { get { return teherbiras; } }
        public bool Ponyvazhato { get { return ponyvazhato; } }

        public Teherauto(int szallithatoUtasokSzama, int teherbiras, bool ponyvazhato, double hasznossagiHanyados, string felhasznalasiTerulet, string rendszam, int tengelyTav, DateTime gyartasDatuma, int loero) : base(hasznossagiHanyados, felhasznalasiTerulet, rendszam, tengelyTav, gyartasDatuma, loero)
        {
            this.szallithatoUtasokSzama = szallithatoUtasokSzama;
            this.teherbiras = teherbiras;
            this.ponyvazhato = ponyvazhato;
        }

        public double Rakodas()
        {
            return Teherbiras / SzallithatoUtasokSzama;
        }

        public override double Fogyasztas()
        {
            if (Ponyvazhato) return Teherbiras * SzallithatoUtasokSzama;
            return Teherbiras * SzallithatoUtasokSzama % 4;
        }
    }
}
