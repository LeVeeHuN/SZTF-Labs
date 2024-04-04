using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_0318
{
    internal class NormalParcel : Parcel
    {
        private static Random rnd = new Random();

        public NormalParcel(int weight, string address) : base(weight, address)
        {
            ParcelAlignment = (Alignment) rnd.Next(0, Enum.GetNames(typeof(Alignment)).Length);
        }

        public override double CalculatePrice(bool fromLocker)
        {
            double price = 500 + Weight;
            if (fromLocker)
            {
                price -= 250;
            }
            return price;
        }
    }
}
