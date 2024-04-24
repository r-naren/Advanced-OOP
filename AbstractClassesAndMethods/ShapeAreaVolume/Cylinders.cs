using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeAreaVolume
{
    public class Cylinders : Shape
    {
        public override double Area{get;set;}
        public override double Volume{get;set;}
        public new double Radius{get;set;}
        public new double Height{get;set;}
        public Cylinders(double radius, double height){
            Radius = radius;
            Height = height;
        }
        public override void CalculateArea(){
            Area = 2 * Math.PI * Radius *(Radius + Height);
        }
        public override void CalculateVolume(){
            Volume = Math.PI * Math.Pow(Radius,2) * Height; 
        }
    }
}