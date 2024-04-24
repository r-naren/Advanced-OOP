using System;
namespace  EmployeeSalary;
class Porgram{
    public static void Main(string[] args)
    {
        SalaryInfo salary1 = new SalaryInfo(27001, 4);
        PermanentEmployee permanentEmployee1 = new PermanentEmployee(salary1.BasicSalary, salary1.Month, "Full-Time");
        TemporaryEmployee temporaryEmployee1 = new TemporaryEmployee(salary1.BasicSalary, salary1.Month, "Part-Time");
        permanentEmployee1.CalulateTotalSalary();
        temporaryEmployee1.CalulateTotalSalary();
        permanentEmployee1.ShowSalary();
        temporaryEmployee1.ShowSalary();
        Console.WriteLine();
        SalaryInfo salary2 = new SalaryInfo(249576, 6);
        PermanentEmployee permanentEmployee2 = new PermanentEmployee(salary2.BasicSalary, salary2.Month, "Full-Time");
        TemporaryEmployee temporaryEmployee2 = new TemporaryEmployee(salary2.BasicSalary, salary2.Month, "Probation");
        permanentEmployee2.CalulateTotalSalary();
        temporaryEmployee2.CalulateTotalSalary();
        permanentEmployee2.ShowSalary();
        temporaryEmployee2.ShowSalary();
        


    }
}