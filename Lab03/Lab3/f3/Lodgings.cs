using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.f3
{
    internal class Lodgings : Flat, IRent
    {
        protected int bookedMonths;

        public Lodgings(int area, int roomsCount, int unitPrice) : base(area, roomsCount, 0, unitPrice)
        {
            bookedMonths = 0;
        }

        public bool Book(int months)
        {
            return !IsBooked();
        }

        public decimal GetCost(int months)
        {
            return TotalValue() / 240 / InhabitantsCount;
        }

        public bool IsBooked()
        {
            return bookedMonths > 0;
        }

        public override bool MoveIn(int newInhabitants)
        {
            // Ha IsBooked
            // 1 szoba - 8 fo
            // 1 fo - 2nm
            // Novelni a lakok szamat
            if (IsBooked() && (roomsCount * 8) >= newInhabitants && (newInhabitants * 2 <= area))
            {
                inhabitantsCount += newInhabitants;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Lefoglalt hónapok száma: {bookedMonths}\n" + base.ToString();
        }
    }
}
