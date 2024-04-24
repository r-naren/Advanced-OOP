using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public static class Operations
    {
        // static user
        public static CustomerDetails currentLoggedInUser;
        //static lists
        public static CustomList<CustomerDetails> customersList = new CustomList<CustomerDetails>();
        public static CustomList<FoodDetails> foodsList = new CustomList<FoodDetails>();
        public static CustomList<OrderDetails> ordersList = new CustomList<OrderDetails>();
        public static CustomList<ItemDetails> itemsList = new CustomList<ItemDetails>();
        public static void AddDefaultData()
        {
            CustomerDetails customer1 = new CustomerDetails("Ravi", "Ettaparajan", Gender.Male, "974774646", new DateTime(1999, 11, 11), "ravi@gmail.com", "Chennai", 10000);
            CustomerDetails customer2 = new CustomerDetails("Baskaran", "Sethurajan", Gender.Male, "847575775", new DateTime(1999, 11, 11), "baskaran@gmail.com", "Chennai", 15000);
            customersList.Add(customer1);
            customersList.Add(customer2);
            FoodDetails food1 = new FoodDetails("Chicken Briyani 1Kg", 100, 12);
            FoodDetails food2 = new FoodDetails("Mutton Briyani 1Kg", 150, 10);
            FoodDetails food3 = new FoodDetails("Veg Full Meals", 80, 30);
            FoodDetails food4 = new FoodDetails("Noodles", 100, 40);
            FoodDetails food5 = new FoodDetails("Dosa", 40, 40);
            FoodDetails food6 = new FoodDetails("Idly (2 pieces)", 20, 50);
            FoodDetails food7 = new FoodDetails("Pongal", 40, 20);
            FoodDetails food8 = new FoodDetails("Vegetable Briyani", 80, 15);
            FoodDetails food9 = new FoodDetails("Lemon Rice", 50, 30);
            FoodDetails food10 = new FoodDetails("Beg Pulav", 120, 30);
            FoodDetails food11 = new FoodDetails("Chicken 65 (200 Grams)", 75, 30);
            foodsList.AddRange(new CustomList<FoodDetails> { food1, food2, food3, food4, food5, food6, food7, food8, food9, food10, food11 });
            OrderDetails order1 = new OrderDetails("CID1001", 580, new DateTime(2022, 11, 26), OrderStatus.Ordered);
            OrderDetails order2 = new OrderDetails("CID1002", 870, new DateTime(2022, 11, 26), OrderStatus.Ordered);
            OrderDetails order3 = new OrderDetails("CID1001", 820, new DateTime(2022, 11, 26), OrderStatus.Cancelled);
            ordersList.Add(order1);
            ordersList.Add(order2);
            ordersList.Add(order3);
            ItemDetails item1 = new ItemDetails("OID3001", "FID2001", 2, 200);
            ItemDetails item2 = new ItemDetails("OID3001", "FID2002", 2, 300);
            ItemDetails item3 = new ItemDetails("OID3001", "FID2003", 1, 80);
            ItemDetails item4 = new ItemDetails("OID3002", "FID2001", 1, 100);
            ItemDetails item5 = new ItemDetails("OID3002", "FID2002", 4, 600);
            ItemDetails item6 = new ItemDetails("OID3002", "FID2010", 1, 120);
            ItemDetails item7 = new ItemDetails("OID3002", "FID2009", 1, 50);
            ItemDetails item8 = new ItemDetails("OID3003", "FID2002", 2, 300);
            ItemDetails item9 = new ItemDetails("OID3003", "FID2008", 4, 320);
            ItemDetails item10 = new ItemDetails("OID3003", "FID2001", 2, 200);
            itemsList.AddRange(new CustomList<ItemDetails> { item1, item2, item3, item4, item5, item6, item7, item8, item9, item10 });
        } // add default data ends
        public static void MainMenu()
        {
            int choice;
            Console.WriteLine($"***************Welcome to Qwick Foodz****************");
            do
            {
                // loop until option 3
                Console.WriteLine($"-------------Main Menu------------");
                Console.Write($"1.Customer Registration\n2.Customer Login\n3.Exit\nEnter anyone of the options above : ");
                bool flag = int.TryParse(Console.ReadLine(), out choice);
                while (!flag)
                {
                    Console.Write($"Enter valid choice : ");
                    flag = int.TryParse(Console.ReadLine(), out choice);
                }
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine($"----Customer Registration");
                            CustomerRegistration();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"----Customer Login");
                            CustomerLogin();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"Exiting application....");

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
        public static void CustomerRegistration()
        {
            //Name
            Console.Write("Enter name : ");
            string name = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.Write("Enter valid name : ");
                name = Console.ReadLine();
            }
            //Father name
            Console.Write("Enter father name : ");
            string fatherName = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(fatherName))
            {
                Console.Write("Enter valid father name : ");
                fatherName = Console.ReadLine();
            }
            //gender
            Console.Write("Enter Gender (Male, Female, Trangender) : ");
            bool temp = Enum.TryParse<Gender>(Console.ReadLine(), true, out Gender gender);
            while (!temp)
            {
                Console.Write("Enter valid Gender (Male, Female, Trangender) : ");
                temp = Enum.TryParse<Gender>(Console.ReadLine(), true, out gender);

            }
            // mobile number
            Console.Write("Enter Mobile number : ");
            string mobile = Console.ReadLine();
            while (mobile.Length != 10)
            {
                Console.Write("Enter valid Mobile number : ");
                mobile = Console.ReadLine();

            }
            //dob
            Console.Write("Enter DOB \"dd/MM/yyyy\" : ");
            temp = DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dob);
            while (!temp)
            {
                Console.Write("Enter valid DOB \"dd/MM/yyyy\" : ");
                temp = DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dob);

            }
            //mail id
            Console.Write("Enter mail id : ");
            string mailID = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(mailID))
            {
                Console.Write("Enter valid mail id : ");
                mailID = Console.ReadLine();
            }
            //Loation
            Console.Write("Enter Location : ");
            string location = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(location))
            {
                Console.Write("Enter valid location : ");
                location = Console.ReadLine();
            }
            // balance
            Console.Write("Enter balance amount: ");
            temp = int.TryParse(Console.ReadLine(), out int balance);
            while (!temp || balance < 1)
            {
                Console.Write("Enter valid balance amount: ");
                temp = int.TryParse(Console.ReadLine(), out balance);
            }
            //creating customer object

            CustomerDetails customer = new CustomerDetails(name, fatherName, gender, mobile, dob, mailID, location, balance);
            customersList.Add(customer);
            Console.WriteLine($"Customer registration successful Your Customer ID: {customer.CustomerID}");

        }   // main menu ends
        public static void CustomerLogin()
        {
            // customer id
            Console.Write("Enter customer id : ");
            string customerID = Console.ReadLine().ToUpper();
            bool temp = false;
            foreach (CustomerDetails customer in customersList)
            {
                if (customer.CustomerID.Equals(customerID))
                {
                    // if customer id present
                    temp = true;
                    Console.WriteLine($"Logged in successfully");
                    currentLoggedInUser = customer;
                    SubMenu();
                    break;
                }
            }
            if (!temp)
            {
                Console.WriteLine($"Invalid user ID");

            }
        } // customer login ends
        public static void SubMenu()
        {
            int choice;
            do
            {
                // loop until option 8
                Console.WriteLine($"-------------Sub Menu------------");
                Console.Write($"1.Show profile\n2.Order Food\n3.Cancel order\n4.Modify order\n5.Order history\n6.Recharge wallet\n7.Show wallet balance\n8.Exit\nEnter anyone of the options above : ");
                bool flag = int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine($"----Show Profile");
                            ShowProfile();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"----Order food");
                            OrderFood();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"----Cancel order");
                            CancelOrder();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine($"----Modify order");
                            ModifyOrder();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine($"----Order history");
                            OrderHistory();
                            break;
                        }

                    case 6:
                        {
                            Console.WriteLine($"----Recharge wallet");
                            RechargeWallet();
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine($"----Show wallet balance");
                            ShowWalletBalance();
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine($"Exiting application....");

                            break;
                        }
                    default:
                        {
                            Console.WriteLine($"Enter valid choice");

                            break;
                        }
                }

            } while (choice != 8);
        } //  submenu ends
        public static void ShowProfile()
        {
            Console.WriteLine($"Name :{currentLoggedInUser.Name}\nFather Name :{currentLoggedInUser.FatherName}\nGender :{currentLoggedInUser.Gender}\nMobile :{currentLoggedInUser.Mobile}\nDOB :{currentLoggedInUser.DOB.ToString("dd/MM/yyyy")}\nMail Id :{currentLoggedInUser.MailID}\nLocation :{currentLoggedInUser.Location}");

        } // ShowProfile ends
        public static void OrderFood()
        {
            int totalPrice = 0;
            // creating order object
            OrderDetails order = new OrderDetails(currentLoggedInUser.CustomerID, totalPrice, DateTime.Now, OrderStatus.Initiated);
            CustomList<ItemDetails> localItemList = new CustomList<ItemDetails>();

            bool temp = false;
            // checking food available or not
            foreach (FoodDetails food in foodsList)
            {
                if (food.QuantityAvailable > 0)
                {
                    temp = true;
                    break;
                }
            }
            string choice;
            // if food details present
            do
            {
                if (temp)
                {
                    string line = "------------------------------------------------------------------------------";
                    Console.WriteLine(line);

                    Console.WriteLine($"|{"Food ID",-10}|{"Food Name",-25}|{"Price per quantity",-18}|{"Quantity available",-20}|");
                    Console.WriteLine(line);
                    foreach (FoodDetails food in foodsList)
                    {
                        if (food.QuantityAvailable > 0)
                        {
                            Console.WriteLine($"|{food.FoodID,-10}|{food.FoodName,-25}|{food.PricePerQuantity,-18}|{food.QuantityAvailable,-20}|");
                            Console.WriteLine(line);
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"There is no food available");
                    return;
                }
                // get food id
                Console.Write("Enter Food id : ");
                string foodID = Console.ReadLine().ToUpper();
                temp = false;
                // checking food id available or not
                foreach (FoodDetails food in foodsList)
                {
                    if (food.FoodID.Equals(foodID) && food.QuantityAvailable > 0)
                    {
                        temp = true;
                        //quantity
                        Console.Write("Enter quantity you wish to purchase : ");
                        bool isValid = int.TryParse(Console.ReadLine(), out int orderQuantity);
                        while (!isValid || orderQuantity < 1)
                        {
                            Console.Write("Enter valid quantity to purchase: ");
                            isValid = int.TryParse(Console.ReadLine(), out orderQuantity);
                        }
                        // checking quantity available
                        if (food.QuantityAvailable >= orderQuantity)
                        {
                            int priceOfOrder = orderQuantity * food.PricePerQuantity;
                            ItemDetails item = new ItemDetails(order.OrderID, food.FoodID, orderQuantity, priceOfOrder);
                            food.QuantityAvailable -= orderQuantity;

                            // adding to tempitem list
                            localItemList.Add(item);
                            totalPrice += priceOfOrder;
                        }
                        else
                        {
                            Console.WriteLine($"Food is not available (out of stock)");
                        }

                    }
                }
                if (!temp)
                {
                    Console.WriteLine($"Enter valid food ID");

                }
                // getting for confirm purchase or not
                Console.Write($"Do you want to purchase more (yes/no) : ");
                choice = Console.ReadLine().ToLower();
                while (!(choice.Equals("yes") || choice.Equals("no")))
                {
                    Console.Write($"Enter valid choice (yes/no) to purchase more : ");
                    choice = Console.ReadLine().ToLower();
                }

            } while (choice.Equals("yes"));
            if (localItemList.Count == 0)
            {
                // if whislist is empty
                ordersList.Add(order);
                Console.WriteLine($"Since there is no item in whislist and you want to exit, the order {order.OrderID} is in initiated process. Exiting to submenu...");

                return;
            }
            Console.Write($"Do you want to confirm purchase (yes/no) :");
            choice = Console.ReadLine().ToLower();
            // if purchase confirm
            if (choice.Equals("yes"))
            {
                while (choice.Equals("yes"))
                {
                    // if balance sufficient to purchase
                    if (currentLoggedInUser.WalletBalance >= totalPrice)
                    {
                        currentLoggedInUser.DeductBalance(totalPrice);
                        order.TotalPrice = totalPrice;
                        order.OrderStatus = OrderStatus.Ordered;
                        itemsList.AddRange(localItemList);
                        ordersList.Add(order);
                        Console.WriteLine($"Order placed successfuly and order id is {order.OrderID}");

                        break;
                    }
                    else
                    {
                        //IF BALANCE INSUFFICIENT
                        Console.Write($"Insuffient wallet balance. Do you wish to recharge (yes/no) :");
                        choice = Console.ReadLine().ToLower();
                        while (!(choice.Equals("yes") || choice.Equals("no")))
                        {
                            Console.Write($"Enter valid choice (yes/no) to recharge :");
                            choice = Console.ReadLine().ToLower(); ;
                        }
                        if (choice.Equals("yes"))
                        {
                            // getting amount from user
                            Console.Write($"Price is {totalPrice}. You have {currentLoggedInUser.WalletBalance}. Enter amount to recharge ");
                            bool isValid = int.TryParse(Console.ReadLine(), out int amount);
                            while (!isValid || amount < 1)
                            {
                                Console.Write("Enter valid amount to recharge: ");
                                isValid = int.TryParse(Console.ReadLine(), out amount);
                            }
                            currentLoggedInUser.WalletRecharge(amount);
                            Console.WriteLine($"Recharge successfull and  You have {currentLoggedInUser.WalletBalance}");

                        }
                        else
                        {
                            //if doesnt want to recharge
                            foreach (ItemDetails item in localItemList)
                            {
                                foreach (FoodDetails food in foodsList)
                                {
                                    if (food.FoodID.Equals(item.FoodID))
                                    {
                                        food.QuantityAvailable += item.PurchaseCount;
                                    }
                                }
                            }
                            break;
                        }

                    }
                }
            }
            else
            {
                //returning item count to food list
                foreach (ItemDetails item in localItemList)
                {
                    foreach (FoodDetails food in foodsList)
                    {
                        if (food.FoodID.Equals(item.FoodID))
                        {
                            food.QuantityAvailable += item.PurchaseCount;
                        }
                    }
                }
            }

        }// order food ends
        public static void CancelOrder()
        {
            bool temp = false;
            // checking order history present or not
            foreach (OrderDetails order in ordersList)
            {
                if (order.CustomerID.Equals(currentLoggedInUser.CustomerID) && order.OrderStatus.Equals(OrderStatus.Ordered))
                {
                    temp = true;
                    break;
                }
            }
            // if order history present
            if (temp)
            {
                string line = "-----------------------------------------------------------------";
                Console.WriteLine(line);
                Console.WriteLine($"|{"Order ID",-10}|{"Customer ID",-11}|{"Total Price",-11}|{"Date Of order",-15}|{"Order Status",-12}|");
                Console.WriteLine(line);
                foreach (OrderDetails order in ordersList)
                {
                    if (order.CustomerID.Equals(currentLoggedInUser.CustomerID) && order.OrderStatus.Equals(OrderStatus.Ordered))
                    {
                        Console.WriteLine($"|{order.OrderID,-10}|{order.CustomerID,-11}|{order.TotalPrice,-11}|{order.DateOfOrder.ToString("dd/MM/yyyy"),-15}|{order.OrderStatus,-12}|");
                        Console.WriteLine(line);
                    }
                }
            }
            else
            {
                Console.WriteLine($"There is no order history for the current user.");
                return;
            }
            temp = false;
            Console.Write("Enter order id you wish to cancel : ");
            string orderID = Console.ReadLine().ToUpper();
            foreach (OrderDetails order in ordersList)
            {
                //checking if order id present or not
                if (order.CustomerID.Equals(currentLoggedInUser.CustomerID) && order.OrderStatus.Equals(OrderStatus.Ordered) && order.OrderID.Equals(orderID))
                {
                    temp = true;
                    order.OrderStatus = OrderStatus.Cancelled;
                    currentLoggedInUser.WalletRecharge(order.TotalPrice);
                    // returning food count
                    foreach (ItemDetails item in itemsList)
                    {
                        if (item.OrderID.Equals(orderID))
                        {
                            foreach (FoodDetails food in foodsList)
                            {
                                if (item.FoodID.Equals(food.FoodID))
                                {
                                    food.QuantityAvailable += item.PurchaseCount;
                                }
                            }
                        }
                    }
                    Console.WriteLine($"{orderID} cancelled successfully");

                    break;

                }
            }
            if (!temp)
            {
                Console.WriteLine($"order id is not present");

            }
        } // cancel order ends
        public static void ModifyOrder()
        {
            bool temp = false;
            // checking order history present or not
            foreach (OrderDetails order in ordersList)
            {
                if (order.CustomerID.Equals(currentLoggedInUser.CustomerID) && order.OrderStatus.Equals(OrderStatus.Ordered))
                {
                    temp = true;
                    break;
                }
            }
            // if order history present
            if (temp)
            {
                string line = "-----------------------------------------------------------------";
                Console.WriteLine(line);
                Console.WriteLine($"|{"Order ID",-10}|{"Customer ID",-11}|{"Total Price",-11}|{"Date Of order",-15}|{"Order Status",-12}|");
                Console.WriteLine(line);
                foreach (OrderDetails order in ordersList)
                {
                    if (order.CustomerID.Equals(currentLoggedInUser.CustomerID) && order.OrderStatus.Equals(OrderStatus.Ordered))
                    {
                        Console.WriteLine($"|{order.OrderID,-10}|{order.CustomerID,-11}|{order.TotalPrice,-11}|{order.DateOfOrder.ToString("dd/MM/yyyy"),-15}|{order.OrderStatus,-12}|");
                        Console.WriteLine(line);
                    }
                }
            }
            else
            {
                Console.WriteLine($"There is no order history for the current user");
                return;
            }
            temp = false;
            Console.Write("Enter order id you wish to modify : ");
            string orderID = Console.ReadLine().ToUpper();
            foreach (OrderDetails order in ordersList)
            {
                //checking if order id present or not
                if (order.CustomerID.Equals(currentLoggedInUser.CustomerID) && order.OrderStatus.Equals(OrderStatus.Ordered) && order.OrderID.Equals(orderID))
                {
                    temp = true;
                    bool isPresent = false;
                    string line = "------------------------------------------------------------------";
                    Console.WriteLine(line);
                    Console.WriteLine($"|{"Item ID",-10}|{"OrderID",-10}|{"Food ID",-10}|{"Purchase count",-15}|{"Price of order",-15}|");
                    Console.WriteLine(line);

                    foreach (ItemDetails item in itemsList)
                    {
                        if (item.OrderID.Equals(order.OrderID))
                        {
                            Console.WriteLine($"|{item.ItemID,-10}|{item.OrderID,-10}|{item.FoodID,-10}|{item.PurchaseCount,-15}|{item.PriceOfOrder,-15}|");
                            Console.WriteLine(line);
                        }
                    }
                    Console.Write("Enter item id you wish to modify : ");
                    string itemID = Console.ReadLine().ToUpper();
                    //checking if item id present or not
                    foreach (ItemDetails item in itemsList)
                    {
                        if (item.ItemID.Equals(itemID))
                        {
                            isPresent = true;
                            // getting quantity 
                            Console.Write("Enter quantity you wish to modify : ");
                            bool isValid = int.TryParse(Console.ReadLine(), out int newQuantity);
                            while (!isValid || newQuantity < 1)
                            {
                                Console.Write("Enter valid quantity to modify: ");
                                isValid = int.TryParse(Console.ReadLine(), out newQuantity);
                            }
                            int quantityDiff = newQuantity - item.PurchaseCount;

                            int diffPrice;
                            //checking if quantity is presnet in food details
                            foreach (FoodDetails food in foodsList)
                            {
                                if (food.FoodID.Equals(item.FoodID))
                                {
                                    if (food.QuantityAvailable >= quantityDiff)
                                    {
                                        // if quantity in food details is available modify all details in orders and items
                                        diffPrice = quantityDiff * food.PricePerQuantity;
                                        while (diffPrice > currentLoggedInUser.WalletBalance)
                                        {
                                            //untill user has balance
                                            Console.Write($"you need {diffPrice - currentLoggedInUser.WalletBalance}. Enter amount to recharge: ");
                                            isValid = int.TryParse(Console.ReadLine(), out int amount);
                                            while (!isValid || amount < 1)
                                            {
                                                Console.Write("Enter valid amount to recharge: ");
                                                temp = int.TryParse(Console.ReadLine(), out amount);
                                            }
                                            currentLoggedInUser.WalletRecharge(amount);

                                        }
                                        if (diffPrice <= currentLoggedInUser.WalletBalance)
                                        {

                                            //if balance is available
                                            if (diffPrice < 0)
                                            {
                                                // if decreased
                                                currentLoggedInUser.WalletRecharge(Math.Abs(diffPrice));
                                            }
                                            else if (diffPrice > 0)
                                            {
                                                //if quantity increased
                                                currentLoggedInUser.DeductBalance(diffPrice);
                                            }
                                            //change those orders and items
                                            food.QuantityAvailable -= quantityDiff;
                                            item.PurchaseCount = newQuantity;
                                            item.PriceOfOrder += diffPrice;
                                            order.TotalPrice += diffPrice;
                                            Console.WriteLine($"Order ID {order.OrderID} Modified successfully");

                                            break;

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Quantity is not available");

                                    }
                                }
                            }
                        }

                    }
                    if (!isPresent)
                    {
                        Console.WriteLine($"Item id is not present");

                    }

                }
            }
            if (!temp)
            {
                Console.WriteLine($"Order id is not valid");

            }

        }// modifyy order ends
        public static void OrderHistory()
        {
            bool temp = false;
            // checking order history present or not
            foreach (OrderDetails order in ordersList)
            {
                if (order.CustomerID.Equals(currentLoggedInUser.CustomerID))
                {
                    temp = true;
                    break;
                }
            }
            // if order history present
            if (temp)
            {
                string line = "-----------------------------------------------------------------";
                Console.WriteLine(line);
                Console.WriteLine($"|{"Order ID",-10}|{"Customer ID",-11}|{"Total Price",-11}|{"Date Of order",-15}|{"Order Status",-12}|");
                Console.WriteLine(line);
                foreach (OrderDetails order in ordersList)
                {
                    if (order.CustomerID.Equals(currentLoggedInUser.CustomerID))
                    {
                        Console.WriteLine(line);
                        Console.WriteLine($"|{order.OrderID,-10}|{order.CustomerID,-11}|{order.TotalPrice,-11}|{order.DateOfOrder.ToString("dd/MM/yyyy"),-15}|{order.OrderStatus,-12}|");

                    }
                }
            }
            else
            {
                Console.WriteLine($"There is no order history for the current user");

            }
        }// order history ends
        public static void RechargeWallet()
        {
            // getting amount from user
            Console.Write("Enter amount to recharge: ");
            bool temp = int.TryParse(Console.ReadLine(), out int amount);
            while (!temp || amount < 1)
            {
                Console.Write("Enter valid amount to recharge: ");
                temp = int.TryParse(Console.ReadLine(), out amount);
            }
            currentLoggedInUser.WalletRecharge(amount);
            Console.WriteLine($"Recharged successfully");

        } // order history ends
        public static void ShowWalletBalance()
        {
            Console.WriteLine($"Wallet balance : {currentLoggedInUser.WalletBalance}.");

        } //  show wallet balance ends
    }
}