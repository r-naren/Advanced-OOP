using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscountInShop
{
    public class Ladieswear : Dress
    {
        public override DressType DressType{get;set;}
        public override string DressName {get;set;}
        public override double Price {get;set;}        
        public override double TotalPrice {get;set;}
        public override void GetDressInfo(DressType dressType, string dressName, double price){
            DressType = dressType;
            DressName = dressName;
            Price = price;
            TotalPrice = price - (price * 0.2);
        }
        public override void DisplayInfo(){
            Console.WriteLine($"Dress type : {DressType} | Dress Name : {DressName} | Price : {Price} | TotalPrice : {TotalPrice}");
            
        }
    }
}