using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace QwickFoodzStack
{
    // class
    /// <summary>
    /// This class is used for creating and holding data of Item Details of instance of <see cref="ItemDetails"/>
    /// </summary>
    public class ItemDetails
    {
        //fields
        /// <summary>
        /// this private filed is used for auto incrmentation of Item id
        /// </summary>
        private static int s_itemID = 4000;
        //properties
        /// <summary>
        /// ItemID property is instance of <see cref="ItemDetails"/>
        /// </summary>
        /// <value></value>
        public string ItemID { get; }
        /// <summary>
        /// OrderID peroperty is instance of <see cref="ItemDetails"/>
        /// </summary>
        /// <value></value>
        public string OrderID {get;set;}
        /// <summary>
        /// FoodID property is instance of <see cref="ItemDetails"/>
        /// </summary>
        /// <value></value>
        public string FoodID {get;set;}
        /// <summary>
        /// PurchaseCount peroperty is instance of <see cref="ItemDetails"/>
        /// </summary>
        /// <value>Quantity of item Range (0-200000000)</value>
        public int PurchaseCount {get;set;}
        /// <summary>
        /// PriceOfOrder is instance of <see cref="ItemDetails"/>
        /// </summary>
        /// <value>Order price Range (0-200000000)</value>
        public int PriceOfOrder {get;set;}
        // parameterzied constructor
        /// <summary>
        /// ItemDetails property is used to create and assign values to its instance of <see cref="ItemDetails"/>
        /// </summary>
        /// <param name="orderID">contains Order ID</param>
        /// <param name="foodID">Contains Food ID</param>
        /// <param name="purchaseCount">Contains purchase count</param>
        /// <param name="priceOfOrder">contains order price</param>
        public ItemDetails(string orderID, string foodID, int purchaseCount, int priceOfOrder){
            ItemID = "ITID"+ ++s_itemID;
            OrderID = orderID;
            FoodID = foodID;
            PurchaseCount = purchaseCount;
            PriceOfOrder = priceOfOrder;
        }
        /// <summary>
        /// ItemDetails property is used to create and assign values from Reading csv to its instance of <see cref="ItemDetails"/>
        /// </summary>
        /// <param name="content">Contains all the details of the Items</param>
        public ItemDetails(string content){
            string[] values = content.Split(",");
            ItemID = values[0];
            s_itemID = int.Parse(values[0].Remove(0,4));
            OrderID = values[1];
            FoodID = values[2];
            PurchaseCount = int.Parse(values[3]);
            PriceOfOrder = int.Parse(values[4]);
        }
    }
}