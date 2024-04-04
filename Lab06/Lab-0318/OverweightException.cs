using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_0318
{
    public class OverweightException : Exception
    {
        public int Weight { get; private set; }

        public OverweightException(int weight)
        {
            Weight = weight;
        }
    }
}
