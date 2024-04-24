using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryShop
{
    /// <summary>
    /// ProductDetails class used to create and store the details of the product  <see cref="ProductDetails"/>
    /// </summary>
    public class ProductDetails
    {
        /// <summary>
        /// autoincrement product id
        /// </summary>
        private static int s_productID = 2000;
        // Properties
        /// <summary>
        /// This property used to store the product id - read only
        /// </summary>
        /// <value></value>
        public string ProductID { get; }
        /// <summary>
        /// this property holds the product name of instance of <see cref="ProductDetails"/>
        /// </summary>
        /// <value></value>
        public string ProductName {get;set;}
        /// <summary>
        /// this property holds he available quantity of instance of <see cref="ProductDetails"/>
        /// </summary>
        /// <value></value>
        public int AvailableQuantity {get;set;}
        /// <summary>
        /// this property holds the price per quantity of instance of <see cref="ProductDetails"/>
        /// </summary>
        /// <value></value>
        public double PricePerQuantity {get;set;}
        
        //Parameterzied constructor
        /// <summary>
        /// ProductDetails constructor used to create and store the details of products to its instance of <see cref="ProductDetails"/>
        /// </summary>
        /// <param name="productName">holds product name</param>
        /// <param name="availableQuantity">holds available quantity</param>
        /// <param name="pricePerQuantity">holds price per quantity</param>
        public ProductDetails (string productName, int availableQuantity, double pricePerQuantity){
            ProductID = "PID"+ ++s_productID;
            ProductName = productName;
            AvailableQuantity = availableQuantity;
            PricePerQuantity =pricePerQuantity;
        }
        /// <summary>
        /// PProductDetails constructor used to create and store the details from csv of products to its instance of <see cref="ProductDetails"/
        /// </summary>
        /// <param name="content">holds all details of the product</param>
        public ProductDetails (string content){
            string[] values = content.Split(",");

            ProductID = values[0];
            s_productID = int.Parse(values[0].Remove(0,3));
            ProductName = values[1];
            AvailableQuantity = int.Parse(values[2]);
            PricePerQuantity = double.Parse(values[3]);
        }
        
    }
}