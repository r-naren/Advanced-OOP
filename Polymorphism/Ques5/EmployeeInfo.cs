using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ques5
{
    public class EmployeeInfo : PersonalInfo
    {
        private static int s_employeeID = 1000;
        public string EmployeeID{get;}
        public EmployeeInfo(string name, string fatherName, string mobileNumber,Gender gender): base( name,  fatherName,  mobileNumber, gender){
            EmployeeID = "EID" + ++s_employeeID;
        }
        public override void Display()
        {
            Console.WriteLine($"{Name} | {FatherName} | {Gender} | {MobileNumber}");
            
        }
    }
}