using Lab04;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab04Test
{
    [TestFixture]
    public class PalindromeToolTest
    {
        [Test]
        public void ISPalindromeDetectsPalindromes()
        {
            // Arrange
            Mock<IIOHelper> mock = new Mock<IIOHelper>();
            mock.SetupSequence(x => x.GetUserInput()).Returns("radar");
            PalindromeTool pt = new PalindromeTool(mock.Object);

            // Act
            bool result = pt.IsPalindrome();

            // Assert
            Assert.That(result, Is.True);
            mock.Verify(x => x.GetUserInput(), Times.Once);
        }

        [Test]
        public void ISPalindromeDetectsNonPalindromes()
        {
            // Arrange
            Mock<IIOHelper> mock = new Mock<IIOHelper>();
            mock.SetupSequence(x => x.GetUserInput()).Returns("kacsa");
            PalindromeTool pt = new PalindromeTool(mock.Object);

            // Act
            bool result = pt.IsPalindrome();

            // Assert
            Assert.That(result, Is.False);
        }
    }
}
