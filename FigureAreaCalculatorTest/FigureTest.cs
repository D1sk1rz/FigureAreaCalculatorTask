using FigureAreaCalculator;
using FigureAreaCalculator.Figures;
using NUnit.Framework;

namespace FigureAreaCalculatorTest
{
    public class FigureTests
    {
        [Test]
        public void GetCircleFigureArea()
        {
            //arrange
            var radius = 5;
            var expectedRes = Math.PI * Math.Pow(radius, 2d);
            //act
            var circleArea = Figure.GetArea(radius);
            //assert
            Assert.NotNull(circleArea);
            Assert.IsTrue(circleArea.Equals(expectedRes));
        }

        [Test]
        public void GetTriangleFigureArea()
        {
            //arrange
            double a = 3, b = 4, c = 5;
            double expectedRes = 6;
            //act
            var triangleArea = Figure.GetArea(a, b, c);
            //assert 
            Assert.NotNull(triangleArea);
            Assert.IsTrue(triangleArea.Equals(expectedRes));
        }
    }
}