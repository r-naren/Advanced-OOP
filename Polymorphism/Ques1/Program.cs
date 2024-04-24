using System;
namespace Ques1;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine($"{Square(2.7)}");
        Console.WriteLine($"{Add(1,2)}");
        Console.WriteLine($"{Add(1,2,3)}");
        Console.WriteLine($"{Add(1,2,7.9)}");
        Console.WriteLine($"{Add(1,8.2)}");
    }
    public static double Square(double a){
        return a*a;

    }
    public static int Add(int a, int b, int c){
        return a+b+c;
    }
    public static int Add(int a, int b){
        return a+b;
    }
    public static double Add(int a, int b, double c){
        return (double)(a+b+c);
    }
    public static double Add(int a, double b){
        return (double)a+b;
    }
}