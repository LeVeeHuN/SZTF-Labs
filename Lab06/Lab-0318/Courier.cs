using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_0318
{
    internal class Courier
    {
        private IDeliverable[] packages;
        private int nextIndex = 0;
        public int AllWeight
        {
            get
            {
                int w = 0;
                for (int i = 0; i < nextIndex; i++)
                {
                    w += packages[i].Weight;
                }
                return w;
            }
        }

        public Courier(int maxPackage)
        {
            packages = new IDeliverable[maxPackage];
        }

        public void PickUpItem(IDeliverable item)
        {
            if (nextIndex < packages.Length)
            {
                packages[nextIndex] = item;
                nextIndex++;
            }
            else
            {
                throw new DeliveryException("Nincs több hely a futárnál!", item);
            }
        }

        public IDeliverable[] FragilesSorted()
        {
            IDeliverable[] fragileArray = new IDeliverable[0];
            for (int i = 0; i < nextIndex; ++i)
            {
                if (packages[i] is FragileParcel)
                {
                    IDeliverable[] newFragileArray = new IDeliverable[fragileArray.Length + 1];
                    for (int j = 0; j < fragileArray.Length; j++)
                    {
                        newFragileArray[j] = fragileArray[j];
                    }
                    newFragileArray[fragileArray.Length] = packages[i];
                    fragileArray = newFragileArray;
                }
            }
            Array.Sort(fragileArray);
            return fragileArray;
        }

    }
}
