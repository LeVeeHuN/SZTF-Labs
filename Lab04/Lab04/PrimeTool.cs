using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public class PrimeTool
    {
        int num;

        public PrimeTool(int number)
        {
            num = number;
        }

        public bool IsPrime()
        {
            if (num < 2) return false;
            int c = 0;
            for (int i = 2; i < num / 2 + 1; i++)
            {
                if (num % i == 0) c++;
            }
            if (c > 0) return false;
            return true;
        }
    }
}
