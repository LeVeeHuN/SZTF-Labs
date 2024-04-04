using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Cars
{
    internal abstract class Haszongepjarmu : Auto
    {
        protected double hasznossagiHanyados;
        protected string felhasznalasiTerulet;

        public double HasznossagiHanyados { get { return hasznossagiHanyados; } protected set
            {
                if (value <= 2 && value >= 0) hasznossagiHanyados = value;
            } }

        public string FelhasznalasiTerulet { get { return felhasznalasiTerulet; } }

        public Haszongepjarmu(double hasznossagiHanyados, string felhasznalasiTerulet, string rendszam, int tengelyTav, DateTime gyartasDatuma, int loero) : base(rendszam, tengelyTav, gyartasDatuma, loero)
        {
            HasznossagiHanyados = hasznossagiHanyados;
            this.felhasznalasiTerulet = felhasznalasiTerulet;
        }
    }
}
