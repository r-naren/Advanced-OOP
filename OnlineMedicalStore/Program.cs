using System;
using onlineMedicalStore;
namespace OndlineMedicalStore;
class Program{
    public static void Main(string[] args)
    {
        FileHandling.CreateFileFolder();
        FileHandling.ReadFromCSV();
        //Operations.AddDefaultData();
        Operations.MainMenu();
        FileHandling.WriteToCSV();
    }
}