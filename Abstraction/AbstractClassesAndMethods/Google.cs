using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClassesAndMethods
{
    public class Google : Employee
    {
        // Abstract property definition
        public override string Name { get { return _name; } set { _name = value; } }
        //Abstract method definition
        public override double Salary(int dates)
        {
            Amount = (double)dates*700;
            return Amount;
        }        
        public new string Display(){
            return _name+"goo";
        }
    }
}