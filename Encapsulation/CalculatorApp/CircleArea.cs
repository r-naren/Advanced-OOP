using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MathsLib;

namespace CalculatorApp
{
    public class CircleArea : Maths
    {
        protected double radius;
        public  double Radius{get{return radius;}set{radius = value;}}
        internal double Area {get;set;}
        double CalculateCircleArea() {
            return PI*raddius * radius;
        }
    }
}