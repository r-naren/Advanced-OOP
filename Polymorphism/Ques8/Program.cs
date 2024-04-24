using System;
namespace Ques8;
class Program{
    public static void Main(string[] args)
    {
        Calculator sem1 = new Calculator(34,56,78,42,34,98);
        Calculator sem2 = new Calculator(35,97,87,42,34,98);
        Calculator sem3 = new Calculator(34,46,78,46,87,98);
        Calculator sem4 = new Calculator(97.5,56,78,23,34,76);
        Calculator sem = new Calculator(0,0,0,0,0,0);
        sem = sem1+sem2+sem3+sem4;
        Console.WriteLine($"Total : {sem.Total()}");
        Console.WriteLine($"Percentage : {sem.Percentage()}");
        
    }
}