using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_0318
{
    public class FragileParcel : Parcel
    {
        public FragileParcel(int weight, string address, Alignment parcelAlignment) : base(parcelAlignment, weight, address)
        {
            if (parcelAlignment == Alignment.Arbitrary)
            {
                throw new IncorrectOrientationException("A törékeny csomag elhelyezés módja tetszőleges!", this);
            }
        }

        public override double CalculatePrice(bool fromLocker)
        {
            if (fromLocker)
            {
                throw new DeliveryException("A törékeny csomag automatából lett feladva!", this);
            }
            double price = 1000 + Weight * 2;
            return price;
        }
    }
}
