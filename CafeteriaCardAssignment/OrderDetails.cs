using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardAssignment
{
    /// <summary>
    /// Orderstatus enum is used to save the status of the order (Default-0, Initiated-1, Ordered-2, Cancelled-3)
    /// </summary>
    public enum OrderStatus {Default, Initiated, Ordered, Cancelled}
    /// <summary>
    /// OrderDetails class is used to create and store the values of orders of instance of <see cref="OrderDetails"/> 
    /// </summary>
    public class OrderDetails
    {
        //Field
        /// <summary>
        /// orderID is used for auto incrementation
        /// </summary>
        private static int s_orderID = 1000;
        //Property
        /// <summary>
        /// OrderID used to store the OrderID of instance of <see cref="OrderDetails"/>  
        /// </summary>
        /// <value></value>
        public string OrderID { get; }
        /// <summary>
        /// UserID used to store the UserID of instance of <see cref="OrderDetails"/>   
        /// </summary>
        /// <value></value>
        public string UserID {get;set;}
        /// <summary>
        /// OrderDate used to store Date of instance of <see cref="OrderDetails"/> 
        /// </summary>
        /// <value></value>
        public DateTime OrderDate{get;set;}
        /// <summary>
        /// TotalPride used to store price of the order of instance of <see cref="OrderDetails"/> 
        /// </summary>
        /// <value>Total price Range (0-16 digits)</value>
        public double TotalPrice {get;set;}
        /// <summary>
        /// OrderStatus used to store the status of the order of instance of <see cref="OrderDetails"/> 
        /// </summary>
        /// <value>Enum values of OrderStatus</value>
        public OrderStatus OrderStatus {get;set;}
        //Paramterized constructor
        /// <summary>
        /// OrderDetails constructor used to create and assign the values to the properties of instance of <see cref="OrderDetails"/> 
        /// </summary>
        /// <param name="userID">holds userID</param>
        /// <param name="orderDate">holds orderDate</param>
        /// <param name="totalPrice">holds order price</param>
        /// <param name="orderStatus">holds order status</param> 
        public OrderDetails (string userID, DateTime orderDate,double totalPrice, OrderStatus orderStatus){
            OrderID = "OID"+ ++s_orderID;
            UserID = userID;
            OrderDate = orderDate;
            TotalPrice =totalPrice;
            OrderStatus = orderStatus;
        }
    }
}