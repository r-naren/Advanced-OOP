using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DifferentShapesArea
{
    public class Rectangle : Dimention
    {
        public double Length {get;set;}
        public double Height {get;set;}
        public new double Area {get;set;}
        public Rectangle (double length, double height){
            Length = length;
            Height = height;
        }
        public override void Calculate(){
            Area = Length*Height;
        }
        public override void DisplayArea(){
            Console.WriteLine($"Rectangle Area : {Area}");
            
        }       
    }
}