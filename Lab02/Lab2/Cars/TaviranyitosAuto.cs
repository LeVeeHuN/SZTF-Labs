using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Cars
{
    enum KommunikacioFajtaja
    {
        BT,
        WIFI,
        RADIO
    }

    internal sealed class TaviranyitosAuto : ModellAuto
    {
        private static Random rnd = new Random();


        KommunikacioFajtaja kommunikacio;
        int elemToltottsege;

        public KommunikacioFajtaja KommunikacioFajtaja { get { return kommunikacio; } }
        public int ElemToltottsege { get { return elemToltottsege; } private set {
            if (value >= 0 && value <= 100) elemToltottsege = value;
            } }

        public TaviranyitosAuto(KommunikacioFajtaja kommunikacio, int elemToltottsege, int suly, string rendszam, int tengelyTav, DateTime gyartasDatuma, int loero) : base(suly, 1, rendszam, tengelyTav, gyartasDatuma, loero)
        {
            this.kommunikacio = kommunikacio;
            ElemToltottsege = elemToltottsege;
        }

        public void Elemcsere()
        {
            if (rnd.Next(1, 101) <= 80) ElemToltottsege = 100;
        }

        public override double Fogyasztas()
        {
            return 0;
        }
    }
}
