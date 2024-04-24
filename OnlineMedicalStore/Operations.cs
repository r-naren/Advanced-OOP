using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace onlineMedicalStore
{

    public static class Operations
    {
        public static UserDetails currentLoggedInUser;
        public static CustomList<UserDetails> usersList = new CustomList<UserDetails>();
        public static CustomList<MedicineDetails> medicinesList = new CustomList<MedicineDetails>();
        public static CustomList<OrderDetails> ordersList = new CustomList<OrderDetails>();
        public static void AddDefaultData()
        {
            UserDetails user1 = new UserDetails("Ravi", 33, "Theni", "9877774440", 400);
            UserDetails user2 = new UserDetails("Baskaran", 33, "Chennai", "8847757470", 500);
            usersList.Add(user1);
            usersList.Add(user2);
            MedicineDetails medicine1 = new MedicineDetails("Paracitomal", 40, 5, new DateTime(2024, 06, 30));
            MedicineDetails medicine2 = new MedicineDetails("Calpol", 10, 5, new DateTime(2024, 05, 30));
            MedicineDetails medicine3 = new MedicineDetails("Gelucil", 3, 40, new DateTime(2023, 04, 30));
            MedicineDetails medicine4 = new MedicineDetails("Metrogel", 5, 50, new DateTime(2024, 12, 30));
            MedicineDetails medicine5 = new MedicineDetails("Povidin Iodin", 10, 50, new DateTime(2024, 10, 30));
            medicinesList.Add(medicine1);
            medicinesList.Add(medicine2);
            medicinesList.Add(medicine3);
            medicinesList.Add(medicine4);
            medicinesList.Add(medicine5);
            OrderDetails order1 = new OrderDetails("UID1001", "MD101", 3, 15, new DateTime(2022, 11, 13), OrderStatus.Purchased);
            OrderDetails order2 = new OrderDetails("UID1001", "MD102", 2, 10, new DateTime(2022, 11, 13), OrderStatus.Cancelled);
            OrderDetails order3 = new OrderDetails("UID1001", "MD104", 2, 100, new DateTime(2022, 11, 13), OrderStatus.Purchased);
            OrderDetails order4 = new OrderDetails("UID1002", "MD103", 3, 120, new DateTime(2022, 11, 15), OrderStatus.Cancelled);
            OrderDetails order5 = new OrderDetails("UID1002", "MD105", 5, 250, new DateTime(2022, 11, 15), OrderStatus.Purchased);
            OrderDetails order6 = new OrderDetails("UID1002", "MD102", 3, 15, new DateTime(2022, 11, 15), OrderStatus.Purchased);
            ordersList.AddRange(new CustomList<OrderDetails> { order1, order2, order3, order4, order5, order6 });
        }
        public static void MainMenu()
        {
            int choice;
            Console.WriteLine($"**********Online medical store*******");
            do
            {
                Console.WriteLine($"Main Menu");
                Console.Write($"1.User Registration\n2.User login\n3.Exit\n Enter option :");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine($"User Registration");
                            UserRegistration();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"User login");
                            UserLogin();
                            break;

                        }
                    case 3:
                        {
                            Console.WriteLine($"Exiting the application");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine($"Enter valid choice");
                            break;

                        }
                }
            } while (choice != 3);

        }
        public static void UserRegistration()
        {
            Console.Write($"Enter username : ");
            string userName = Console.ReadLine();

            Console.Write($"Enter age : ");
            int age = int.Parse(Console.ReadLine());
            Console.Write($"Enter city : ");
            string city = Console.ReadLine();
            Console.Write($"Enter Phone number : ");
            string phoneNumber = Console.ReadLine();
            Console.Write($"Enter balance : ");
            int balance = int.Parse(Console.ReadLine());
            while (balance < 1)
            {
                Console.Write($"Enter valid balance : ");
                balance = int.Parse(Console.ReadLine());

            }
            UserDetails user = new UserDetails(userName, age, city, phoneNumber, balance);
            usersList.Add(user);
            Console.WriteLine($"User registered successfully and user id is {user.UserID}");

        }
        public static void UserLogin()
        {
            bool temp = false;
            string userID = Console.ReadLine().ToUpper();
            foreach (UserDetails user in usersList)
            {
                if (user.UserID.Equals(userID))
                {
                    currentLoggedInUser = user;
                    Console.WriteLine($"Logged in successfully");

                    SubMenu();
                    break;
                }
            }
            if (!temp)
            {
                Console.WriteLine($"user id is invalid");

            }
        }
        public static void SubMenu()
        {
            int choice;
            do
            {
                Console.WriteLine($"Sub Menu");
                Console.Write($"1.Show medicine list\n2.Purchase medicine\n3.modify purchase\n4.Cancel purchase\n5.Show purchase history\n6.Recharge wallet\n7.Wallet balance\n8.Exit\nEnter your choice :");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine($"Show Medicine List");
                            ShowMedicineList();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"Purchase Medicine");
                            PurchaseMedicine();
                            break;

                        }
                    case 3:
                        {
                            Console.WriteLine($"Modify purchase");
                            ModifyPurchase();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine($"cancel purchase");
                            CancelPurchase();
                            break;

                        }
                    case 5:
                        {
                            Console.WriteLine($"Show Purchase history");
                            ShowPurchaseHistory();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine($"Recharge wallet");
                            RechargeWallet();
                            break;

                        }
                    case 7:
                        {
                            Console.WriteLine($"Show wallet balance");
                            ShowWalletBalance();
                            break;
                        }

                    case 8:
                        {
                            Console.WriteLine($"Exiting to main  menu");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine($"Enter valid choice");
                            break;

                        }
                }
            } while (choice != 8);

        }
        public static void ShowMedicineList()
        {
            bool temp = false;
            foreach (MedicineDetails medicine in medicinesList)
            {
                if (medicine.AvailableCount > 0)
                {
                    temp = true;
                    break;
                }
            }
            if (temp)
            {
                foreach (MedicineDetails medicine in medicinesList)
                {
                    if (medicine.AvailableCount > 0)
                    {
                        Console.WriteLine($"{medicine.MedicineID}|{medicine.MedicineName}|{medicine.AvailableCount}|{medicine.Price}|{medicine.DateOfExpiry.ToString("dd/MM/yyyy")}");
                    }
                }
            }
            else
            {
                Console.WriteLine($"There is  no medicine available ");

            }
        }
        public static void PurchaseMedicine()
        {
            ShowMedicineList();
            bool temp = false;
            Console.Write($"Enter medicine id : ");
            string medicineID = Console.ReadLine().ToUpper();
            foreach (MedicineDetails medicine in medicinesList)
            {
                if (medicine.MedicineID.Equals(medicineID))
                {
                    temp = true;
                    Console.Write($"Enter number of count you want to purchase : ");

                    int count = int.Parse(Console.ReadLine());
                    if (medicine.AvailableCount >= count)
                    {
                        TimeSpan span = DateTime.Now - medicine.DateOfExpiry;
                        if ((int)span.Days < 0)
                        {
                            int price = count * medicine.Price;
                            if (currentLoggedInUser.WalletBalance >= price)
                            {
                                medicine.AvailableCount -= count;
                                currentLoggedInUser.DeductBalance(price);
                                OrderDetails order = new OrderDetails(currentLoggedInUser.UserID, medicine.MedicineID, medicine.AvailableCount, price, DateTime.Now, OrderStatus.Purchased);
                                Console.WriteLine($"Medicine purchased successfully and order id {order.OrderID}");
                                ordersList.Add(order);
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"Insufficient balance. Recharge wallet and come again for purchase");

                            }
                        }
                        else
                        {
                            Console.WriteLine($"Medicine is not available");

                        }
                    }
                    else
                    {
                        Console.WriteLine($"Request medicine count is not available");

                    }
                    break;
                }
            }
            if (!temp)
            {
                Console.WriteLine($"Medicine id is invalid");

            }

        }
        public static void ModifyPurchase()
        {
            bool temp = false;
            foreach (OrderDetails order in ordersList)
            {
                if (order.UserID.Equals(currentLoggedInUser.UserID) && order.OrderStatus.Equals(OrderStatus.Purchased))
                {
                    temp = true;
                    break;
                }
            }
            if (temp)
            {
                foreach (OrderDetails order in ordersList)
                {
                    if (order.UserID.Equals(currentLoggedInUser.UserID) && order.OrderStatus.Equals(OrderStatus.Purchased))
                    {
                        Console.WriteLine($"{order.OrderID}|{order.UserID}|{order.MedicineID}|{order.MedicineCount}|{order.TotalPrice}|{order.OrderDate.ToString("dd/MM/yyyy")}|{order.OrderStatus}");
                    }
                }
                Console.Write($"Enter from above order id : ");
                string orderID = Console.ReadLine().ToUpper();
                temp = false;
                foreach (OrderDetails order in ordersList)
                {
                    if (order.UserID.Equals(currentLoggedInUser.UserID) && order.OrderID.Equals(orderID)&& order.OrderStatus.Equals(OrderStatus.Purchased))
                    {
                        temp = true;
                        Console.Write($"Enter quantity : ");
                        int newQuantity = int.Parse(Console.ReadLine());
                        while (newQuantity < 1)
                        {
                            Console.Write($"Enter valid quantity : ");
                            newQuantity = int.Parse(Console.ReadLine());

                        }

                        foreach (MedicineDetails medicine in medicinesList)
                        {
                            if (medicine.MedicineID.Equals(order.MedicineID))
                            {

                                if (medicine.AvailableCount >= newQuantity - order.MedicineCount)
                                {
                                    int price = medicine.Price * newQuantity;

                                    medicine.AvailableCount -= newQuantity - order.MedicineCount;
                                    order.TotalPrice = price;
                                    order.MedicineCount = newQuantity;
                                    Console.WriteLine($"Order modified succcessfully");

                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"Quantity is not available");

                                }
                            }
                        }
                        break;
                    }
                }
                if (!temp)
                {
                    Console.WriteLine($"Order id is not present");

                }

            }

            else
            {
                Console.WriteLine($"There is  no purchase history");

            }
        }
        public static void CancelPurchase()
        {
            bool temp = false;
            foreach (OrderDetails order in ordersList)
            {
                if (order.UserID.Equals(currentLoggedInUser.UserID) && order.OrderStatus.Equals(OrderStatus.Purchased))
                {
                    temp = true;
                    break;
                }
            }
            if (temp)
            {
                foreach (OrderDetails order in ordersList)
                {
                    if (order.UserID.Equals(currentLoggedInUser.UserID) && order.OrderStatus.Equals(OrderStatus.Purchased))
                    {
                        Console.WriteLine($"{order.OrderID}|{order.UserID}|{order.MedicineID}|{order.MedicineCount}|{order.TotalPrice}|{order.OrderDate.ToString("dd/MM/yyyy")}|{order.OrderStatus}");
                    }
                }
                Console.Write($"Enter from above order id : ");
                string orderID = Console.ReadLine().ToUpper();
                temp = false;
                foreach (OrderDetails order in ordersList)
                {
                    if (order.UserID.Equals(currentLoggedInUser.UserID) && order.OrderStatus.Equals(OrderStatus.Purchased))
                    {
                        temp = true;
                        foreach (MedicineDetails medicine in medicinesList)
                        {
                            if (medicine.MedicineID.Equals(order.MedicineID))
                            {
                                medicine.AvailableCount += order.MedicineCount;
                                currentLoggedInUser.WalletRecharge(order.TotalPrice);
                                order.OrderStatus = OrderStatus.Cancelled;

                                Console.WriteLine($"Order {order.OrderID} was cancelled successfully");
                                break;

                            }
                        }
                    }
                }
                if (!temp)
                {
                    Console.WriteLine($"Order id is not present");

                }
            }
            else
            {
                Console.WriteLine($"There is  no purchase history");

            }

        }
        public static void ShowPurchaseHistory()
        {
            bool temp = false;
            foreach (OrderDetails order in ordersList)
            {
                if (order.UserID.Equals(currentLoggedInUser.UserID))
                {
                    temp = true;
                    break;
                }
            }
            if (temp)
            {
                foreach (OrderDetails order in ordersList)
                {
                    if (order.UserID.Equals(currentLoggedInUser.UserID))
                    {
                        Console.WriteLine($"{order.OrderID}|{order.UserID}|{order.MedicineID}|{order.MedicineCount}|{order.TotalPrice}|{order.OrderDate.ToString("dd/MM/yyyy")}|{order.OrderStatus}");
                    }
                }
            }
            else
            {
                Console.WriteLine($"There is  no purchase history");

            }
        }
        public static void RechargeWallet()
        {
            Console.Write($"Enter amount to recharge : ");

            int amount = int.Parse(Console.ReadLine());
            while (amount < 1)
            {
                Console.Write($"Enter valid amount to recharge : ");

                amount = int.Parse(Console.ReadLine());
            }
            currentLoggedInUser.WalletRecharge(amount);
            Console.WriteLine($"Recharge successful");

        }
        public static void ShowWalletBalance()
        {
            Console.WriteLine($"Wallet balance : {currentLoggedInUser.WalletBalance}");

        }
    }
}