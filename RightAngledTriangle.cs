using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class RightAngledTriangle : IShape
    {
        public double GetArea(double number1, double number2)
        {
            return (number1 * number2) / 2;
        }

        public double GetPerimeter(double number1, double number2)
        {
            return number1 + number2 + (Math.Sqrt(Math.Pow(number1, 2) + Math.Pow(number2, 2)));
        }
    }
}
