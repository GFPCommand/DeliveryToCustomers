using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeliveryToCustomers.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TriangleCreateZeroValuesTest()
        {
            double sideA, sideB, sideC;

            sideA = 0;
            sideB = 0;
            sideC = 0;

            Triangle triangle;

            Assert.ThrowsException<ArgumentException>(() => triangle = new(sideA, sideB, sideC));
        }

        [TestMethod]
        public void TriangleCreateNegativeValuesTest()
        {
            double sideA, sideB, sideC;

            sideA = 3;
            sideB = 4;
            sideC = -5;

            Triangle triangle;

            Assert.ThrowsException<ArgumentException>(() => triangle = new(sideA, sideB, sideC));
        }

        [TestMethod]
        public void TriangleCreateNormalValuesTest()
        {
            double sideA, sideB, sideC;

            sideA = 3;
            sideB = 4;
            sideC = 5;

            Triangle triangle = new(sideA, sideB, sideC);

            Assert.IsNotNull(triangle);
        }

        [TestMethod]
        public void SquareTest()
        {
            double sideA, sideB, sideC;

            sideA = 3;
            sideB = 4;
            sideC = 5;

            double expectedSquare = 6.0;

            Triangle triangle = new(sideA, sideB, sideC);

            Assert.AreEqual(expectedSquare, triangle.Square());
        }

        [TestMethod]
        public void TriangleRightTypeTest()
        {
            double sideA, sideB, sideC;

            sideA = 3;
            sideB = 4;
            sideC = 5;

            string expectedTriangleType = "Right triangle";

            Triangle triangle = new(sideA, sideB, sideC);

            Assert.AreEqual(expectedTriangleType, triangle.TriangleType());
        }

        [TestMethod]
        public void TriangleObtuseTypeTest()
        {
            double sideA, sideB, sideC;

            sideA = 10;
            sideB = 5;
            sideC = 7;

            string expectedTriangleType = "Obtuse triangle";

            Triangle triangle = new(sideA, sideB, sideC);

            Assert.AreEqual(expectedTriangleType, triangle.TriangleType());
        }

        [TestMethod]
        public void TriangleAcuteTypeTest()
        {
            double sideA, sideB, sideC;

            sideA = 9;
            sideB = 10;
            sideC = 7;

            string expectedTriangleType = "Acute-angled triangle";

            Triangle triangle = new(sideA, sideB, sideC);

            Assert.AreEqual(expectedTriangleType, triangle.TriangleType());
        }
    }
}