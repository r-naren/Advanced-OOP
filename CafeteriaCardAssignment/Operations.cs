using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
namespace CafeteriaCardAssignment;

public static class Operations
{
    //Current logged in user delcaration
    public static UserDetails currentLoggedInUser;
    // Declaring lists for the classes
    public static CustomList<UserDetails> usersList = new CustomList<UserDetails>();
    public static CustomList<OrderDetails> ordersList = new CustomList<OrderDetails>();
    public static CustomList<FoodDetails> foodsList = new CustomList<FoodDetails>();
    public static CustomList<CartItem> cartItems = new CustomList<CartItem>();
    //Assigning default values
    public static void AddDefaultValue()
    {
        UserDetails user1 = new UserDetails("Ravichandran", "Ettaparajan", "8857777575", "ravi@gmail.com", Gender.Male, "WS101", 400);
        UserDetails user2 = new UserDetails("Baskaran", "Sethurajan", "9577747744", "baskaran@gmail.com", Gender.Male, "WS105", 500);
        usersList.Add(user1);
        usersList.Add(user2);
        OrderDetails order1 = new OrderDetails("SF1001", new DateTime(2022, 06, 15), 70, OrderStatus.Ordered);
        OrderDetails order2 = new OrderDetails("SF1002", new DateTime(2022, 06, 15), 100, OrderStatus.Ordered);
        ordersList.Add(order1);
        ordersList.Add(order2);
        CartItem cartItem1 = new CartItem("OID1001", "FID101", 20, 1);
        CartItem cartItem2 = new CartItem("OID1001", "FID103", 10, 1);
        CartItem cartItem3 = new CartItem("OID1001", "FID105", 40, 1);
        CartItem cartItem4 = new CartItem("OID1002", "FID103", 10, 1);
        CartItem cartItem5 = new CartItem("OID1002", "FID104", 50, 1);
        CartItem cartItem6 = new CartItem("OID1002", "FID105", 40, 1);
        cartItems.AddRange(new CustomList<CartItem> { cartItem1, cartItem2, cartItem3, cartItem4, cartItem5, cartItem6 });
        FoodDetails foodItem1 = new FoodDetails("Coffee", 20, 100);
        FoodDetails foodItem2 = new FoodDetails("Tea", 15, 100);
        FoodDetails foodItem3 = new FoodDetails("Biscuit", 10, 100);
        FoodDetails foodItem4 = new FoodDetails("Juice", 50, 100);
        FoodDetails foodItem5 = new FoodDetails("Puff", 40, 100);
        FoodDetails foodItem6 = new FoodDetails("Milk", 10, 100);
        FoodDetails foodItem7 = new FoodDetails("Popcorn", 20, 20);
        foodsList.AddRange(new CustomList<FoodDetails> { foodItem1, foodItem2, foodItem3, foodItem4, foodItem5, foodItem6, foodItem7 });
    } // Added default values ends
    //Main menu starts
    public static void MainMenu()
    {
        Console.WriteLine($"***************Welcome To Cafeteria Card Management***************");
        int choice = 0;
        bool flag;
        do
        {
            // Iterate until user gives exit
            Console.WriteLine($"----------Main Menu----------");
            Console.WriteLine($"1. User Registration\n2. User Login\n3. Exit");
            Console.Write("Select any one of the options above : ");
            flag = int.TryParse(Console.ReadLine(), out choice);
            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine($"*********User Registration********");
                        UserRegistration();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine($"*********User Login********");
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
                        Console.WriteLine($"Enter valid option.");
                        break;
                    }
            }
        } while (choice != 3);
    }// Mainmenu ends
    public static void UserRegistration()
    {
        bool flag = false;
        Gender gender;
        // Getting student name
        Console.Write($"Enter your Name : ");
        string userName = Console.ReadLine();
        while (string.IsNullOrEmpty(userName))
        {
            Console.Write("Name can't be empty. Enter Your Name: ");
            userName = Console.ReadLine();
        }
        // Getting father name
        Console.Write($"Enter your Father Name : ");
        string fatherName = Console.ReadLine();
        while (string.IsNullOrEmpty(fatherName))
        {
            Console.Write("Father Name can't be empty. Enter Your Father Name: ");
            fatherName = Console.ReadLine();
        }
        // Getting mobile number
        Console.Write($"Enter your Mobile Number : ");
        System.Text.RegularExpressions.Regex phoneCheck = new System.Text.RegularExpressions.Regex(@"[6-9]{1}[0-9]{9}$");
        string mobileNumber = Console.ReadLine();
        while (!phoneCheck.IsMatch(mobileNumber) || mobileNumber.Length != 10)
        {
            Console.Write("Enter valid mobile number. Enter Your Phone number: ");
            mobileNumber = Console.ReadLine();
        }
        // Getting mail id
        Console.Write($"Enter your Mail ID : ");
        System.Text.RegularExpressions.Regex mailCheck = new System.Text.RegularExpressions.Regex(@"^[A-Za-z0-9._-]+@[A-Za-z0-9.]+[A-Za-z]{2,5}$");
        string mailID = Console.ReadLine();
        while (!mailCheck.IsMatch(mailID))
        {
            Console.Write("Enter valid Mail ID. Enter Your mail ID: ");
            mailID = Console.ReadLine();
        }
        //Getting gender
        Console.Write($"Enter you Gender : ");
        flag = Enum.TryParse<Gender>(Console.ReadLine(), true, out gender);
        while (!flag)
        {
            Console.Write($"Enter valid Gender. Enter Gender again: ");
            flag = Enum.TryParse<Gender>(Console.ReadLine(), true, out gender);
        }
        //Getting Workstation number
        Console.Write($"Enter your workstation number : ");
        string workStationNumber = Console.ReadLine().ToUpper();
        while (!workStationNumber.Contains("WS"))
        {
            Console.Write("Enter valid Workstation number : ");
            workStationNumber = Console.ReadLine().ToUpper();
        }
        // Getting wallet balance
        Console.Write("Enter Wallet balance : ");
        flag = double.TryParse(Console.ReadLine(), out double balance);
        while (!flag || balance <= 0)
        {
            Console.Write($"Enter valid balance amount : ");
            flag = double.TryParse(Console.ReadLine(), out balance);
        }
        // Creating user details object
        UserDetails user = new UserDetails(userName, fatherName, mobileNumber, mailID, gender, workStationNumber, balance);
        // adding user object to userslist
        usersList.Add(user);
        Console.WriteLine($"User Registration is successful. User ID is {user.UserID}");

    }// User registration Ends
    // userlogin starts
    public static void UserLogin()
    {
        string userID;
        Console.Write($"Enter User ID for login : ");
        userID = Console.ReadLine().ToUpper();
        currentLoggedInUser = UserDetails.BinarySearch(userID, usersList);
        if (currentLoggedInUser != null)
        {
            Console.WriteLine($"Logged in Successfully");
            SubMenu();
        }
        else
        {
            Console.WriteLine($"Enter valid User ID or User ID is not present.");
        }
    }//userLogin ends
     //Submenu starts
    public static void SubMenu()
    {
        int choice = 0;
        bool flag;
        do
        {
            // Iterate until user gives exit option
            Console.WriteLine($"----------Sub Menu----------");
            Console.WriteLine($"1. Show My Profile\n2. Food Order\n3. Modify Order\n4. Cancel Order\n5. Order History\n6. Wallet Recharge\n7. Show Walletbalance\n8. Exit");
            Console.Write("Select any one of the options above : ");
            flag = int.TryParse(Console.ReadLine(), out choice);
            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine($"*********Show My Profile********");
                        ShowMyProfile();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine($"*********Food Order********");
                        FoodOrder();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine($"*********Modify order********");
                        ModifyOrder();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine($"*********Cancel Order********");
                        CancelOrder();
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine($"*********Order History********");
                        OrderHistory();
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine($"*********Wallet recharge********");
                        WalletRecharge();
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine($"*********Show Wallet balance********");
                        ShowWalletBalance();
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine($"Logout Successful. Exiting to Main Menu.");
                        break;
                    }
                default:
                    {
                        Console.WriteLine($"Enter valid option.");
                        break;
                    }
            }
        } while (choice != 8);
    }
    public static void ShowMyProfile()
    {
        currentLoggedInUser.ShowMyProfile();

    }// Show my profile ends
    public static void FoodOrder()
    {
        bool temp = false;
        foreach (FoodDetails food in foodsList)
        {
            if (food.AvailableQuantity > 0)
            {
                temp = true;
                break;
            }
        }
        if (temp)
        {
            // if food is present 
            Console.WriteLine($"|{"Food ID",-10}|{"Food Name",-20}|{"Price",-5}|{"Available Quantity",-18}|");
            foreach (FoodDetails food in foodsList)
            {
                if (food.AvailableQuantity > 0)
                {
                    Console.WriteLine($"|{food.FoodID,-10}|{food.FoodName,-20}|{food.FoodPrice,-5}|{food.AvailableQuantity,-18}|");
                }
            }
            // temporary cart item list
            CustomList<CartItem> tempCartItemList = new CustomList<CartItem>();
            OrderDetails order = new OrderDetails(currentLoggedInUser.UserID, DateTime.Now, 0, OrderStatus.Initiated);
            string choice = "yes";
            double totalPrice = 0;
            do
            {
                //User to pick a food id
                Console.Write($"Enter Food ID to add to cart : ");
                string foodID = Console.ReadLine().ToUpper();
                //checking if food id present or not
                temp = false;
                foreach (FoodDetails food in foodsList)
                {
                    if (food.FoodID.Equals(foodID))
                    {
                        temp = true;
                        // checking for availabilty count
                        Console.Write($"Enter quantity you wish to purchase : ");

                        bool isValid = int.TryParse(Console.ReadLine(), out int userQuantity);
                        while (!isValid || userQuantity < 1)
                        {
                            Console.Write($"Enter valid food quantity : ");
                            int.TryParse(Console.ReadLine(), out userQuantity);
                        }
                        if (food.AvailableQuantity >= userQuantity)
                        {
                            // calculating total
                            totalPrice += food.FoodPrice * userQuantity;
                            // reducing quantity
                            food.AvailableQuantity -= userQuantity;
                            //creating cart item
                            CartItem cartItem = new CartItem(order.OrderID, foodID, food.FoodPrice * userQuantity, userQuantity);
                            // adding to temp cart item list
                            tempCartItemList.Add(cartItem);
                        }
                        else
                        {
                            Console.WriteLine($"There is no available quantity. Currently have  {food.AvailableQuantity}");
                        }
                        break;
                    }
                }
                if (!temp)
                {
                    Console.WriteLine($"Food ID is not present");

                }
                // ask whether user wish to purchase again
                Console.Write($"Do you want to purchase another product and add to cart (yes/no) : ");
                choice = Console.ReadLine();
                while (!(choice.ToLower().Equals("yes") || choice.ToLower().Equals("no")))
                {
                    Console.Write($"Enter valid choice (yes/no) : ");
                    choice = Console.ReadLine();

                }
            } while (choice.ToLower().Equals("yes"));
            // displaying cart items
            if (tempCartItemList.Count != 0)
            {
                Console.WriteLine($"|{"Item ID",-10}|{"Order ID",-10}|{"Food ID",-10}|{"Order price",-11}|{"Order Quantity",-15}|");
                foreach (CartItem item in tempCartItemList)
                {
                    Console.WriteLine($"|{item.ItemID,-10}|{item.OrderID,-10}|{item.FoodID,-10}|{item.OrderPrice,-11}|{item.OrderQuantity,-15}|");

                }
                Console.Write($"Do you wish to confirm the purchase (yes/no) : ");
                choice = Console.ReadLine();
                do
                {
                    if (!(choice.ToLower().Equals("yes") || choice.ToLower().Equals("no")))
                    {
                        Console.Write($"Enter valid choice. Do you wish to confirm the purchase (yes/no) : ");
                        choice = Console.ReadLine();
                    }
                    if (choice.ToLower().Equals("yes"))
                    {
                        //if user wish to purchase
                        if (totalPrice <= currentLoggedInUser.WalletBalance)
                        {
                            //deduct amount
                            currentLoggedInUser.DeductAmount(totalPrice);
                            //cart items assigning
                            cartItems = tempCartItemList;
                            order.OrderStatus = OrderStatus.Ordered;
                            order.TotalPrice = totalPrice;
                            ordersList.Add(order);
                            Console.WriteLine($"Order placed successfully and order id is {order.OrderID}");
                            break;
                        }
                        else
                        {
                            // if balance is less
                            Console.Write($"In sufficient balance to purchase. Do you wish to recharge (yes/no) : ");
                            choice = Console.ReadLine();
                            while (!(choice.ToLower().Equals("yes") || choice.ToLower().Equals("no")))
                            {
                                Console.Write($"Enter valid choice (yes/no) : ");
                                choice = Console.ReadLine();

                            }
                            if (choice.ToLower().Equals("yes"))
                            {
                                Console.Write($"Total price is {totalPrice}. you have {currentLoggedInUser.WalletBalance} Enter amount to recharge : ");
                                bool flag = double.TryParse(Console.ReadLine(), out double amount);
                                while (!flag || amount < totalPrice - currentLoggedInUser.WalletBalance)
                                {
                                    Console.Write($"Enter valid amount to recharge : ");
                                    flag = double.TryParse(Console.ReadLine(), out amount);
                                }
                                currentLoggedInUser.WalletRecharge(amount);
                                //deduct amount
                                currentLoggedInUser.DeductAmount(totalPrice);
                                //cart items assigning
                                cartItems = tempCartItemList;
                                order.OrderStatus = OrderStatus.Ordered;
                                order.TotalPrice = totalPrice;
                                ordersList.Add(order);
                                Console.WriteLine($"Order placed successfully and order id is {order.OrderID}");
                                break;
                            }
                            else if (choice.ToLower().Equals("no"))
                            {
                                Console.WriteLine($"Exiting without Order due to insufficient balance");
                            }
                            //if balance is less
                        }

                    }
                    else if (choice.ToLower().Equals("no"))
                    {
                        // if order not confirmed revresing quantity
                        foreach (CartItem item in tempCartItemList)
                        {
                            foreach (FoodDetails food in foodsList)
                            {
                                if (item.FoodID.Equals(food.FoodID))
                                {
                                    food.AvailableQuantity += item.OrderQuantity;
                                    break;
                                }
                            }
                        }
                        Console.WriteLine($"Exiting without Order because user not wished topurchase");

                    }
                } while (!(choice.ToLower().Equals("yes") || choice.ToLower().Equals("no")));

            }

        }
        else
        {
            Console.WriteLine($"All foods are out of stock");

        }
    }// Food order ends
    public static void ModifyOrder()
    {
        OrderHistory();
        bool flag = false;
        Console.Write($"Enter Order Id : ");
        string orderID = Console.ReadLine().ToUpper();
        // Checking if order id is present or not
        foreach (OrderDetails order in ordersList)
        {
            if (order.OrderID.Equals(orderID) && order.OrderStatus.Equals(OrderStatus.Ordered))
            {
                flag = true;
                Console.WriteLine($"|{"Item ID",-10}|{"Order ID",-10}|{"Food ID",-10}|{"Order price",-11}|{"Order Quantity",-15}|");
                foreach (CartItem item in cartItems)
                { // displaying cart details for current order id
                    if (item.OrderID.Equals(orderID))
                    {
                        Console.WriteLine($"|{item.ItemID,-10}|{item.OrderID,-10}|{item.FoodID,-10}|{item.OrderPrice,-11}|{item.OrderQuantity,-15}|");
                    }
                }
                Console.Write($"Enter item id from the list : ");
                string itemID = Console.ReadLine().ToUpper();
                bool isPresent = false;
                foreach (CartItem item in cartItems)
                {
                    if (item.ItemID.Equals(itemID) && item.OrderID.Equals(orderID))
                    {
                        isPresent = true;
                        // if itemm is presnet change the quantity and price
                        Console.Write($"Enter new quantity : ");
                        bool isValid = int.TryParse(Console.ReadLine(), out int newQuantity);
                        while (!isValid || newQuantity < 1)
                        {
                            Console.Write($"Enter valid new quantity : ");
                            isValid = int.TryParse(Console.ReadLine(), out newQuantity);
                        }
                        // Checking quantity is available or not
                        isValid = false;
                        int diff = newQuantity - item.OrderQuantity;
                        foreach (FoodDetails food in foodsList)
                        {
                            if (food.FoodID.Equals(item.FoodID) && Math.Abs(diff) <= food.AvailableQuantity)
                            {
                                isValid = true;
                                if (diff * (item.OrderPrice / item.OrderQuantity) <= currentLoggedInUser.WalletBalance)
                                {
                                    //updating item details
                                    order.TotalPrice -= item.OrderPrice;
                                    item.OrderPrice = item.OrderPrice / item.OrderQuantity;
                                    currentLoggedInUser.WalletRecharge(item.OrderPrice * item.OrderQuantity);
                                    item.OrderQuantity = newQuantity;
                                    item.OrderPrice *= item.OrderQuantity;
                                    order.TotalPrice += item.OrderPrice;
                                    currentLoggedInUser.DeductAmount(item.OrderPrice);
                                    Console.WriteLine($"Order modified successfully");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"Invalid wallet balance. Recharge amount first.");
                                    break;
                                }
                            }
                        }
                        if (!isValid)
                        {
                            Console.WriteLine($"Quantity is not available ");
                        }
                    }
                }
                if (!isPresent)
                {
                    Console.WriteLine($"Item Id is not present");
                }
                break;
            }
        }
        if (!flag)
        {
            Console.WriteLine($"Invalid order ID");

        }
    }// Modify Order ends
    public static void CancelOrder()
    {
        OrderHistory();
        bool flag = false;
        Console.Write($"Enter Order Id : ");
        string orderID = Console.ReadLine().ToUpper();
        // Checking if order id is present or not
        foreach (OrderDetails order in ordersList)
        {
            if (order.OrderID.Equals(orderID) && order.OrderStatus.Equals(OrderStatus.Ordered))
            {
                flag = true;
                currentLoggedInUser.WalletRecharge(order.TotalPrice);
                // returning food quantity
                foreach (CartItem item in cartItems)
                {
                    if (order.OrderID.Equals(item.OrderID))
                    {
                        foreach (FoodDetails food in foodsList)
                        {
                            if (item.FoodID.Equals(food.FoodID))
                            {
                                food.AvailableQuantity += item.OrderQuantity;
                                break;
                            }
                        }
                    }
                }
                order.OrderStatus = OrderStatus.Cancelled;
                Console.WriteLine($"Order cancelled successfully");
            }
        }
        if (!flag)
        {
            Console.WriteLine($"Invalid order ID");

        }

    } //Cancel Order ends
    public static void OrderHistory()
    {
        bool flag = false;
        // to check order id present or not
        foreach (OrderDetails order in ordersList)
        {
            if (order.UserID.Equals(currentLoggedInUser.UserID))
            {
                flag = true;
                break;
            }
        }
        if (flag)
        {
            Console.WriteLine($"|{"Order ID",-10}|{"User ID",-10}|{"Order Date",-15}|{"Total Price",-11}|{"Order status",-12}|");
            // if user is is present in orders
            for (int i = ordersList.Count - 1; i >= 0; i--)
            {
                if (ordersList[i].UserID.Equals(currentLoggedInUser.UserID))
                {
                    Console.WriteLine($"|{ordersList[i].OrderID,-10}|{ordersList[i].UserID,-10}|{ordersList[i].OrderDate.ToString("dd/MM/yyyy"),-15}|{ordersList[i].TotalPrice,-11}|{ordersList[i].OrderStatus,-12}|");
                }
            }
        }
        else
        {
            Console.WriteLine($"User didn't have order histroy");

        }
    } // Order history ends
    public static void WalletRecharge()
    {
        //Get user input for amount to recharge
        Console.Write("Enter amount to recharge : ");
        bool flag = double.TryParse(Console.ReadLine(), out double amount);
        while (!flag || amount <= 0)
        {
            Console.Write($"Enter valid amount to recharge : ");
            flag = double.TryParse(Console.ReadLine(), out amount);
        }
        currentLoggedInUser.WalletRecharge(amount);
    } //  wallet recharge ends
    public static void ShowWalletBalance()
    {
        Console.WriteLine($"Wallet Balance : {currentLoggedInUser.WalletBalance}");

    } // wallet balance ends

}
