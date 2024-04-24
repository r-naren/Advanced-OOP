using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace MetroCardManagement
{

    //static class
    public static class Operations
    {
        // static User
        public static UserDetails currentLoggedInUser;
        // static lists
        public static CustomList<UserDetails> usersList = new CustomList<UserDetails>();
        public static CustomList<TicketFairDetails> ticketFairsList = new CustomList<TicketFairDetails>();
        public static CustomList<TravelDetails> travelsList = new CustomList<TravelDetails>();

        public static void AddDefaultData()
        {
            //user details
            UserDetails user1 = new UserDetails("Ravi", "9848812345", 1000);
            UserDetails user2 = new UserDetails("Baskaran", "9948854321", 1000);
            usersList.Add(user1);
            usersList.Add(user2);
            // Travel history
            TravelDetails travel1 = new TravelDetails("CMRL1001", "Airport", "Egmore", new DateTime(2023, 10, 10), 55);
            TravelDetails travel2 = new TravelDetails("CMRL1001", "Egmore", "Koyambedu", new DateTime(2023, 10, 10), 32);
            TravelDetails travel3 = new TravelDetails("CMRL1002", "Alandur", "Koyambedu", new DateTime(2023, 11, 10), 23);
            TravelDetails travel4 = new TravelDetails("CMRL1002", "Egmore", "Thirumangalam", new DateTime(2023, 11, 10), 23);
            travelsList.Add(travel1);
            travelsList.Add(travel2);
            travelsList.Add(travel3);
            travelsList.Add(travel4);
            // Ticket fair details
            TicketFairDetails ticketFair1 = new TicketFairDetails("Airport", "Egmore", 55);
            TicketFairDetails ticketFair2 = new TicketFairDetails("Airport", "Koyambedu", 25);
            TicketFairDetails ticketFair3 = new TicketFairDetails("Alandur", "Koyambedu", 25);
            TicketFairDetails ticketFair4 = new TicketFairDetails("Koyambedu", "Egmore", 32);
            TicketFairDetails ticketFair5 = new TicketFairDetails("Vadapalani", "Egmore", 45);
            TicketFairDetails ticketFair6 = new TicketFairDetails("Arumbakkam", "Egmore", 25);
            TicketFairDetails ticketFair7 = new TicketFairDetails("Vadapalani", "Koyambedu", 25);
            TicketFairDetails ticketFair8 = new TicketFairDetails("Arumbakkam", "Koyambedu", 16);
            ticketFairsList.AddRange(new CustomList<TicketFairDetails> { ticketFair1, ticketFair2, ticketFair3, ticketFair4, ticketFair5, ticketFair6, ticketFair7, ticketFair8 });
        } // add default data ends
        public static void MainMenu()
        {
            int choice;
            Console.WriteLine($"*****************Welcome To Metro Card Management*****************");

            do
            {
                // looping until exit
                Console.WriteLine($"---------------- Main Menu -----------------");
                Console.WriteLine($"Enter any one of the below choices\n1. New User Registration\n2. Login User\n3. Exit ");
                Console.Write($"Enter your choice : ");
                bool flag = int.TryParse(Console.ReadLine(), out choice);
                while (!flag)
                {
                    // checking does choice is valid
                    Console.Write($"Enter valid choice : ");
                    flag = int.TryParse(Console.ReadLine(), out choice);
                }
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine($"******New User Registration******");
                            NewuserRegistation();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"**********Login User********");
                            UserLogin();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"Exiting application...");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine($"Enter valid choice");
                            break;
                        }
                }
            } while (choice != 3);

        } // main menu ends
        public static void NewuserRegistation()
        {
            //Getting username
            Console.Write($"Enter user Name : ");
            string userName = Console.ReadLine();
            while (String.IsNullOrEmpty(userName))
            {
                Console.Write($"Enter valid user Name : ");
                userName = Console.ReadLine();
            }
            // Getting phonenumber
            Console.Write($"Enter Phone Number : ");
            System.Text.RegularExpressions.Regex phoneCheck = new System.Text.RegularExpressions.Regex(@"[6-9]{1}[0-9]{9}$");
            string phoneNumber = Console.ReadLine();
            while (!phoneCheck.IsMatch(phoneNumber) || phoneNumber.Length != 10)
            {
                Console.Write($"Enter valid phone Number : ");
                phoneNumber = Console.ReadLine();
            }
            // getting balance
            Console.Write($"Enter Balance : ");
            bool temp = int.TryParse(Console.ReadLine(), out int balance);
            while (!temp || balance < 1)
            {
                Console.Write($"Enter valid balance : ");
                temp = int.TryParse(Console.ReadLine(), out balance);
            }
            // creating user details object
            UserDetails user = new UserDetails(userName, phoneNumber, balance);
            //add to users list
            usersList.Add(user);
            Console.WriteLine($"User Registration successful and card number is {user.CardNumber}.");
        } //  new user registration ends
        public static void UserLogin()
        {
            bool temp = false;
            //Getting card number from user
            Console.Write($"Enter card number : ");
            string cardNumber = Console.ReadLine().ToUpper();
            // checking is card number present or not
            foreach (UserDetails user in usersList)
            {
                if (user.CardNumber.Equals(cardNumber))
                {
                    currentLoggedInUser = user;
                    temp = true;
                    SubMenu();
                    break;
                }
            }
            if (!temp)
            {
                Console.WriteLine($"Card number is not present or invalid");
            }
        }// user login ends
        public static void SubMenu()
        {
            int choice;
            do
            {
                // looping until exit
                Console.WriteLine($"---------------- Sub Menu -----------------");
                Console.WriteLine($"Enter any one of the below choices\n1. Balance Check\n2. Recharge\n3. View Travel History\n4. Travel\n5. Exit ");
                Console.Write($"Enter your choice : ");
                bool flag = int.TryParse(Console.ReadLine(), out choice);
                while (!flag)
                {
                    // checking does choice is valid
                    Console.Write($"Enter valid choice : ");
                    flag = int.TryParse(Console.ReadLine(), out choice);
                }
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine($"******Balance Check******");
                            BalanceCheck();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"**********Recharge**********");
                            Recharge();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"**********View Travel History********");
                            ViewTravelHistory();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine($"**********Travel**********");
                            Travel();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine($"Exiting to main menu...");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine($"Enter valid choice");
                            break;
                        }
                }
            } while (choice != 5);

        }
        public static void BalanceCheck()
        {
            Console.WriteLine($"Balance for the user {currentLoggedInUser.UserName} is Rs.{currentLoggedInUser.ReturnBalance()}");
        } // balance check ends
        public static void Recharge()
        {
            // getting amount to recharge
            Console.Write($"Enter amount to recharge : ");
            bool temp = int.TryParse(Console.ReadLine(), out int amount);
            while (!temp || amount < 1)
            {
                Console.Write($"Enter valid amount to recharge : ");
                temp = int.TryParse(Console.ReadLine(), out amount);
            }
            //calling wallet recharge method from user details
            currentLoggedInUser.WalletRecharge(amount);
            Console.WriteLine($"Recharge successful");

        } // recharge ends
        public static void ViewTravelHistory()
        {
            bool temp = false;
            string line = "------------------------------------------------------------------------------";
            // checking if history is present or not
            foreach (TravelDetails travel in travelsList)
            {
                if (travel.CardNumber.Equals(currentLoggedInUser.CardNumber))
                {
                    temp = true;
                    break;
                }
            }
            if (temp)
            {
                Console.WriteLine(line);

                // if travel history present
                Console.WriteLine($"|{"Travel ID",-9}|{"Card Number",-11}| {"From Location",-14}|  {"To Location",-13}|  {"Date",-8}|{"Travel cost",-11}|");
                Console.WriteLine(line);

                foreach (TravelDetails travel in travelsList)
                {
                    if (travel.CardNumber.Equals(currentLoggedInUser.CardNumber))
                    {
                        Console.WriteLine($"| {travel.TravelID,-8}| {travel.CardNumber,-10}| {travel.FromLocation,-14}| {travel.ToLocation,-14}|{travel.Date.ToString("dd/MM/yyyy"),-10}|    {travel.TravelCost,-7}|");
                        Console.WriteLine(line);
                    }
                }
            }
            else
            {
                Console.WriteLine($"There is no travel history for this user.");
            }
        } // view travel history ends
        public static void Travel()
        {
            bool temp = false;
            string line = "------------------------------------------------";
            // checking if ticket fair is present or not
            if (ticketFairsList.Count > 0)
            {
                Console.WriteLine(line);
                // if ticket fair present
                Console.WriteLine($"|{"Ticket ID",-9}| {"From Location",-14}|  {"To Location",-13}|{"Fair",-4}|");
                Console.WriteLine(line);

                foreach (TicketFairDetails ticketFair in ticketFairsList)
                {
                    Console.WriteLine($"| {ticketFair.TicketID,-8}| {ticketFair.FromLocation,-14}| {ticketFair.ToLocation,-14}| {ticketFair.TicketPrice,-3}|");
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine($"There are no tickets.");
            }
            // getting ticket id from user

            Console.Write($"Enter Ticket ID : ");
            string ticketID = Console.ReadLine().ToUpper();
            // checking is ticket ID present or not
            foreach (TicketFairDetails ticketFair in ticketFairsList)
            {
                if (ticketFair.TicketID.Equals(ticketID))
                {
                    temp = true;
                    // checking balance  is available by the user
                    if (currentLoggedInUser.ReturnBalance() >= ticketFair.TicketPrice)
                    {
                        // deducting amount
                        currentLoggedInUser.DeductBalance(ticketFair.TicketPrice);
                        // creating travel object and assigning to travels list
                        TravelDetails travel = new TravelDetails(currentLoggedInUser.CardNumber, ticketFair.FromLocation, ticketFair.ToLocation, DateTime.Now, ticketFair.TicketPrice);
                        travelsList.Add(travel);
                        Console.WriteLine($"Ticket booked successfully and travel ID is {travel.TravelID}");
                        
                    }
                    else
                    {
                        Console.WriteLine($"Balance is insufficient. Your balance is {currentLoggedInUser.ReturnBalance()}. Recharge and try again. Exiting to User Service");
                    }
                    break;
                }
            }
            if (!temp)
            {
                Console.WriteLine($"Ticket id is not present or invalid");
            }

        } // travel ends
    }
}