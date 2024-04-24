using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace MovieTicketBooking;

class Program
{
    

    public static void Main(string[] args)
    {
        //creating files and folder
        FileHandling.CreateFileFolder();
        // adding default data
        //Operations.AddDefaultData();

        FileHandling.ReadFromCSV();

        //asking option for main menu and validating
        int option;
        do
        {
            bool tempOption;
            do
            {
                Console.WriteLine("-------------Main-Menu------------\n1.User Registration\n2.Login\n3.Exit");
                tempOption = int.TryParse(Console.ReadLine(), out option);
                if (!tempOption)
                    Console.WriteLine("Invalid option");
            }
            while (!tempOption);

            switch (option)
            {
                //Registration method called
                case 1:
                    Operations.Registration();
                    break;
                //Login method called
                case 2:
                    Operations.Login();
                    break;
                //Exit option
                case 3:
                    Console.WriteLine("Thank You... See you again :-)");
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
        while (option != 3);
        FileHandling.WriteToCSV();
    }
    
}
