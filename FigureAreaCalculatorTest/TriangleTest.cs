using FigureAreaCalculator.Figures;
using NUnit.Framework;

namespace FigureAreaCalculatorTest
{
    public class TriangleTest
    {
        [TestCase(0, 1, 1)]
        [TestCase(1, 0, 1)]
        [TestCase(1, 1, 0)]
        public void ZeroEdgeTest(double a, double b, double c)
        {
            //arrange
            string expectedRes = "";
            if (a == 0)
                expectedRes = ($"Edge can't be equals or lower than 0: Edge A = 0");
            if (b == 0)
                expectedRes = ($"Edge can't be equals or lower than 0: Edge B = 0");
            if (c == 0)
                expectedRes = ($"Edge can't be equals or lower than 0: Edge C = 0");
            //act
            var exception = Assert.Catch<ArgumentException>(() => new Triangle(a, b, c));
            //assert
            Assert.IsTrue(exception.Message.Equals(expectedRes));
        }

        [TestCase(-1, 1, 1)]
        [TestCase(1, -1, 1)]
        [TestCase(1, 1, -1)]
        public void NegativeEdgeTest(double a, double b, double c)
        {
            //arrange
            string expectedRes = "";
            if (a == -1)
                expectedRes = ($"Edge can't be equals or lower than 0: Edge A = -1");
            if (b == -1)
                expectedRes = ($"Edge can't be equals or lower than 0: Edge B = -1");
            if (c == -1)
                expectedRes = ($"Edge can't be equals or lower than 0: Edge C = -1");
            //act
            var exception = Assert.Catch<ArgumentException>(() => new Triangle(a, b, c));
            //assert
            Assert.IsTrue(exception.Message.Equals(expectedRes));
        }

        [TestCase(3, 1, 1)]
        [TestCase(1, 3, 1)]
        [TestCase(1, 1, 3)]
        [Test]
        public void InitNotTriangleTest(double a, double b, double c)
        {
            //arrange
            var expectedRes = "The longest side of a triangle must be less than the sum of the other sides";
            //act
            var exception = Assert.Catch<ArgumentException>(() => new Triangle(a, b, c));
            //assert
            Assert.IsTrue(exception.Message.Equals(expectedRes));
        }

        [Test]
        public void InitTriangleTest()
        {
            //arrange
            double a = 3, b = 4, c = 5;
            //act
            var triangle = new Triangle(a, b, c);
            //assert 
            Assert.NotNull(triangle);
            Assert.IsTrue(triangle.EdgeA.Equals(a));
            Assert.IsTrue(triangle.EdgeB.Equals(b));
            Assert.IsTrue(triangle.EdgeC.Equals(c));
        }

        [Test]
        public void GetAreaTest()
        {
            //arrange
            double a = 3, b = 4, c = 5;
            double expectedRes = 6;
            var triangle = new Triangle(a, b, c);
            //act
            var triangleArea = triangle.GetArea();
            //assert 
            Assert.NotNull(triangleArea);
            Assert.IsTrue(triangleArea.Equals(expectedRes));
        }

        [TestCase(3, 3, 5, ExpectedResult = false)]
        [TestCase(3, 4, 5, ExpectedResult = true)]
        public bool IsRightTriangleTest(double a, double b, double c)
        {
            //arrange
            var triangle = new Triangle(a, b, c);
            //act
            var isRight = triangle.GetIsRightTriangle();
            //assert 
            return isRight;
        }
    }
}