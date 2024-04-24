using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator
{
    public class CircleCalculator : Calculator
    {
        

        public sealed override double Area(double radius)
        {
            return Math.PI * radius*radius;
        }
       
    }
}