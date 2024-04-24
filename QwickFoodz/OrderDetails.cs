using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    /// <summary>
    /// OrderStatus enum contains the product order status (Default-0, Initiated-1, ordered-2, Cancelled-3)
    /// </summary>
    public enum OrderStatus {Default, Initiated, Ordered, Cancelled}
    public class OrderDetails
    {
        /// <summary>
        /// This private static field is autoincremented for assigning to OrderID
        /// </summary>
        /// // fields
        private static int s_orderID = 3000;
        //properties
        /// <summary>
        /// OrderId property is instance of <see cref="OrderDetails"/>
        /// </summary>
        /// <value></value>
        public string OrderID { get; }
        /// <summary>
        /// CustomerID property is instance of <see cref="OrderDetails"/>
        /// </summary>
        /// <value></value>
        public string CustomerID {get;set;}
        /// <summary>
        /// TotalPrice property is instance of <see cref="OrderDetails"/>
        /// </summary>
        /// <value>Price of the total order Range (0-200000000)</value>
        public int TotalPrice {get;set;}
        /// <summary>
        /// DateOfOrder property is instance of <see cref="OrderDetails"/>
        /// </summary>
        /// <value>In format dd/MM/YYYY : 01/01/2001</value>
        public DateTime DateOfOrder {get;set;}
        /// <summary>
        /// OrderStatus property is instance of <see cref="OrderDetails"/>
        /// </summary>
        /// <value>Contains the enum values of Order status (Default-0, Initiated-1, ordered-2, Cancelled-3)</value>
        public OrderStatus OrderStatus {get;set;}
        //parameterzied cosntructor
        /// <summary>
        /// OrderDetails Constructor is used to create and assign the values to its instance of <see cref="OrderDetails"/>
        /// </summary>
        /// <param name="customerID">contains customer Id</param>
        /// <param name="totalPrice">contains tota price of the order</param>
        /// <param name="dateOfOrder">contains the date of the order</param>
        /// <param name="orderStatus">contains the Order status</param> 
        public OrderDetails(string customerID, int totalPrice, DateTime dateOfOrder, OrderStatus orderStatus){
            OrderID = "OID" + ++s_orderID;
            CustomerID = customerID;
            TotalPrice = totalPrice;
            DateOfOrder = dateOfOrder;
            OrderStatus = orderStatus;
        }
        /// <summary>
        /// OrderDetails contructor is used to create and assign values from reading csv file to its instance of <see cref="OrderDetails"/>
        /// </summary>
        /// <param name="content">Contains all the details of the orders</param>
        public OrderDetails(string content){
            string[] values = content.Split(",");
            OrderID = values[0];
            s_orderID = int.Parse(values[0].Remove(0,3));
            CustomerID = values[1];
            TotalPrice = int.Parse(values[2]);
            DateOfOrder = DateTime.ParseExact(values[3], "dd/MM/yyyy", null);
            OrderStatus = Enum.Parse<OrderStatus>(values[4]);
        }

    }
}