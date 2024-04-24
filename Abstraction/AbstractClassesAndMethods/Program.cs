using System;
using System.Linq.Expressions;
using AbstractClassesAndMethods;
namespace AbstractClassessAndMethods;
class Program{
    public static void Main(string[] args)
    {
        Employee job1 = new Syncfusion();
        job1.Name = "Zoro";
        Console.WriteLine($"{job1.Display()} | {job1.Salary(30)} | {job1.Age}");
        
        Google job2 = new Google();
        job2.Name = "Sanji";
        Console.WriteLine($"{job2.Display()} | {job2.Salary(30)} | {job2.Age}");
        
    }
}