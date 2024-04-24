using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreaVolumeCalculator
{
    public class VolumeCalculator : AreaCalculator
    {
        public double Height {get;set;}
        public double Volume {get;set;}
        public VolumeCalculator(double radius, double height) : base(radius){
            Height = height;
        }
        public override void Calculate(){
            Volume = Math.PI * Math.Pow(Radius,2) * Height;
        }
        public override void Display(){
            Console.WriteLine($"Volume : {Volume}");
            
        }
    }
}