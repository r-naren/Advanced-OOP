using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryShop
{
    public static class FileHandling
    {
        public static void Create()
        {
            if (!Directory.Exists("OnlineGroceryShopFiles"))
            {
                Console.WriteLine($"Creating directory");
                Directory.CreateDirectory("OnlineGroceryShopFiles");
            }
            else
            {
                Console.WriteLine($"Folder Already Exists");
            }

            //Booking details file
            if (!File.Exists("OnlineGroceryShopFiles/BookingDetails.csv"))
            {
                Console.WriteLine($"Creating booking details file");
                File.Create("OnlineGroceryShopFiles/BookingDetails.csv").Close();
            }
            // Customer registation details file
            if (!File.Exists("OnlineGroceryShopFiles/CustomerRegistration.csv"))
            {
                Console.WriteLine($"Creating customer registration file");
                File.Create("OnlineGroceryShopFiles/CustomerRegistration.csv").Close();
            }
            // Order  Details file 
            if (!File.Exists("OnlineGroceryShopFiles/OrderDetails.csv"))
            {
                Console.WriteLine($"Creating order details file");
                File.Create("OnlineGroceryShopFiles/OrderDetails.csv").Close();
            }
            //Product details
            if (!File.Exists("OnlineGroceryShopFiles/ProductDetails.csv"))
            {
                Console.WriteLine($"Creating Product Details file");
                File.Create("OnlineGroceryShopFiles/ProductDetails.csv").Close();
            }
        }
        public static void WriteToCSV(){
            // Booking details
            string[] bookings = new string[Operations.bookingsList.Count];
            for (int i = 0; i < Operations.bookingsList.Count; i++)
            {
                bookings[i] = Operations.bookingsList[i].BookingID + "," + Operations.bookingsList[i].CustomerID + "," + Operations.bookingsList[i].TotalPrice + "," + Operations.bookingsList[i].DateOfBooking.ToString("dd/MM/yyyy") + "," + Operations.bookingsList[i].BookingStatus ;
            }
            File.WriteAllLines("OnlineGroceryShopFiles/BookingDetails.csv", bookings);
            //Customer registration
            string[] customers = new string[Operations.customersList.Count];
            for (int i = 0; i < Operations.customersList.Count; i++)
            {
                customers[i] = Operations.customersList[i].CustomerID + "," + Operations.customersList[i].Name + "," + Operations.customersList[i].FatherName + "," + Operations.customersList[i].Gender + "," + Operations.customersList[i].MobileNumber+","+Operations.customersList[i].MailID+","+Operations.customersList[i].DOB.ToString("dd/MM/yyyy")+","+Operations.customersList[i].WalletBalance;
            }
            File.WriteAllLines("OnlineGroceryShopFiles/CustomerRegistration.csv", customers);
             //Order details
            string[] orders = new string[Operations.ordersList.Count];
            for (int i = 0; i < Operations.ordersList.Count; i++)
            {
                orders[i] = Operations.ordersList[i].OrderID + "," + Operations.ordersList[i].BookingID + "," + Operations.ordersList[i].ProductID + "," + Operations.ordersList[i].PurchaseCount + "," + Operations.ordersList[i].PriceOrder;
            }
            File.WriteAllLines("OnlineGroceryShopFiles/OrderDetails.csv", orders);
            //Prodcut details
            string[] products = new string[Operations.productsList.Count];
            for (int i = 0; i < Operations.productsList.Count; i++)
            {
                products[i] = Operations.productsList[i].ProductID + "," + Operations.productsList[i].ProductName + "," + Operations.productsList[i].AvailableQuantity + "," + Operations.productsList[i].PricePerQuantity ;
            }
            File.WriteAllLines("OnlineGroceryShopFiles/ProductDetails.csv", products);
           
        }
        public static void ReadFromCSV(){
            // booking details
            string[] bookings = File.ReadAllLines("OnlineGroceryShopFiles/BookingDetails.csv");
            foreach (string booking in bookings)
            {
                BookingDetails booking1 = new BookingDetails(booking);
                Operations.bookingsList.Add(booking1);
            }
            // Customer registration
            string[] customers = File.ReadAllLines("OnlineGroceryShopFiles/CustomerRegistration.csv");
            foreach (string customer in customers)
            {
                CustomerRegistration customer1 = new CustomerRegistration(customer);
                Operations.customersList.Add(customer1);
            }
            // Orderdetails
            string[] orders = File.ReadAllLines("OnlineGroceryShopFiles/OrderDetails.csv");
            foreach (string order in orders)
            {
                OrderDetails order1 = new OrderDetails(order);
                Operations.ordersList.Add(order1);
            }
            // Product details
            string[] products = File.ReadAllLines("OnlineGroceryShopFiles/ProductDetails.csv");
            foreach (string product in products)
            {
                ProductDetails product1 = new ProductDetails(product);
                Operations.productsList.Add(product1);
            }
        }
    }
}