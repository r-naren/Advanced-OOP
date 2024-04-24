using System;
namespace MetroCardManagement;
class Program{
    public static void Main(string[] args)
    {
        //Creating files and folders
        FileHandling.CreateFileFolder();
        // reading data from csv files
        FileHandling.ReadFromCSV();
        // calling default data method
        // Operations.AddDefaultData();
        // calling main menu
        Operations.MainMenu();
        // writing to csv files

        FileHandling.WriteToCSV();
    }
}