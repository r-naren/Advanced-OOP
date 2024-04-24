using System;
namespace DiscountInShop;
class Program{
    public static void Main(string[] args)
    {
        Menswear menswear = new Menswear();
        menswear.GetDressInfo(DressType.Menswear, "Pant", 2000);
        menswear.DisplayInfo();
        Console.WriteLine();
        
        Ladieswear ladieswear = new Ladieswear();
        ladieswear.GetDressInfo(DressType.Ladieswear, "Kurthi", 3000);
        ladieswear.DisplayInfo();
        Console.WriteLine();
        
    }
}
