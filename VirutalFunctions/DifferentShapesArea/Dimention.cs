using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DifferentShapesArea
{
    public class Dimention
    {
        public double Value1 { get; set; }
        public double Value2 { get; set; }
        public double Area { get; set; }
        //Default constructor
        public Dimention()
        {

        }

        public Dimention(double value1, double value2)
        {
            Value1 = value1;
            Value2 = value2;
        }
        public virtual void Calculate()
        {
            Area = Value1 * Value2;
        }
        public virtual void DisplayArea()
        {
            Console.WriteLine($"Area : {Area}");

        }
    }
}