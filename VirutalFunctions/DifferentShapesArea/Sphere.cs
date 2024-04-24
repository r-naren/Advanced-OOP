using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DifferentShapesArea
{
    public class Sphere : Dimention
    {
        public double Radius { get; set; }
        public new double Area { get; set; }
        public Sphere(double radius)
        {
            Radius = radius;
        }
        public override void Calculate()
        {
            Area = 4 * Math.PI * Math.Pow(Radius, 2);
        }
        public override void DisplayArea()
        {
            Console.WriteLine($"Sphere Area : {Area}");

        }
    }
}