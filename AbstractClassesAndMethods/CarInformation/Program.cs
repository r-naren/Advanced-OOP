using System;
namespace CarInformation;
class Program{
    public static void Main(string[] args)
    {
        MaruthiSwift maruthiSwift = new MaruthiSwift();
        maruthiSwift.GetCarType(CarType.Sedan);
        maruthiSwift.GetEngineType(EngineType.Petrol);
        maruthiSwift.GetNoOfSeats(5);
        maruthiSwift.GetPrice(1000000);
        maruthiSwift.DisplayCarDetail();
        Console.WriteLine();
        SuzukiCiaz suzukiCiaz = new SuzukiCiaz();
        maruthiSwift.GetCarType(CarType.Sedan);
        maruthiSwift.GetEngineType(EngineType.Diesel);
        maruthiSwift.GetNoOfSeats(5);
        maruthiSwift.GetPrice(800000);
        maruthiSwift.DisplayCarDetail();
        

    }
}