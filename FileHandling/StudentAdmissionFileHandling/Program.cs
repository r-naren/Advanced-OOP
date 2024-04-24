using System;
using System.IO;
namespace StudentAdmissionFileHandling;
class Program{
    public static void Main(string[] args)
    {
        FileHandling.Create();
        //Default data calling
        FileHandling.ReadFromCSV();
        //Operations.AddDefaultData();

        // Calling Main Menu
        Operations.MainMenu();
        FileHandling.WriteToCSV();
    }
}