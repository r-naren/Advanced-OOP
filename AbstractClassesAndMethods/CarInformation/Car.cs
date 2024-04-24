using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInformation
{
    public enum EngineType{Petrol, Diesel, CNG}
    public enum CarType {Hatchback, Sedan, SUV}
    public abstract class Car
    {
        private static int s_noOfWheels = 4;
        private static int s_noOfDoors = 4;
        public EngineType EngineType{get;set;}
        public int NoOfSeats {get;set;}
        public int Price {get;set;}
        public CarType CarType{get;set;}
        public void ShowWheels(){
            Console.WriteLine($"No of Wheels : {s_noOfWheels}");
        }
        public void ShowDoors(){
            Console.WriteLine($"No of doors : {s_noOfDoors}");
        }
        public abstract void GetEngineType(EngineType engineType);
        public abstract void GetNoOfSeats(int noOfSeats);
        public abstract void GetPrice(int price);
        public abstract void GetCarType(CarType carType);
        public abstract void DisplayCarDetail();


    }
}