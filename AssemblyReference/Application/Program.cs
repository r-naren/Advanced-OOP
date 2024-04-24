using System;
namespace Application;
using CollegeDetails;
class Program{
    public static void Main(string[] args)
    {
        //Default data calling
        Operations.AddDefaultData();

        // Calling Main Menu
        Operations.MainMenu();
    }
}