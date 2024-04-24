using System;
namespace OperatorOverloading;
class Program{
    public static void Main(string[] args)
    {
        Box box1 = new Box(1.5,2.1,3.4);
        Box box2 = new Box(6.7,2.9,7.3);
        Box box3 = Box.Add(box1, box2);
        Console.WriteLine($"{box1.CalculateVolume()} ");
        Console.WriteLine($"{box2.CalculateVolume()} ");
        Console.WriteLine($"{box3.CalculateVolume()} ");
        Box box4 = box1+box2+box3;
        Console.WriteLine($"{box1.CalculateVolume()} ");
        Console.WriteLine($"{box2.CalculateVolume()} ");
        Console.WriteLine($"{box4.CalculateVolume()} ");
        
    }
}