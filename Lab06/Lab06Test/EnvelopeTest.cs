using Lab_0318;

// 3 steps
// - Arrange
// - Act
// - Assert

namespace Lab06Test
{
    public class EnvelopeTest
    {
        [TestCase(1)]
        [TestCase(25)]
        [TestCase(50)]
        public void NotFromLockerLessThan50(int weight)
        {
            // Arrange
            Envelope envelope = new Envelope(weight, string.Empty, string.Empty);

            // Act
            double result = envelope.CalculatePrice(false);

            // Assert
            Assert.That(result, Is.EqualTo(200));
        }

        [TestCase(51)]
        [TestCase(250)]
        [TestCase(500)]
        public void NotFromLockerBetween51And500(int weight)
        {
            Envelope envelope = new Envelope(weight, string.Empty, string.Empty);
            double result = envelope.CalculatePrice(false);
            Assert.That(result, Is.EqualTo(400));
        }

        [TestCase(501)]
        [TestCase(750)]
        [TestCase(1000)]
        [TestCase(1500)]
        [TestCase(2000)]
        public void NotFromLockerBetween501And2000(int weight)
        {
            Envelope envelope = new Envelope(weight, string.Empty, string.Empty);
            double result = envelope.CalculatePrice(false);
            Assert.That(result, Is.EqualTo(1000));
        }

        [TestCase(2001)]
        [TestCase(10_000_000)]
        public void NotFromLockerMoreThan2000(int weight)
        {
            Envelope envelope = new Envelope(weight, string.Empty, string.Empty);
            Assert.Throws<OverweightException>(() => envelope.CalculatePrice(false));
        }


        [TestCase(1)]
        [TestCase(25)]
        [TestCase(50)]
        public void FromLockerLessThan50(int weight)
        {
            // Arrange
            Envelope envelope = new Envelope(weight, string.Empty, string.Empty);

            // Act
            double result = envelope.CalculatePrice(true);

            // Assert
            Assert.That(result, Is.EqualTo(200));
        }

        [TestCase(51)]
        [TestCase(250)]
        [TestCase(500)]
        public void FromLockerBetween51And500(int weight)
        {
            Envelope envelope = new Envelope(weight, string.Empty, string.Empty);
            double result = envelope.CalculatePrice(true);
            Assert.That(result, Is.EqualTo(400));
        }

        [TestCase(501)]
        [TestCase(750)]
        [TestCase(1000)]
        [TestCase(1500)]
        [TestCase(2000)]
        public void FromLockerBetween501And2000(int weight)
        {
            Envelope envelope = new Envelope(weight, string.Empty, string.Empty);
            double result = envelope.CalculatePrice(true);
            Assert.That(result, Is.EqualTo(1000));
        }

        [TestCase(2001)]
        [TestCase(10_000_000)]
        public void FromLockerMoreThan2000(int weight)
        {
            Envelope envelope = new Envelope(weight, string.Empty, string.Empty);
            Assert.Throws<OverweightException>(() => envelope.CalculatePrice(true));
        }
    }
}
