using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarModel
{
    public enum FuelType{Petrol, Diesel, Electric}
    public enum Color {Blue, Black, White, Orange}
    public class Car
    {
        public FuelType FuelType{get;set;}
        public int NumberOfSeats{get;set;}
        public Color Color{get;set;}
        public int TankCapacity{get;set;}
        public int NumberOfKmDriven{get;set;}
        public Car(FuelType fuelType, int numberofSeats, Color color, int tankCapacity, int numberOfKmDriven){
            FuelType = fuelType;
            NumberOfSeats = numberofSeats;
            Color = color;
            TankCapacity = tankCapacity;
            NumberOfKmDriven = numberOfKmDriven;
        }
        public void CalculateMilage(){
            Console.WriteLine($"Mileage : {(double)NumberOfKmDriven/TankCapacity}");
            
        }

    }
}