using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.f3
{
    internal class FamilyApartment : Flat
    {
        protected int childrenCount;

        public FamilyApartment(int area, int roomsCount, int unitPrice) : base(area, roomsCount, 0, unitPrice)
        {
            childrenCount = 0;
        }

        public bool ChildIsBorn()
        {
            if (inhabitantsCount - childrenCount >= 2)
            {
                childrenCount++;
                inhabitantsCount++;
                return true;
            }
            return false;
        }

        public override bool MoveIn(int newInhabitants)
        {
            // 1 szoba - 2 fo max
            // 1 fo - 10nm
            //  1 gyerek - 5nm
            // Uj bekoltozok felnottek

            if (inhabitantsCount + newInhabitants <= roomsCount * 2 && (inhabitantsCount - childrenCount + newInhabitants) * 10 + childrenCount * 5 <= area)
            {
                inhabitantsCount += newInhabitants;
                return true;
            }
            return false;
        }

    }
}
