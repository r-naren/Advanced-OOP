using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace onlineMedicalStore
{
    public static class FileHandling
    {
        public static void CreateFileFolder(){
            if(!Directory.Exists("OnlineMedicalStore")){
                Console.WriteLine($"Creating directory");
                Directory.CreateDirectory("OnlineMedicalStore");
            }
            if(!File.Exists("OnlineMedicalStore/MedicineDetails.csv"))
            {
                Console.WriteLine($"Creating medical details file");
                File.Create("OnlineMedicalStore/MedicineDetails.csv").Close();
                
            }
            if(!File.Exists("OnlineMedicalStore/OrderDetails.csv"))
            {
                Console.WriteLine($"Creating OrderDetails file");
                File.Create("OnlineMedicalStore/OrderDetails.csv").Close();
                
            }
            if(!File.Exists("OnlineMedicalStore/UserDetails.csv"))
            {
                Console.WriteLine($"Creating UserDetails file");
                File.Create("OnlineMedicalStore/UserDetails.csv").Close();
                
            }
        }
        public static void WriteToCSV(){
            string[] users = new string[Operations.usersList.Count];
            for(int i=0;i<Operations.usersList.Count;i++){
                users[i] = Operations.usersList[i].UserID+","+ Operations.usersList[i].Name+","+Operations.usersList[i].Age+","+Operations.usersList[i].City+","+Operations.usersList[i].PhoneNumber+","+Operations.usersList[i].WalletBalance;
            }
            File.WriteAllLines("OnlineMedicalStore/UserDetails.csv",users);
            string[] orders = new string[Operations.ordersList.Count];
            for(int i=0;i<Operations.ordersList.Count;i++){
                orders[i] = Operations.ordersList[i].OrderID+","+ Operations.ordersList[i].UserID+","+Operations.ordersList[i].MedicineID+","+Operations.ordersList[i].MedicineCount+","+Operations.ordersList[i].TotalPrice+","+Operations.ordersList[i].OrderDate.ToString("dd/MM/yyyy")+","+Operations.ordersList[i].OrderStatus;
            }
            File.WriteAllLines("OnlineMedicalStore/OrderDetails.csv",orders);
            string[] medicines = new string[Operations.medicinesList.Count];
            for(int i=0;i<Operations.medicinesList.Count;i++){
                medicines[i] = Operations.medicinesList[i].MedicineID+","+ Operations.medicinesList[i].MedicineName+","+Operations.medicinesList[i].AvailableCount+","+Operations.medicinesList[i].Price+","+Operations.medicinesList[i].DateOfExpiry.ToString("dd/MM/yyy");
            }
            File.WriteAllLines("OnlineMedicalStore/MedicineDetails.csv",medicines);
        }
        public static void ReadFromCSV(){
            string[] users = File.ReadAllLines("OnlineMedicalStore/UserDetails.csv");
            foreach(string user in users){
                UserDetails user1 = new UserDetails(user);
                Operations.usersList.Add(user1);
            }
            string[] orders = File.ReadAllLines("OnlineMedicalStore/OrderDetails.csv");
            foreach(string order in orders){
                OrderDetails order1 = new OrderDetails(order);
                Operations.ordersList.Add(order1);
            }
            string[] medicines = File.ReadAllLines("OnlineMedicalStore/MedicineDetails.csv");
            foreach(string medicine in medicines){
                MedicineDetails medicine1 = new MedicineDetails(medicine);
                Operations.medicinesList.Add(medicine1);
            }
        }
    }
}