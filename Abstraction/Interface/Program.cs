using System;
namespace Interface;
class Program{
    public static void Main(string[] args)
    {
        ICalculate number = new Square(); // class variable as object
        number.Number = 20;
        Console.WriteLine($"{number.Calculate()}");
        Circle number1 = new Circle();
        number1.Number = 30;
        Console.WriteLine($"{number1.Calculate()}");
        
        

    }
}