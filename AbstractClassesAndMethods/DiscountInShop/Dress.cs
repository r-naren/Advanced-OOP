using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace DiscountInShop
{
    public enum DressType {Ladieswear, Menswear, Childrenwear}
    public abstract class Dress
    {
        public abstract DressType DressType{get;set;}
        public abstract string DressName {get;set;}
        public abstract double Price {get;set;}        
        public abstract double TotalPrice {get;set;}
        public abstract void GetDressInfo(DressType dressType, string dressName, double price);
        public abstract void DisplayInfo();
    }
}