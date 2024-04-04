using Lab_0318;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06Test
{
    public class FragileParcelTest
    {
        [Test]
        public void FromLockerExceptionTest()
        {
            FragileParcel fragileParcel = new FragileParcel(1, string.Empty, Alignment.Horizontal);
            Assert.Throws<DeliveryException>(() => fragileParcel.CalculatePrice(true));
        }

        [Test]
        public void IncorrectOrientationExceptionTest()
        {
            Assert.Throws<IncorrectOrientationException>(() => new FragileParcel(1, string.Empty, Alignment.Arbitrary));
        }
    }
}
