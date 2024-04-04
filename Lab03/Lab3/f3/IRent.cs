using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.f3
{
    internal interface IRent
    {
        public decimal GetCost(int months);

        public bool IsBooked();

        public bool Book(int months);
    }
}
