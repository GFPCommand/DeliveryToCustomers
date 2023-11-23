using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeliveryToCustomers.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void CircleCreateZeroValuesTest()
        {
            double r = 0;

            Circle circle;

            Assert.ThrowsException<ArgumentException>(() => circle = new(r));
        }

        [TestMethod]
        public void CircleCreateNegativeValuesTest()
        {
            double r = -5;

            Circle circle;

            Assert.ThrowsException<ArgumentException>(() => circle = new(r));
        }

        [TestMethod]
        public void CircleCreateNormalValuesTest()
        {
            double r = 5;

            Circle circle = new(r);

            Assert.IsNotNull(circle);
        }

        [TestMethod]
        public void SquareTest()
        {
            double r = 10;

            double expectedSquare = Math.Pow(r, 2) * Math.PI;

            Circle circle = new(r);

            Assert.AreEqual(expectedSquare, circle.Square());
        }
    }
}
