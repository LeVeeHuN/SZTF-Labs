using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.f3
{
    internal abstract class Flat : IRealEstate
    {
        protected int area;
        protected int roomsCount;
        protected int inhabitantsCount;
        protected int unitPrice;

        public int InhabitantsCount { get { return inhabitantsCount; } }

        public Flat(int area, int roomsCount, int inhabitantsCount, int unitPrice)
        {
            this.area = area;
            this.roomsCount = roomsCount;
            this.inhabitantsCount = inhabitantsCount;
            this.unitPrice = unitPrice;
        }

        public abstract bool MoveIn(int newInhabitants);

        public int TotalValue()
        {
            return area * unitPrice;
        }

        public override string ToString()
        {
            return $"Lakok szama: {inhabitantsCount}\nSzobak szama: {roomsCount}\nTerulet: {area} nm\nNégyzetméternyi ár: {unitPrice}";
        }
    }
}
