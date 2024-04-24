using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeAreaVolume
{
    public class Cubes : Shape
    {
        public override double Area{get;set;}
        public override double Volume{get;set;}
        public new double Side{get;set;}
        public Cubes(double side){
            Side = side;
        }
        public override void CalculateArea(){
            Area = 6* Math.Pow(Side,2);
        }
        public override void CalculateVolume(){
            Volume = Math.Pow(Side,3);
        }
    }
}