using System;
namespace ShapeAreaVolume;
class Program{
    public static void Main(string[] args)
    {
        Cylinders cylinder = new Cylinders(4.7,7.8);
        cylinder.CalculateArea();
        cylinder.CalculateVolume();
        Console.WriteLine($"Cylinder Area : {cylinder.Area} | Cylinder Volume : {cylinder.Volume}");
        Cubes cube = new Cubes(11.9);
        cube.CalculateArea();
        cube.CalculateVolume();
        Console.WriteLine($"cube Area : {cube.Area} | cube Volume : {cube.Volume}");
        
    }
}
