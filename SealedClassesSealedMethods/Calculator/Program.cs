using System;
namespace Calculator;
class Program{
    public static void Main(string[] args)
    {
        CircleCalculator circle = new CircleCalculator();
        Console.WriteLine($"Circle area: { circle.Area(4.6)}");
        
        Console.WriteLine($"Circle volume : {circle.Volume(4.6)}"); // printed 0 becase it is not overrided 
        
        CylinderCalculator cylinder  = new CylinderCalculator();
        Console.WriteLine($"Cylinder area : {cylinder.Area(4.6)}");
        Console.WriteLine($"Cylinder volume : {cylinder.Volume(4.6,7.4)}");
        
        

    }
}