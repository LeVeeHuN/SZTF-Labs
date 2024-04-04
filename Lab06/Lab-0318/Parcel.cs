using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_0318
{
    public abstract class Parcel : IDeliverable, IComparable
    {
        public Alignment ParcelAlignment { get; protected set; }
        public int Weight { get; protected set; }
        public string Address { get; protected set; }

        public Parcel(Alignment alignment, int weight, string address) : this(weight, address)
        {
            ParcelAlignment = alignment;
        }

        public Parcel(int weight, string address)
        {
            Weight = weight;
            Address = address;
        }

        public abstract double CalculatePrice(bool fromLocker);

        public override string ToString()
        {
            return $"Címzett:  {Address} / Elhelyezés:  {ParcelAlignment} / Tömeg:{Weight} g";
        }

        public int CompareTo(object? obj)
        {
            int val = (obj as IDeliverable).Weight;
            return Weight - val;
        }
    }
}
