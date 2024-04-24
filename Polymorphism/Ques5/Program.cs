using System;
using System.Security.Cryptography.X509Certificates;
using Ques5;
namespace Ques4;
class Program
{
    public static void Main(string[] args)
    {   
        PersonalInfo personalInfo ;
        PersonalInfo employeeInfo = new EmployeeInfo("Naren", "Ramasamy", "naren@gmail.com", Gender.Male);
        personalInfo = employeeInfo;
        employeeInfo.Display();
        SalaryInfo salaryInfo = new SalaryInfo("sdfsdg", "Ramasamy", "naren@gmail.com", Gender.Male, 22);
        personalInfo = salaryInfo;
        salaryInfo.Display();
        
    }
}