﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle : IShape
    {
        public double GetArea(double number1,double number2)
        {
            return number1 * number2;
        }

        public double GetPerimeter(double number1, double number2)
        {
            return (number1 + number2) * 2;
        }
    }
}
