using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarModel
{
    public class ShiftDezire : Car, IBrand
    {
        private static int s_makingID = 1000;
        public string MakingID {get;set;}

        public string BrandName{get;set;}
        public string ModelName {get;set;}
        public string EngineNumber{get;set;}
        public string ChasisNumber{get;set;}
        public ShiftDezire(FuelType fuelType, int numberofSeats, Color color, int tankCapacity, int numberOfKmDriven, string brandName,string modelName, string engineNumber, string chasisNumber ) : base( fuelType,  numberofSeats,  color,  tankCapacity,  numberOfKmDriven){
            MakingID = "MID" + ++s_makingID;
            BrandName = brandName;
            ModelName = modelName;
            EngineNumber = engineNumber;
            ChasisNumber = chasisNumber;
        }
        public void ShowDetails(){
            Console.WriteLine($"Making ID : {MakingID} | Brand Name : {BrandName} | ModelName: {ModelName} | FuelType: {FuelType} | NumberOfSeats: {NumberOfSeats} | Color: {Color} | Tank capacity : {TankCapacity} | Number of km driven : {NumberOfKmDriven} | Engine Number : {EngineNumber} | Chasis Number : {ChasisNumber}");
            
        }

        
    }
}