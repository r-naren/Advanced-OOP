using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace onlineMedicalStore
{
    /// <summary>
    /// Orderstatus enum store the status of the order (Purchased-0, Cancelled-1)
    /// </summary>
    public enum OrderStatus {Purchased, Cancelled}
    /// <summary>
    /// OrderDetails class used to create and sttore the values of the orders instance of <see cref="OrderDetails"/> 
    /// </summary>
    public class OrderDetails
    {
        /// <summary>
        /// this field is used for userid autoincrementation
        /// </summary>
        private static int s_orderID = 2000;
        /// <summary>
        /// this proeprtty read only reads the order id of instance of <see cref="OrderDetails"/> 
        /// </summary>
        /// <value></value>
        public string OrderID {get;}
        /// <summary>
        /// this property used to store User id of instance of <see cref="OrderDetails"/> 
        /// </summary>
        /// <value></value>
        public string UserID {get;set;}
        /// <summary>
        /// this property used to store the medicine id of instance of <see cref="OrderDetails"/> 
        /// </summary>
        /// <value></value>
        public string MedicineID{get;set;}
        /// <summary>
        /// this property used to store the medicine count of instance of <see cref="OrderDetails"/> 
        /// </summary>
        /// <value>Range(0-200000000)</value>
        public int MedicineCount {get;set;}
        /// <summary>
        /// this property used to store the total price of instance of <see cref="OrderDetails"/> 
        /// </summary>
        /// <value></value>
        public int TotalPrice {get;set;}
        /// <summary>
        /// this property used to store the order date of instance of <see cref="OrderDetails"/> 
        /// </summary>
        /// <value></value>
        public DateTime OrderDate {get;set;}
        /// <summary>
        /// this property used to store the order status of instance of <see cref="OrderDetails"/> 
        /// </summary>
        /// <value></value>
        public OrderStatus OrderStatus {get;set;}
        /// <summary>
        /// OrderDetails consructor used to create and assign values to its instance of <see cref="OrderDetails"/> 
        /// </summary>
        /// <param name="userID">holds user id</param>
        /// <param name="medicineID">holds medicine id</param>
        /// <param name="medicineCount">holds medicine count</param>
        /// <param name="totalPrice">holds total price</param>
        /// <param name="orderDate">holds order date</param>
        /// <param name="orderStatus">holds orders tatus</param>
        public OrderDetails(string userID, string medicineID,int medicineCount, int totalPrice, DateTime orderDate, OrderStatus orderStatus){
            OrderID = "OID" + ++s_orderID;
            UserID = userID;
            MedicineID = medicineID;
            MedicineCount = medicineCount;
            TotalPrice = totalPrice;
            OrderDate = orderDate;
            OrderStatus = orderStatus;
        }
        /// <summary>
        /// OrderDetails consructors used to create and assign values from csv to its instance of <see cref="OrderDetails"/> 
        /// </summary>
        /// <param name="content">Contains all details of order</param>
        public OrderDetails(string content){
            string[] values = content.Split(",");
            OrderID = values[0];
            s_orderID = int.Parse(values[0].Remove(0,3));
            UserID = values[1];
            MedicineID = values[2];
            MedicineCount = int.Parse(values[3]);
            TotalPrice = int.Parse(values[4]);
            OrderDate = DateTime.ParseExact(values[5],"dd/MM/yyyy",null);
            OrderStatus = Enum.Parse<OrderStatus>(values[6]);
        }

    }
}