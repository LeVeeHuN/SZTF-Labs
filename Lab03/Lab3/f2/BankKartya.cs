using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.f2
{
    internal class BankKartya : PlasztikKartya, IFizetoEszkoz
    {
        decimal egyenleg;

        public BankKartya(string tulajdonos, decimal egyenleg) : base(tulajdonos)
        {
            this.egyenleg = egyenleg;
        }

        public virtual bool Fizet(decimal osszeg)
        {
            if (osszeg > egyenleg) return false;
            egyenleg -= osszeg;
            return true;
        }
    }
}
