using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Cars
{
    internal sealed class Sportauto : Auto
    {
        private static Random rnd = new Random();

        int nyomatek;
        int szallithatoUtasokSzama;
        double rajsagiRata;
        bool potkerekVan;
        bool vontathato;
        bool ultetveVan;

        public int Nyomatek { get { return nyomatek; } }
        public int SzallithatoUtasokSzama { get { return szallithatoUtasokSzama; } }
        public double RajsagiRata
        {
            get { return rajsagiRata; }
            private set
            {
                if (value >= 0 && value <= 1) rajsagiRata = value;
            }
        }
        public bool PotkerekVan { get { return potkerekVan; } }
        public bool Vontathato { get { return vontathato; } }
        public bool UltetveVan { get { return ultetveVan; } }

        public Sportauto(int nyomatek, int szallithatoUtasokSzama, double rajsagiRata, bool potkerekVan, bool vontathato, bool ultetveVan, string rendszam, int tengelyTav, DateTime gyartasDatuma, int loero) : base(rendszam, tengelyTav, gyartasDatuma, loero)
        {
            this.nyomatek = nyomatek;
            this.szallithatoUtasokSzama = szallithatoUtasokSzama;
            RajsagiRata = rajsagiRata;
            this.potkerekVan = potkerekVan;
            this.vontathato = vontathato;
            this.ultetveVan = ultetveVan;
        }

        public override double Fogyasztas()
        {
            return 999 * RajsagiRata * Nyomatek;
        }

        public bool MegengedhetemEMagamnak()
        {
            if (rnd.Next(1, 101) >= 95) return false;
            return true;
        }
    }
}
