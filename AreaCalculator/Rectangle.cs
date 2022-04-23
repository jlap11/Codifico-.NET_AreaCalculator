using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Rectangle : Figure
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public override string ObtainResponse()
        {
            return "The area of the rectangle is " + CalculateArea().ToString() + ".";
        }

        public override double CalculateArea()
        {
            double calculated;

            calculated = Base * Height;

            return calculated;
        }
    }
}
