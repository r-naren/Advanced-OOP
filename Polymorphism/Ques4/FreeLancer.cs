using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ques4
{
    public class FreeLancer : PersonalDetails
    {
        public FreeLancer(string name, string fatherName, Gender gender, string qualification, string role, int noOfWorkingDays) : base(name, fatherName, gender, qualification)
        {
            Role = role;
            NoOfWorkingDays = noOfWorkingDays;
        }

        public string Role {get;set;}
        public double SalaryAmount {get;set;}
        public int NoOfWorkingDays{get;set;}


        public virtual void  CalculateSalary(){
            SalaryAmount = NoOfWorkingDays*500;
        }
        public virtual void  Display(){
            Console.WriteLine($"Role : {Role}\nSalary Amount : {SalaryAmount}\nNo of working days : {NoOfWorkingDays}");            
        }
    }
}