using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetails
{
    public class EmployeeInfo : IDisplay
    {
        private static int s_employeeID = 2000;
        public string  EmployeeID {get;set;}
        public string Name {get;set;}
        public string FatherName {get;set;}
        
        public EmployeeInfo(string name, string fatherName){
            EmployeeID = "EID" + ++s_employeeID;
            Name = name;
            FatherName = fatherName;
        }
        public void Display(){
            Console.WriteLine($"Employee ID : {EmployeeID} | Name : {Name} | Father name : {FatherName}");
            
        }
    }
}