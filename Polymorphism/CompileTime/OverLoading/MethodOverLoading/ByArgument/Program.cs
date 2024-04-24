using System;
namespace ByArgument;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine($"{Add(1,2)}");
        Console.WriteLine($"{Add(1,2,3)}");
    }
    public static int Add(int a, int b){
        return a+b;

    }
    public static int Add(int a, int b, int c){
        return a+b+c;
    }
}