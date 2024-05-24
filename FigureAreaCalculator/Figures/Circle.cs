using Microsoft.VisualBasic;

namespace FigureAreaCalculator.Figures
{
    public class Circle : IFigure
    {
        /// <summary>
        /// Circle
        /// </summary>
        /// <param name="radius">Radius of circle</param>
        /// <exception cref="ArgumentException">Radius can't be equals or lower than 0</exception>
        public Circle(double radius) 
        {
            if (radius <= 0)
                throw new ArgumentException($"Radius can't be equals or lower than 0: Radius = {radius}");
            Radius = radius;
        }

        public double Radius { get; set; }

        /// <summary>
        /// Calculate area of circle from radius
        /// </summary>
        /// <param name="radius">Radius</param>
        /// <returns>Area of circle</returns>
        public double GetArea()
        {

            return Math.PI * Math.Pow(Radius, 2d);
        }
    }
}