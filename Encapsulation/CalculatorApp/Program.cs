using System;
namespace CalculatorApp;
class Program{
    public static void Main(string[] args)
    {
        CircleArea circleArea = new CircleArea(4.7);
        Console.WriteLine($"{circleArea.CalculateCircleArea()}");
        
    }
}