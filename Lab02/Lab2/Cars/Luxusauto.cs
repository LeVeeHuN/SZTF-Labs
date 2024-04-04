using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Cars
{
    internal sealed class Luxusauto : Auto
    {
        int ar;
        bool elektromos;

        public int Ar { get { return ar; } }
        public bool Elektromos { get { return elektromos; } }

        public Luxusauto(int ar, bool elektromos, string rendszam, int tengelyTav, DateTime gyartasDatuma, int loero) : base(rendszam, tengelyTav, gyartasDatuma, loero)
        {
            this.ar = ar;
            this.elektromos = elektromos;
        }

        public bool MegengedhetemEMagamnak(string foglalkozas)
        {
            if (foglalkozas.ToLower().Equals("mérnökinformatikus") || foglalkozas.ToLower().Equals("mernokinformatikus")) return true;
            return false;
        }

        public override double Fogyasztas()
        {
            if (Elektromos) return 0;
            return Loero * 2;
        }
    }
}
