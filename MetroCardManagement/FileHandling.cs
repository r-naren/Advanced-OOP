using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public static class FileHandling
    {
        public static void CreateFileFolder(){
            // checking does folder exists and if not create
            if(!Directory.Exists("MetroCardManagementFiles")){
                Console.WriteLine($"Creating folder");
                Directory.CreateDirectory("MetroCardManagementFiles");
            }
            // checking if files exists if not create
            // user details
            if(!File.Exists("MetroCardManagementFiles/UserDetails.csv")){
                Console.WriteLine($"Creating csv file for userDetails");
                File.Create("MetroCardManagementFiles/UserDetails.csv").Close();
            }
            // travel details
            if(!File.Exists("MetroCardManagementFiles/TravelDetails.csv")){
                Console.WriteLine($"Creating csv file for TravelDetails");
                File.Create("MetroCardManagementFiles/TravelDetails.csv").Close();
            }
            // ticket fair details
            if(!File.Exists("MetroCardManagementFiles/TicketFairDetails.csv")){
                Console.WriteLine($"Creating csv file for TicketFairDetails");
                File.Create("MetroCardManagementFiles/TicketFairDetails.csv").Close();
            }
        } // create file folder ends
        public static void WriteToCSV (){
            // user details
            string[] users = new string[Operations.usersList.Count];
            for(int i=0;i<Operations.usersList.Count;i++){
                users[i] = Operations.usersList[i].CardNumber+","+Operations.usersList[i].UserName+","+Operations.usersList[i].PhoneNumber+","+Operations.usersList[i].Balance;
            }
            File.WriteAllLines("MetroCardManagementFiles/UserDetails.csv", users);
            //travel details
            string[] travels = new string[Operations.travelsList.Count];
            for(int i=0;i<Operations.travelsList.Count;i++){
                travels[i] = Operations.travelsList[i].TravelID+","+Operations.travelsList[i].CardNumber+","+Operations.travelsList[i].FromLocation+","+Operations.travelsList[i].ToLocation+","+Operations.travelsList[i].Date.ToString("dd/MM/yyyy")+","+Operations.travelsList[i].TravelCost;
            }
            File.WriteAllLines("MetroCardManagementFiles/TravelDetails.csv", travels);
        
            // ticket details
            string[] tickets = new string[Operations.ticketFairsList.Count];
            for(int i=0;i<Operations.ticketFairsList.Count;i++){
                tickets[i] = Operations.ticketFairsList[i].TicketID+","+Operations.ticketFairsList[i].FromLocation+","+Operations.ticketFairsList[i].ToLocation+","+Operations.ticketFairsList[i].TicketPrice;
            }
            File.WriteAllLines("MetroCardManagementFiles/TicketFairDetails.csv", tickets);
        } // write to csv ends
        public static void ReadFromCSV(){
            // user details
            string[] users = File.ReadAllLines("MetroCardManagementFiles/UserDetails.csv");
            foreach(string user in users){
                UserDetails user1 = new UserDetails(user);
                Operations.usersList.Add(user1);
            }
            // travel details
            string[] travels = File.ReadAllLines("MetroCardManagementFiles/TravelDetails.csv");
            foreach(string travel in travels){
                TravelDetails travel1 = new TravelDetails(travel);
                Operations.travelsList.Add(travel1);
            }
            // ticket details
            string[] tickets = File.ReadAllLines("MetroCardManagementFiles/TicketFairDetails.csv");
            foreach(string ticket in tickets){
                TicketFairDetails ticket1 = new TicketFairDetails(ticket);
                Operations.ticketFairsList.Add(ticket1);
            }

        } // read from csv ends
    }
}