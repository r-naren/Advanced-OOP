using System;
using System.Buffers;
using System.IO;
namespace OnlineGroceryShop;
class Program{
    public static void Main(string[] args)
    {
        FileHandling.Create();
        FileHandling.ReadFromCSV();
        //Operations.AddDefaultData();
        
        Operations.MainMenu();
        FileHandling.WriteToCSV();
    }
}