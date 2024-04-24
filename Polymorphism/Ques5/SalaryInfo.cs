using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ques5
{
    public class SalaryInfo : EmployeeInfo
    {
        public int NoOfDaysWorked {get;set;}
        public SalaryInfo(string name, string fatherName, string mobileNumber,Gender gender,int noOfDaysWorked): base( name,  fatherName,  mobileNumber, gender){
            NoOfDaysWorked  = noOfDaysWorked;
        }
        public override void Display()
        {
            Console.WriteLine($"{Name} | {FatherName} | {Gender} | {MobileNumber} | {NoOfDaysWorked}");
            Console.WriteLine($"Salary : {NoOfDaysWorked * 500}");
            
        }
        
    }
}