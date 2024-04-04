using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.f2
{
    internal class PlasztikKartya : ITulajdon
    {
        string tulajdonos;
        public string Tulajdonos { get { return tulajdonos; } protected set { tulajdonos = value; } }

        public PlasztikKartya(string tulajdonos)
        {
            Tulajdonos = tulajdonos;
        }
    }
}
