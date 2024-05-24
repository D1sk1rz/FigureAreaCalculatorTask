using FigureAreaCalculator.Figures;
using NUnit.Framework;

namespace FigureAreaCalculatorTest
{
    public class CircleTest
    {
        [Test]
        public void ZeroRadiusTest()
        {
            //arrange
            var radius = 0;
            var expectedRes = "Radius can't be equals or lower than 0: Radius = 0";
            //act
            var exception = Assert.Catch<ArgumentException>(() => new Circle(radius));
            //assert
            Assert.IsTrue(exception.Message.Equals(expectedRes));
        }

        [Test]
        public void NegativeRadiusTest()
        {
            //arrange
            var radius = -1;
            var expectedRes = "Radius can't be equals or lower than 0: Radius = -1";
            //act
            var exception = Assert.Catch<ArgumentException>(() => new Circle(radius));
            //assert
            Assert.IsTrue(exception.Message.Equals(expectedRes));
        }

        [Test]
        public void GetAreaTest()
        {
            //arrange
            var radius = 5;
            var circle = new Circle(radius);
            var expectedRes = Math.PI * Math.Pow(radius, 2d);
            //act
            var circleArea = circle.GetArea();
            //assert
            Assert.NotNull(circleArea);
            Assert.IsTrue(circleArea.Equals(expectedRes));
        }
    }
}