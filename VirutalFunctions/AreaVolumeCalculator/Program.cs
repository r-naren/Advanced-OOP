using System;
namespace AreaVolumeCalculator;
class Program{
    public static void Main(string[] args)
    {
        AreaCalculator areaCalculator = new AreaCalculator(11.2);
        areaCalculator.Calculate();
        areaCalculator.Display();
        Console.WriteLine();

        VolumeCalculator volumeCalculator = new VolumeCalculator(7,8.9);
        volumeCalculator.Calculate();
        volumeCalculator.Display();
        Console.WriteLine();
    }
}