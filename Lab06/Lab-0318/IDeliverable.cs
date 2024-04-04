using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_0318
{
    public interface IDeliverable
    {
        public int Weight { get; }
        public string Address { get; }

        public double CalculatePrice(bool fromLocker);
    }
}
