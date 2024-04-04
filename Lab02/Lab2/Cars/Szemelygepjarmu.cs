using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Cars
{
    internal sealed class Szemelygepjarmu : Auto
    {
        int ajtokSzama;
        int szallithatoUtasokSzama;

        public int AjtokSzama { get { return ajtokSzama; } }
        public int SzallithatoUtasokSzama { get { return szallithatoUtasokSzama; } }

        public Szemelygepjarmu(int ajtokSzama, int szallithatoUtasokSzama, string rendszam, int tengelyTav, DateTime gyartasDatuma, int loero) : base(rendszam, tengelyTav, gyartasDatuma, loero)
        {
            this.ajtokSzama = ajtokSzama;
            this.szallithatoUtasokSzama = szallithatoUtasokSzama;
        }

        public override double Fogyasztas()
        {
            return Loero * AjtokSzama;
        }
    }
}
