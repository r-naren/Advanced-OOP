using System;
namespace ByType;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine($"{Add(1,2)}");
        Console.WriteLine($"{Add(1.7,9)}");
        Console.WriteLine($"{Add("kkk","sda")}");
    }
    public static int Add(int a, int b){
        return a+b;

    }
    public static double Add(double a, int b){
        return a+b;
    }
    public static string Add(string a, string b){
        return a+b;
    }
}