using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaCalculator
{
    internal interface IFigure
    {
        /// <summary>
        /// Calculates area of figure
        /// </summary>
        /// <returns>Area of figure</returns>
        public abstract double GetArea();
    }
}
