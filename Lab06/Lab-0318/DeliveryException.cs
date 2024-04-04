using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_0318
{
    public class DeliveryException : Exception
    {
        public IDeliverable correspondingParcel { get; protected set; }
        public DeliveryException(string msg, IDeliverable correspondingParcel) : base(msg)
        {
            this.correspondingParcel = correspondingParcel;
        }
    }
}
