using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.f2
{
    internal class Hitel : IFizetoEszkoz
    {
        decimal hitelosszeg;

        public Hitel(decimal hitelosszeg)
        {
            this.hitelosszeg = hitelosszeg;
        }
        public bool Fizet(decimal osszeg)
        {
            if (osszeg > hitelosszeg) return false;
            hitelosszeg -= osszeg;
            return true;
        }
    }
}
