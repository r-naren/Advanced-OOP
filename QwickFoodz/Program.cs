using System;
namespace QwickFoodz;
class Program
{
    public static void Main(string[] args)
    {
        // Creating files and folder
        FileHandling.createFileFolder();
        // calling add default data
        // Operations.AddDefaultData();
        // read from csv
        FileHandling.ReadFromCSV();
        // calling main menu
        Operations.MainMenu();
        //writing to csv
        FileHandling.WriteToCSV();
    }
}