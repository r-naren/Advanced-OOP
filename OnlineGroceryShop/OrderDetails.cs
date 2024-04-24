using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace OnlineGroceryShop
{
    /// <summary>
    /// OrderDetails class used to create and store the details of orders of instance of <see cref="OrderDetails"/>
    /// </summary>
    public class OrderDetails
    {
        /// <summary>
        /// Autoincrement order id
        /// </summary>
        private static int s_orderID = 4000;
        //Property
        /// <summary>
        /// Read only property order id
        /// </summary>
        /// <value></value>
        public string OrderID { get; }
        /// <summary>
        /// Booking id used to hold the booking id of instance of <see cref="OrderDetails"/>
        /// </summary>
        /// <value></value>
        public string BookingID {get;set;}
        /// <summary>
        /// product id used to hold product id of instance of <see cref="OrderDetails"/>
        /// </summary>
        /// <value></value>
        public string ProductID {get;set;}
        /// <summary>
        /// This property used to hold the purchase count of instance of <see cref="OrderDetails"/>
        /// </summary>
        /// <value>Range (1-200000000)</value>
        public int PurchaseCount{get;set;}
        /// <summary>
        /// this property used to hold the price of the order of instance of <see cref="OrderDetails"/>
        /// </summary>
        /// <value>Range (0-16 bytes)</value>
        public double PriceOrder {get;set;}
        /// <summary>
        /// orderDetails used to create and hold the data of instance of <see cref="OrderDetails"/>
        /// </summary>
        /// <param name="bookingID">holds booking id</param>
        /// <param name="productID">holds product id</param>
        /// <param name="purchaseCount">holds purchase count</param>
        /// <param name="priceOfOrder">holds price of order</param> 
        public OrderDetails(string bookingID, string productID, int purchaseCount, double priceOfOrder){
            OrderID = "OID"+ ++s_orderID;
            BookingID = bookingID;
            ProductID = productID;
            PurchaseCount = purchaseCount;
            PriceOrder = priceOfOrder;
        }
        /// <summary>
        /// OrderDetails used to create and store the details fro csv of instance of <see cref="OrderDetails"/>
        /// </summary>
        /// <param name="content">Conails all details of Orders</param>
        public OrderDetails(string content){
            string[] values = content.Split(",");
            OrderID = values[0];
            s_orderID = int.Parse(values[0].Remove(0,3));
            BookingID = values[1];
            ProductID = values[2];
            PurchaseCount = int.Parse(values[3]);
            PriceOrder = double.Parse(values[4]);
        }
    }
}