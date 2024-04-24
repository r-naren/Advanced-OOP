using System;
namespace Ques6;
class Program{
    public static void Main(string[] args)
    {
        
        Bank sbi = new SBI();
        Console.WriteLine($"{sbi.GetInterestInfo()}");
        Bank icici = new ICICI();
        Console.WriteLine($"{icici.GetInterestInfo()}");
        Bank hdfc = new HDFC();
        Console.WriteLine($"{hdfc.GetInterestInfo()}");
        Bank idbi = new IDBI();
        Console.WriteLine($"{idbi.GetInterestInfo()}");

    }
}