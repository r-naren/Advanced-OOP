using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator
{
    public class CylinderCalculator : Calculator
    {
        public override double Area(double radius)
        {
            return 2 * Math.PI * radius;
        }
        public double Volume(double radius, double height)
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }
    }
}