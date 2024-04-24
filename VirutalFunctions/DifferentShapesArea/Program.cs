using System;
namespace DifferentShapesArea;
class Program
{
    public static void Main(string[] args)
    {
        Sphere sphere = new Sphere(3.78);
        sphere.Calculate();
        sphere.DisplayArea();
        Console.WriteLine();
        Rectangle rectangle = new Rectangle(5.67, 2.1);
        rectangle.Calculate();
        rectangle.DisplayArea();
        Console.WriteLine();

    }
}