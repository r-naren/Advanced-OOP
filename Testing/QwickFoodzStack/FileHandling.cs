using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodzStack
{
    public static class FileHandling
    {
        public static void createFileFolder()
        {
            // directory presnet or not
            if (!Directory.Exists("QwickFoodzFiles"))
            {
                Console.WriteLine($"Creating folder");
                Directory.CreateDirectory("QwickFoodzFiles");
            }
            //Food details
            if (!File.Exists("QwickFoodzFiles/FoodDetails.csv"))
            {
                Console.WriteLine($"Creating food details file");
                File.Create("QwickFoodzFiles/FoodDetails.csv").Close();

            }
            //Item details
            if (!File.Exists("QwickFoodzFiles/ItemDetails.csv"))
            {
                Console.WriteLine($"Creating ItemDetails file");
                File.Create("QwickFoodzFiles/ItemDetails.csv").Close();

            }
            //Order details
            if (!File.Exists("QwickFoodzFiles/OrderDetails.csv"))
            {
                Console.WriteLine($"Creating OrderDetails file");
                File.Create("QwickFoodzFiles/OrderDetails.csv").Close();

            }
            //Customer details
            if (!File.Exists("QwickFoodzFiles/CustomerDetails.csv"))
            {
                Console.WriteLine($"Creating CustomerDetails file");
                File.Create("QwickFoodzFiles/CustomerDetails.csv").Close();

            }
        }// create file folder ends
        public static void WriteToCSV()
        {
            //Customer Details
            string[] customers = new string[Operations.customersList.Count];
            for (int i = 0; i < Operations.customersList.Count; i++)
            {
                customers[i] = Operations.customersList[i].CustomerID + "," + Operations.customersList[i].Name + "," + Operations.customersList[i].FatherName + "," + Operations.customersList[i].Gender + "," + Operations.customersList[i].Mobile + "," + Operations.customersList[i].DOB.ToString("dd/MM/yyyy") + "," + Operations.customersList[i].MailID + "," + Operations.customersList[i].Location + "," + Operations.customersList[i].WalletBalance;
            }
            File.WriteAllLines("QwickFoodzFiles/CustomerDetails.csv", customers);
            //Food Details
            string[] foods = new string[Operations.foodsList.Count];
            for (int i = 0; i < Operations.foodsList.Count; i++)
            {
                foods[i] = Operations.foodsList[i].FoodID + ","+Operations.foodsList[i].FoodName+","+Operations.foodsList[i].PricePerQuantity+","+Operations.foodsList[i].QuantityAvailable;
            }
            File.WriteAllLines("QwickFoodzFiles/FoodDetails.csv", foods);
            //Item Details
            string[] items = new string[Operations.itemsList.Count];
            for (int i = 0; i < Operations.itemsList.Count; i++)
            {
                items[i] = Operations.itemsList[i].ItemID+","+Operations.itemsList[i].OrderID+","+Operations.itemsList[i].FoodID+","+Operations.itemsList[i].PurchaseCount+","+Operations.itemsList[i].PriceOfOrder;
            }
            File.WriteAllLines("QwickFoodzFiles/ItemDetails.csv", items);
            //Order Details
            string[] orders = new string[Operations.ordersList.Count];
            for (int i = 0; i < Operations.ordersList.Count; i++)
            {
                orders[i] = Operations.ordersList[i].OrderID+","+Operations.ordersList[i].CustomerID+","+Operations.ordersList[i].TotalPrice+","+Operations.ordersList[i].DateOfOrder.ToString("dd/MM/yyyy")+","+Operations.ordersList[i].OrderStatus;
            }
            File.WriteAllLines("QwickFoodzFiles/OrderDetails.csv", orders);

        }
        public static void ReadFromCSV()
        {
            //Customer details
            string[] customers = File.ReadAllLines("QwickFoodzFiles/CustomerDetails.csv");
            foreach(string customer in customers){
                CustomerDetails customer1 = new CustomerDetails(customer);
                Operations.customersList.Add(customer1);
            }
           //food details
            string[] foods = File.ReadAllLines("QwickFoodzFiles/FoodDetails.csv");
            foreach(string food in foods){
                FoodDetails food1 = new FoodDetails(food);
                Operations.foodsList.Add(food1);
            } 
            //Items details
            string[] items = File.ReadAllLines("QwickFoodzFiles/ItemDetails.csv");
            foreach(string item in items){
                ItemDetails item1 = new ItemDetails(item);
                Operations.itemsList.Add(item1);
            } 
            //order details
            string[] orders = File.ReadAllLines("QwickFoodzFiles/OrderDetails.csv");
            foreach(string order in orders){
                OrderDetails order1 = new OrderDetails(order);
                Operations.ordersList.Add(order1);
            } 
        }
    }
}