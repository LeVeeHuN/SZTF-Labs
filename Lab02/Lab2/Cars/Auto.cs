using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Cars
{
    internal abstract class Auto
    {
        protected string rendszam;
        protected int tengelyTav;
        protected DateTime gyartasDatuma;
        protected int loero;

        public string Rendszam { get { return rendszam; } }
        public int TengelyTav { get { return tengelyTav; } }
        public DateTime GyartasDatum { get { return gyartasDatuma; } }
        public int Loero { get { return loero; } }

        public Auto(string rendszam, int tengelyTav, DateTime gyartasDatuma, int loero)
        {
            this.rendszam = rendszam;
            this.tengelyTav = tengelyTav;
            this.gyartasDatuma = gyartasDatuma;
            this.loero = loero;
        }

        public override string ToString()
        {
            return $"Típus: {GetType().Name}\nRendszam: {Rendszam}\nTengely táv: {TengelyTav}\nGyártás dátuma: {GyartasDatum.ToShortDateString()}\nLóerő: {Loero} LE\n";
        }
        public abstract double Fogyasztas();
    }
}
