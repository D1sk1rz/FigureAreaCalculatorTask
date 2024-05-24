using Microsoft.VisualBasic;
using System.Reflection.Metadata;

namespace FigureAreaCalculator.Figures
{
    public class Triangle : IFigure
    {
        /// <summary>
        /// Triangle
        /// </summary>
        /// <param name="A">Size of edge A</param>
        /// <param name="B">Size of edge B</param>
        /// <param name="C">Size of edge C</param>
        /// <exception cref="ArgumentException">Edge can't be equals or lower than 0, The longest side of a triangle must be less than the sum of the other sides</exception>
        public Triangle(double A, double B, double C)
        {
            if (A <= 0)
                throw new ArgumentException($"Edge can't be equals or lower than 0: Edge A = {A}");

            if (B <= 0)
                throw new ArgumentException($"Edge can't be equals or lower than 0: Edge B = {B}");

            if (C <= 0)
                throw new ArgumentException($"Edge can't be equals or lower than 0: Edge C = {C}");


            if (A+B <= C || B + C <= A || C + A <= B)
                throw new ArgumentException("The longest side of a triangle must be less than the sum of the other sides");

            EdgeA = A;
            EdgeB = B;
            EdgeC = C;
        }

        public double EdgeA { get; set; }
        public double EdgeB { get; set; }
        public double EdgeC { get; set; }
        /// <summary>
        /// Calculate is triangle right
        /// </summary>
        /// <returns></returns>
        public bool GetIsRightTriangle()
        {
            double maxEdge = EdgeA, b = EdgeB, c = EdgeC, tmp;
            if (b >= 0)
            {
                tmp = maxEdge;
                maxEdge = b;
                b = tmp;
            }
            if (c >= 0)
            {
                tmp = maxEdge;
                maxEdge = c;
                c = tmp;
            }

            return Math.Pow(maxEdge, 2) == (Math.Pow(b, 2) + Math.Pow(c, 2));
        }
        /// <summary>
        /// Calculate area of triangle from three edges
        /// </summary>
        /// <param name="a">Size of edge A</param>
        /// <param name="b">Size of edge B</param>
        /// <param name="c">Size of edge C</param>
        /// <returns>Area of triangle</returns>
        public double GetArea()
        {
            var halfOfPerimeter = (EdgeA + EdgeB + EdgeC) / 2d;

            return Math.Sqrt(halfOfPerimeter * (halfOfPerimeter - EdgeA) * (halfOfPerimeter - EdgeB) * (halfOfPerimeter - EdgeC));
        }
    }
}