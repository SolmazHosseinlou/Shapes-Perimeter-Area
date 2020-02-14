using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle : IShape
    {
        public uint GetArea(uint number1, uint number2)
        {
            return number1 * number2;
        }

        public uint GetPerimeter(uint number1, uint number2)
        {
            return (number1 + number2) * 2;
        }
    }
}
