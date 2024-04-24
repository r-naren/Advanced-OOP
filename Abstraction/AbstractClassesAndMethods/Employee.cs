using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClassesAndMethods
{
    public abstract class Employee  //abstract class
    {
        // abstract class - partial abstraction.
        // It has fields, property, method, constructor, destructor, indexers, events.
        // can have both abstract declaration and normal definitions.
        // can only used in inherited class
        // Not support multiple inheritance
        // it cannot be static class
        //Normal fields
        protected string _name;
        //abstract property
        public abstract string Name { get ; set; }
        //Normal property
        public double Amount { get; set; }
        public int Age {get;set;}
        //Normal Method
        public string Display(){
            return _name;
        }
        //abstract method - only declaration
        public abstract double Salary(int dates);
        
        
        
        
    }
}