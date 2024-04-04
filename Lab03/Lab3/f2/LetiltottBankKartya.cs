using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.f2
{
    internal class LetiltottBankKartya : BankKartya, IElveszett
    {
        protected DateTime eltunes;
        public DateTime EltunesIdeje { get { return eltunes; } protected set { eltunes = value; } }

        public LetiltottBankKartya(DateTime eltunes, string tulajdonos, decimal egyenleg) : base(tulajdonos, egyenleg)
        {
            EltunesIdeje = eltunes;
        }

        public override bool Fizet(decimal osszeg)
        {
            return false;
        }

    }
}
