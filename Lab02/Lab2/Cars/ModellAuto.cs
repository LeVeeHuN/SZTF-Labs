using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Cars
{
    internal class ModellAuto : Auto
    {
        protected int suly;
        protected int osszeszerelesNehezsege;

        public int Suly { get { return suly; } }
        public int OsszeszerelesNehezsege { get { return osszeszerelesNehezsege;} protected set {
            if (value >= 0 && value <= 9) suly = value;
            } }

        public ModellAuto(int suly, int osszeszerelesNehezsege, string rendszam, int tengelyTav, DateTime gyartasDatuma, int loero) : base(rendszam, tengelyTav, gyartasDatuma, loero)
        {
            this.suly = suly;
            OsszeszerelesNehezsege = osszeszerelesNehezsege;
        }

        public override double Fogyasztas()
        {
            return (loero / 100 * suly) * osszeszerelesNehezsege;
        }
    }
}
