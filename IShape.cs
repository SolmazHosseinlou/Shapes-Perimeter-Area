﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    interface IShape
    {
        double GetPerimeter(double number1, double number2);
        double GetArea(double number1, double number2);
    }
}
