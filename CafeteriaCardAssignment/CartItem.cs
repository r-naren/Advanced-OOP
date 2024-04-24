using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardAssignment
{
    /// <summary>
    /// CartItem class is used to create and store the details of cart items of instance of <see cref="CartItem"/> 
    /// </summary> 
    public class CartItem
    {
        //Fields
        /// <summary>
        /// This private field is used to autoincrement the Item ID and assign to ItemID
        /// </summary>
        private static int s_itemID = 100;
        //Property
        /// <summary>
        /// ItemID property is of instance of <see cref="CartItem"/> 
        /// </summary>
        /// <value>Item ID holds value of ItemID</value>
        public string ItemID { get; }
        /// <summary>
        /// OrderID property is of instance of <see cref="CartItem"/> 
        /// </summary>
        /// <value></value>
        public string OrderID {get;set;}
        /// <summary>
        /// FoodID property is of instance of <see cref="CartItem"/> 
        /// </summary> 
        /// <value></value>
        public string FoodID{get;set;}
        /// <summary>
        /// OrderPrice property is of instance of <see cref="CartItem"/> 
        /// </summary>
        /// <value>Order price is Range (0-200000000)</value>
        public double OrderPrice {get;set;}
        /// <summary>
        /// OrderQuantity is of instance of <see cref="CartItem"/> 
        /// </summary>
        /// <value>Order quantity is Range (0-200000000)</value>
        public int OrderQuantity {get;set;}
        // Parameterized constructor
        /// <summary>
        /// CartItem cosntructor used to create and assign the values to its instance of <see cref="CartItem"/> 
        /// </summary>
        /// <param name="orderID">Contains order id</param>
        /// <param name="foodID">contains food id</param>
        /// <param name="orderPrice">contains price of the order</param>
        /// <param name="orderQuantity">contains the order quantity</param>
        public CartItem (string orderID, string foodID,double orderPrice, int orderQuantity){
            ItemID = "ITID"+ ++s_itemID;
            OrderID = orderID;
            FoodID = foodID;
            OrderPrice =orderPrice;
            OrderQuantity = orderQuantity;
        }
    }
}