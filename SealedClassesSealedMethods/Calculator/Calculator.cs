using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator
{
    public abstract class Calculator
    {
       
        public abstract double Area(double radius);
        public double Volume(double radius){
            return 0;
        }
    }
}