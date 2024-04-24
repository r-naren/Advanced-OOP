using System;
namespace Employee;
class Program{
    public static void Main(string[] args)
    {
        EmployeeInfo employeeInfo = new EmployeeInfo("Naren", Gender.Male, new DateTime(2000,01,01), "9876543");
        Console.WriteLine(employeeInfo.Display());
        Console.WriteLine();
        employeeInfo.Update("Luffy", Gender.Male, new DateTime(1999,11,11), "1234567890");
        Console.WriteLine(employeeInfo.Display());
        
    }
}