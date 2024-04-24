using System;
namespace Ques7;
class Program
{
    public static void Main(string[] args)
    {
        Attendance month1 = new Attendance(22, 0, 1);
        Attendance month2 = new Attendance(20, 1, 0);

        Attendance month3 = new Attendance(24, 2, 5);
        Console.WriteLine($"Salary for 3 months : {month1.Salary()+month2.Salary()+month3.Salary()}");
        
    }
}
