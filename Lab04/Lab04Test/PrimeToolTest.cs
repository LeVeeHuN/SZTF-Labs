using Lab04;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04Test
{
    [TestFixture]
    internal class PrimeToolTest
    {
        [TestCase(2, true)]
        [TestCase(3, true)]
        [TestCase(5, true)]
        [TestCase(7, true)]
        [TestCase(11, true)]
        [TestCase(293, true)]
        public void IsPrimeToolDetectsPrimes(int number, bool expected)
        {
            // Arrange
            PrimeTool pt = new PrimeTool(number);

            // Act
            bool result = pt.IsPrime();

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(1, false)]
        [TestCase(9, false)]
        [TestCase(15, false)]
        [TestCase(73865295, false)]
        public void IsPrimeToolDetectsOddNonPrimes(int number, bool expected)
        {
            // Arrange
            int numToCheck = 9;
            PrimeTool pt = new PrimeTool(number);

            // Act
            bool result = pt.IsPrime();

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(4, false)]
        [TestCase(6, false)]
        [TestCase(76, false)]
        [TestCase(143524252, false)]
        public void IsPrimeToolDetectsEvenNonPrimes(int number, bool expected)
        {
            // Arrange
            PrimeTool pt = new PrimeTool(number);

            // Act
            bool result = pt.IsPrime();

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(0, false)]
        public void IsPrimeToolZeroIsNotAPrime(int number, bool expected)
        {
            // Arrange
            PrimeTool pt = new PrimeTool(number);

            // Act
            bool result = pt.IsPrime();

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(-1, false)]
        [TestCase(-100, false)]
        [TestCase(-11000, false)]
        public void IsPrimeToolHandlesNegativesAsNotPrimes(int number, bool expected)
        {
            // Arrange
            PrimeTool pt = new PrimeTool(number);

            // Act
            bool result = pt.IsPrime();

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
