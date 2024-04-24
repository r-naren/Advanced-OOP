using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreaVolumeCalculator
{
    public class AreaCalculator
    {
        public double Radius {get;set;}
        public double Area{get;set;}
        public AreaCalculator(double radius){
            Radius = radius;
        }
        public virtual void Calculate(){
            Area = Math.PI * Math.Pow(Radius,2);
        }
        public virtual void Display(){
            Console.WriteLine($"Area : {Area}");
            
        }
    }
}