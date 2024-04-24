using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInformation
{
    public class MaruthiSwift : Car
    {
        public override void GetEngineType(EngineType engineType){
             EngineType= engineType;
        }
        public override void GetNoOfSeats(int noOfSeats){
            NoOfSeats = noOfSeats;
        }
        public override void GetPrice(int price){
            Price = price;
        }
        public override void GetCarType(CarType carType){
            CarType = carType;
        }
        public override void DisplayCarDetail(){
            Console.WriteLine($"EngineType : {EngineType} | No of seats : {NoOfSeats} | Price : {Price} | Car type : {CarType}");
            
        }
    }   
}