using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_0318
{
    public class IncorrectOrientationException : DeliveryException
    {
        public IncorrectOrientationException(string msg, IDeliverable correspondingParcel) : base(msg, correspondingParcel) { }
    }
}
