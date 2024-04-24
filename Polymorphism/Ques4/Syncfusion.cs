using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ques4
{
    public class Syncfusion : FreeLancer
    {
        private static int s_employeeID = 1000;
        public string EmployeeID{get;}
        public  string WorkLocation{get;set;}
        public Syncfusion(string name, string fatherName, Gender gender, string qualification, string role, int noOfWorkingDays, string workLocation): base(name, fatherName, gender, qualification, role, noOfWorkingDays){
            EmployeeID = "EID"+ ++s_employeeID;
        }
        public override void CalculateSalary(){
            SalaryAmount = NoOfWorkingDays*1000;
        }
        public override void  Display(){
            Console.WriteLine($"EmployeeID: {EmployeeID}\nSalary Amount : {SalaryAmount}\nNo of working days : {NoOfWorkingDays}");            
        }
    }
}