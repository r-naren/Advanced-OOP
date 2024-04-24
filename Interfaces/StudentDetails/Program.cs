using System;
namespace StudentDetails;
class Program{
    public static void Main(string[] args)
    {
        StudentInfo studentInfo = new StudentInfo("Naren", "Ramasamy", "54321");
        EmployeeInfo employeeInfo = new EmployeeInfo("Luffy", "Dragon");
        studentInfo.Display();
        Console.WriteLine();
        employeeInfo.Display();        
    }
}