using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace OnlineGroceryShop
{
    public static class Operations
    {
        public static CustomerRegistration currentLoggedInUser;
        public static CustomList<BookingDetails> bookingsList = new CustomList<BookingDetails>();
        public static CustomList<CustomerRegistration> customersList = new CustomList<CustomerRegistration>();
        public static CustomList<OrderDetails> ordersList = new CustomList<OrderDetails>();
        public static CustomList<ProductDetails> productsList = new CustomList<ProductDetails>();
        public static void AddDefaultData()
        {
            CustomerRegistration customer1 = new CustomerRegistration("Ravi", "Ettaparajan", Gender.Male, "974774646", "ravi@gmail.com", new DateTime(1999, 11, 11), 10000);
            CustomerRegistration customer2 = new CustomerRegistration("Baskaran", "Sethurajan", Gender.Male, "847575775", "baskaran@gmail.com", new DateTime(1999, 11, 11), 15000);
            customersList.Add(customer1);
            customersList.Add(customer2);
            ProductDetails product1 = new ProductDetails("Sugar", 20, 40);
            ProductDetails product2 = new ProductDetails("Rice", 100, 50);
            ProductDetails product3 = new ProductDetails("Milk", 10, 40);
            ProductDetails product4 = new ProductDetails("Coffee", 10, 10);
            ProductDetails product5 = new ProductDetails("Tea", 10, 10);
            ProductDetails product6 = new ProductDetails("Masala Powder", 10, 20);
            ProductDetails product7 = new ProductDetails("Salt", 10, 10);
            ProductDetails product8 = new ProductDetails("Turmeric Powder", 10, 25);
            ProductDetails product9 = new ProductDetails("ChilliPowder", 10, 20);
            ProductDetails product10 = new ProductDetails("Groundnut Oil", 10, 140);
            productsList.AddRange(new CustomList<ProductDetails> { product1, product2, product3, product4, product5, product6, product7, product8, product9, product10 });
            BookingDetails booking1 = new BookingDetails("CID1001", 220, new DateTime(2022, 07, 26), BookingStatus.Booked);
            BookingDetails booking2 = new BookingDetails("CID1002", 400, new DateTime(2022, 07, 26), BookingStatus.Booked);
            BookingDetails booking3 = new BookingDetails("CID1001", 280, new DateTime(2022, 07, 26), BookingStatus.Cancelled);
            BookingDetails booking4 = new BookingDetails("CID1002", 0, new DateTime(2022, 07, 26), BookingStatus.Initiated);
            bookingsList.Add(booking1);
            bookingsList.Add(booking2);
            bookingsList.Add(booking3);
            bookingsList.Add(booking4);
            OrderDetails order1 = new OrderDetails("BID3001", "PID2001", 2, 80);
            OrderDetails order2 = new OrderDetails("BID3001", "PID2002", 2, 100);
            OrderDetails order3 = new OrderDetails("BID3001", "PID2003", 1, 40);
            OrderDetails order4 = new OrderDetails("BID3002", "PID2001", 1, 40);
            OrderDetails order5 = new OrderDetails("BID3002", "PID2002", 4, 200);
            OrderDetails order6 = new OrderDetails("BID3002", "PID2010", 1, 140);
            OrderDetails order7 = new OrderDetails("BID3002", "PID2009", 1, 20);
            OrderDetails order8 = new OrderDetails("BID3003", "PID2002", 2, 100);
            OrderDetails order9 = new OrderDetails("BID3003", "PID2008", 4, 100);
            OrderDetails order10 = new OrderDetails("BID3003", "PID2001", 2, 80);
            ordersList.AddRange(new CustomList<OrderDetails> { order1, order2, order3, order4, order5, order6, order7, order8, order9, order10 });
        }// Added default value
        public static void MainMenu()
        {
            Console.WriteLine($"***************Welcome To Online grocery store***************");
            int choice = 0;
            bool flag;
            do
            {
                // Iterate until user gives exit
                Console.WriteLine($"----------Main Menu----------");
                Console.WriteLine($"1. Customer Registration\n2. Customer Login\n3. Exit");
                Console.Write("Select any one of the options above : ");
                flag = int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine($"*********Customer Registration********");
                            CustomerRegister();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"*********Customer Login********");
                            CustomerLogin();
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
        public static void CustomerRegister()
        {
            bool flag = false;
            Gender gender;
            // Getting student name
            Console.Write($"Enter your Name : ");
            string name = Console.ReadLine();
            while (string.IsNullOrEmpty(name))
            {
                Console.Write("Name can't be empty. Enter Your Name: ");
                name = Console.ReadLine();
            }
            // Getting father name
            Console.Write($"Enter your Father Name : ");
            string fatherName = Console.ReadLine();
            while (string.IsNullOrEmpty(fatherName))
            {
                Console.Write("Father Name can't be empty. Enter Your Father Name: ");
                fatherName = Console.ReadLine();
            }
            //Getting gender
            Console.Write($"Enter you Gender : ");
            flag = Enum.TryParse<Gender>(Console.ReadLine(), true, out gender);
            while (!flag)
            {
                Console.Write($"Enter valid Gender. Enter Gender again: ");
                flag = Enum.TryParse<Gender>(Console.ReadLine(), true, out gender);
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
            //Getting DOB
            Console.Write($"Enter your DOB : ");
            DateTime dob;
            flag = DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dob);
            while (!flag)
            {
                Console.Write("Enter valid DOB : ");
                flag = DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dob);
            }
            // Getting wallet balance
            Console.Write("Enter Wallet balance : ");
            flag = double.TryParse(Console.ReadLine(), out double balance);
            while (!flag || balance <= 0)
            {
                Console.Write($"Enter valid balance amount : ");
                flag = double.TryParse(Console.ReadLine(), out balance);
            }
            // Creating customer details object
            CustomerRegistration customer = new CustomerRegistration(name, fatherName, gender, mobileNumber, mailID, dob, balance);
            // adding customer object to customerlist
            customersList.Add(customer);
            Console.WriteLine($"Customer Registration is successful. Customer ID is {customer.CustomerID}");

        } //Customer registration ends
        public static void CustomerLogin()
        {
            string customerID;
            Console.Write($"Enter Customer ID for login : ");
            customerID = Console.ReadLine().ToUpper();
            currentLoggedInUser = CustomerRegistration.BinarySearch(customerID, customersList);
            if (currentLoggedInUser != null)
            {
                Console.WriteLine($"Logged in Successfully");
                SubMenu();
            }
            else
            {
                Console.WriteLine($"Enter valid Customer ID or Customer ID is not present.");
            }
        } // Customer login ends
        public static void SubMenu()
        {
            int choice = 0;
            bool flag;
            do
            {
                // Iterate until user gives exit option
                Console.WriteLine($"----------Sub Menu----------");
                Console.WriteLine($"1. Show Customer Details\n2. Show Product Details\n3. Wallet Recharge\n4. Take Order\n5. Modify Order quantity\n6. Cancel Order\n7. Show balance\n8. Exit");
                Console.Write("Select any one of the options above : ");
                flag = int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine($"*********Show Customer Details********");
                            currentLoggedInUser.ShowCustomerDetails();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"*********Show Product Details********");
                            ShowProductDetails();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"*********Wallet Recharge********");
                            WalletRecharge();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine($"*********Take Order********");
                            TakeOrder();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine($"*********Modify Order Quantity********");
                            ModifyOrderQuantity();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine($"*********Cancel Order********");
                            CancelOrder();
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine($"*********Show balance********");
                            currentLoggedInUser.ShowBalance();
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
        } // submenu ends
        public static void ShowProductDetails()
        {
            bool temp = false;
            foreach (ProductDetails product in productsList)
            {
                if (product.AvailableQuantity > 0)
                {
                    temp = true;
                    break;
                }
            }
            if (temp)
            {
                Console.WriteLine($"|{"Product ID",-10}|{"Product Name",-20}|{"Available Quantity",-18}|{"Price per quantity",-20}|");

                foreach (ProductDetails product in productsList)
                {
                    if (product.AvailableQuantity > 0)
                    {
                        Console.WriteLine($"|{product.ProductID,-10}|{product.ProductName,-20}|{product.AvailableQuantity,-18}|{product.PricePerQuantity,-20}|");
                    }
                }
            }
            else
            {
                Console.WriteLine($"There is no product available");

            }
        }// product display ends
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
        }// Wallet Rechargeends
        public static void TakeOrder()
        {
            Console.Write($"Do you want to purchase (yes/no) : ");
            string choice = Console.ReadLine().ToLower();

            if (choice.Equals("yes"))
            {
                double totalPurchaseAmount = 0;
                // if choice yes  to purchase
                BookingDetails booking = new BookingDetails(currentLoggedInUser.CustomerID, 0, DateTime.Now, BookingStatus.Initiated);
                // creating temp order list
                CustomList<OrderDetails> tempOrderList = new CustomList<OrderDetails>();
                do
                {
                    ShowProductDetails();
                    Console.Write($"Enter product ID you want to purchase : ");
                    string productID = Console.ReadLine().ToUpper();
                    bool temp = false;
                    int quantity;
                    foreach (ProductDetails product in productsList)
                    {
                        if (product.ProductID.Equals(productID))
                        {
                            temp = true;
                            if (product.AvailableQuantity > 0)
                            {
                                //asking quantity
                                Console.Write($"Enter quantity you wish to purchase : ");
                                bool isValid = int.TryParse(Console.ReadLine(), out quantity);
                                while (!isValid || quantity < 1)
                                {
                                    Console.Write($"Enter valid quantity you wish to purchase : ");
                                    isValid = int.TryParse(Console.ReadLine(), out quantity);

                                }
                                if (product.AvailableQuantity >= quantity)
                                {
                                    //adding order
                                    OrderDetails order = new OrderDetails(booking.BookingID, product.ProductID, quantity, quantity * product.PricePerQuantity);
                                    tempOrderList.Add(order);
                                    product.AvailableQuantity -= quantity;
                                    totalPurchaseAmount += quantity * product.PricePerQuantity;
                                    Console.WriteLine($"Product successfully added to the cart");
                                }
                                else
                                {
                                    Console.WriteLine($"Quantity is not available");

                                }
                            }
                            else
                            {
                                Console.WriteLine($"Product is out of stock.");

                            }
                            break;
                        }
                    }
                    if (!temp)
                    {
                        Console.WriteLine($"Product ID is invalid");
                    }
                    Console.Write($"Do you want to purchase again (yes/no) : ");
                    choice = Console.ReadLine().ToLower();
                } while (choice == "yes");
                // after all items added to cart
                Console.Write($"Do you want to confirm order (yes/no) : ");
                choice = Console.ReadLine().ToLower();
                if (choice.Equals("yes"))
                {
                    do
                    {
                        if (totalPurchaseAmount <= currentLoggedInUser.WalletBalance)
                        {
                            currentLoggedInUser.WalletBalance -= totalPurchaseAmount;
                            booking.BookingStatus = BookingStatus.Booked;
                            booking.TotalPrice = totalPurchaseAmount;
                            
                            ordersList.AddRange(tempOrderList);
                            Console.WriteLine($"Booking successful and ID is {booking.BookingID}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Insufficient wallet balance and recharge with atleast {totalPurchaseAmount - currentLoggedInUser.WalletBalance}");
                            Console.Write($"Enter amount to recharge : ");
                            bool isValid = double.TryParse(Console.ReadLine(), out double amount);
                            while (!isValid)
                            {
                                Console.Write($"Enter valid amount to recharge : ");
                                isValid = double.TryParse(Console.ReadLine(), out amount);

                            }
                            currentLoggedInUser.WalletRecharge(amount);
                        }
                    } while (!booking.BookingStatus.Equals(BookingStatus.Booked));

                }
                else
                {
                    //reverting order
                    foreach (OrderDetails order in tempOrderList)
                    {
                        foreach (ProductDetails product in productsList)
                        {
                            if (order.ProductID.Equals(product.ProductID))
                            {
                                product.AvailableQuantity += order.PurchaseCount;
                                break;
                            }
                        }
                    }
                    Console.WriteLine($"Cart removed successfully");
                }
                bookingsList.Add(booking);
            }
            else
            {
                Console.WriteLine($"Since purchase is cancelled exiting");
            }

        } // Take Order ends
        public static void ModifyOrderQuantity()
        {
            bool temp = false;
            foreach (BookingDetails booking in bookingsList)
            {
                if (booking.CustomerID.Equals(currentLoggedInUser.CustomerID) && booking.BookingStatus.Equals(BookingStatus.Booked))
                {
                    temp = true;
                    break;
                }
            }
            if (temp)
            {
                temp = false;
                Console.WriteLine($"|{"Booking ID",-10}|{"Customer ID",-11}|{"Total Price",-11}|{"Date of booking",-15}|{"Booking status",-15}|");

                foreach (BookingDetails booking in bookingsList)
                {
                    if (booking.CustomerID.Equals(currentLoggedInUser.CustomerID) && booking.BookingStatus.Equals(BookingStatus.Booked))
                    {
                        Console.WriteLine($"|{booking.BookingID,-10}|{booking.CustomerID,-11}|{booking.TotalPrice,-11}|{booking.DateOfBooking.ToString("dd/MM/yyyy"),-15}|{booking.BookingStatus,-15}|");
                    }
                }
                Console.WriteLine($"Enter booking ID : ");
                string bookingID = Console.ReadLine().ToUpper();
                //checking if booking id is present
                foreach (BookingDetails booking in bookingsList)
                {
                    if (booking.CustomerID.Equals(currentLoggedInUser.CustomerID) && booking.BookingStatus.Equals(BookingStatus.Booked) && booking.BookingID.Equals(bookingID))
                    {
                        temp = true;
                        bool isPresent = false;
                        Console.WriteLine($"|{"Order ID",-10}|{"Booking ID",-10}|{"Product ID",-10}|{"Purchase count",-14}|{"Price of order",-14}|");

                        foreach (OrderDetails order in ordersList)
                        {
                            if (order.BookingID.Equals(bookingID))
                            {
                                Console.WriteLine($"|{order.OrderID,-10}|{order.BookingID,-10}|{order.ProductID,-10}|{order.PurchaseCount,-14}|{order.PriceOrder,-14}|");

                            }
                        }
                        Console.WriteLine($"Enter order ID : ");
                        string orderID = Console.ReadLine().ToUpper();
                        foreach (OrderDetails order in ordersList)
                        {
                            if (order.BookingID.Equals(booking.BookingID) && order.OrderID.Equals(orderID))
                            {
                                isPresent = true;
                                Console.WriteLine($"Enter quantity : ");
                                bool isValid = int.TryParse(Console.ReadLine(), out int newQuantity);
                                while (!isValid || newQuantity < 1)
                                {
                                    Console.WriteLine($"Enter valid quantity : ");
                                    isValid = int.TryParse(Console.ReadLine(), out newQuantity);

                                }
                                isValid = false;
                                int diff = newQuantity - order.PurchaseCount;
                                foreach (ProductDetails product in productsList)
                                {
                                    if (product.ProductID.Equals(product.ProductID) && Math.Abs(diff) <= product.AvailableQuantity)
                                    {
                                        isValid = true;
                                        if (diff * (order.PriceOrder / order.PurchaseCount) <= currentLoggedInUser.WalletBalance)
                                        {
                                            //updating item details
                                            booking.TotalPrice -= order.PriceOrder;
                                            order.PriceOrder = order.PriceOrder / order.PurchaseCount;
                                            currentLoggedInUser.WalletRecharge(order.PriceOrder * order.PurchaseCount);
                                            order.PurchaseCount = newQuantity;
                                            order.PriceOrder *= order.PurchaseCount;
                                            booking.TotalPrice += order.PriceOrder;
                                            currentLoggedInUser.WalletBalance -= order.PriceOrder;
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
                                break;
                            }
                        }
                        if (!isPresent)
                        {
                            Console.WriteLine($"Order id is not present");

                        }

                        break;
                    }
                }
                if (!temp)
                {
                    Console.WriteLine($"Booking id is not present");

                }

            }
            else
            {
                Console.WriteLine($"There is no order booked for this customer");

            }

        } //  modify order quantity ends
        public static void CancelOrder()
        {
            bool temp = false;
            foreach (BookingDetails booking in bookingsList)
            {
                if (booking.CustomerID.Equals(currentLoggedInUser.CustomerID) && booking.BookingStatus.Equals(BookingStatus.Booked))
                {
                    temp = true;
                    break;
                }
            }
            if (temp)
            {
                temp = false;
                Console.WriteLine($"|{"Booking ID",-10}|{"Customer ID",-11}|{"Total Price",-11}|{"Date of booking",-15}|{"Booking status",-15}|");

                foreach (BookingDetails booking in bookingsList)
                {
                    if (booking.CustomerID.Equals(currentLoggedInUser.CustomerID) && booking.BookingStatus.Equals(BookingStatus.Booked))
                    {
                        Console.WriteLine($"|{booking.BookingID,-10}|{booking.CustomerID,-11}|{booking.TotalPrice,-11}|{booking.DateOfBooking.ToString("dd/MM/yyyy"),-15}|{booking.BookingStatus,-15}|");
                    }
                }
                Console.WriteLine($"Enter booking ID : ");
                string bookingID = Console.ReadLine().ToUpper();
                
                //checking if booking id is present
                foreach (BookingDetails booking in bookingsList)
                {
                    if (booking.CustomerID.Equals(currentLoggedInUser.CustomerID) && booking.BookingStatus.Equals(BookingStatus.Booked) && booking.BookingID.Equals(bookingID))
                    { 
                        temp = true;
                        booking.BookingStatus = BookingStatus.Cancelled;
                        currentLoggedInUser.WalletRecharge(booking.TotalPrice);
                        foreach(OrderDetails order in ordersList){
                            if (order.BookingID.Equals(booking.BookingID) )
                            {
                                foreach(ProductDetails product in productsList){
                                    if(order.ProductID.Equals(product.ProductID)){
                                        product.AvailableQuantity+=order.PurchaseCount;
                                        break;
                                    }
                                }
                            }
                        }
                        Console.WriteLine($"Booking cancelled successfully");
                        
                        break;
                    }
                }
                if(!temp){
                    Console.WriteLine($"Enter valid booking ID");
                    
                }
            }
            else
            {
                Console.WriteLine($"There is nor booking by the customer to cancel");

            }
        } // cancel order ends
    }
}