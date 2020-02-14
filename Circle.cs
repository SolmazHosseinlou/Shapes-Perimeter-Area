using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle : IShape
    {
        public double GetArea(double number1, double number2)
        {
           number1 = Math.PI;
            return (number1) * (Math.Pow(number2, 2));
        }

        public double GetPerimeter(double number1, double number2)
        {
            number1 = 2 * Math.PI;
            return number1 * number2;
        }
    }
}
