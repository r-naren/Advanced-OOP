using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace CafeteriaCardAssignment
{
    /// <summary>
    /// FoodDetails class is used to create and store the food details of instance of <see cref="FoodDetails"/> 
    /// </summary>
    public class FoodDetails
    {
        // Field
        /// <summary>
        /// this filed is used for auto incrmenetation for foodID
        /// </summary>
        private static int s_foodID = 100;
        // Properties
        /// <summary>
        /// FoodId property is used to stored the FoodID of instance of <see cref="FoodDetails"/> 
        /// </summary>
        /// <value></value>
        public string FoodID { get; }
        /// <summary>
        /// FoodName is used store the details of the food name of instance of <see cref="FoodDetails"/> 
        /// </summary>
        /// <value></value>
        public string FoodName {get;set;}
        /// <summary>
        /// FoodPrice is used to store the details of the food price of instance of <see cref="FoodDetails"/>  
        /// </summary> 
        /// <value>Holds the food price range (0-17 digits)</value>
        public double FoodPrice {get;set;}
        /// <summary>
        /// AvailableQuantity is used to store the food quantity avvailable of instance of <see cref="FoodDetails"/> 
        /// </summary>
        /// <value></value>
        public int AvailableQuantity {get;set;}
        //Parameterzied constructor
        /// <summary>
        /// FoodDetails paramater used to create and store the details of food of instance of <see cref="FoodDetails"/> 
        /// </summary>
        /// <param name="foodName"> Holds food name</param>
        /// <param name="foodPrice">holds food price</param>
        /// <param name="availableQuantity">holds the quantity available</param>
        public FoodDetails (string foodName, double foodPrice, int availableQuantity){
            FoodID = "FID"+ ++s_foodID;
            FoodName = foodName;
            FoodPrice = foodPrice;
            AvailableQuantity =availableQuantity;
        }
    }
}