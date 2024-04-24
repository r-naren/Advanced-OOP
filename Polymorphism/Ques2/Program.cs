using System;
namespace Ques2;
class Program
{
    public static void Main(string[] args)
    {
        int integer = 11;
        double doubleValue = 12.7;
        long longValue = 234;
        float floatValue = 34.67F;
        Console.WriteLine($"{Square(integer)}");
        Console.WriteLine($"{Square(doubleValue)}");
        Console.WriteLine($"{Square(longValue)}");
        Console.WriteLine($"{Square(floatValue)}");
        
    }
    public static int Square(int a)
    {
        return a * a;

    }
    public static double Square(double a)
    {
        return a * a;

    }
    public static float Square(float a)
    {
        return a * a;

    }
    public static long Square(long a)
    {
        return a * a;

    }
}