using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MathsLib;

namespace CalculatorApp
{
    public class CylinderVolume : Maths
    {
        private double _height ;

        public double Height{get{return _height;} set{_height = value;}}
        internal double Volume {get;set;}
        public double CalculateVolume (){
            return CalculateCircleArea * _height;
        }
    }
}