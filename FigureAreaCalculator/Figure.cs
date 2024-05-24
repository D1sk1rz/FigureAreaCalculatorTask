using FigureAreaCalculator.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaCalculator
{
    public class Figure : IFigure
    {
        /// <summary>
        /// Calculate area of circle from radius
        /// </summary>
        /// <param name="radius">Radius</param>
        /// <returns>Area of circle</returns>
        public static double GetArea(double radius)
        {
            var circle = new Circle(radius);

            return circle.GetArea();
        }
        /// <summary>
        /// Calculate area of triangle from three edges
        /// </summary>
        /// <param name="a">Size of edge A</param>
        /// <param name="b">Size of edge B</param>
        /// <param name="c">Size of edge C</param>
        /// <returns>Area of triangle</returns>
        public static double GetArea(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);

            return triangle.GetArea();
        }

        public double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
