using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace QwickFoodzStack
{
    /// <summary>
    ///  FoodDetails class is used to create and hold the food detials of instance of <see cref="FoodDetails"/>
    /// </summary>
    public class FoodDetails
    {
        // fields
        /// <summary>
        /// this filed is used for autoincrement and assigning value to the FoodID property
        /// </summary>
        private static int s_foodID = 2000;
        //properties
        /// <summary>
        /// FoodId property is instance of <see cref="FoodDetails"/>
        /// </summary>
        /// <value>Food ID </value>
        public string FoodID { get; }
        /// <summary>
        /// FoodName property is instance of <see cref="FoodDetails"/>
        /// </summary>
        /// <value>Food Name, Ex : Dosa</value>
        public string FoodName { get; set; }
        /// <summary>
        /// PericePerQuantity property is instance of <see cref="FoodDetails"/>
        /// </summary>
        /// <value>Price of Range (0-200000000)</value>
        public int PricePerQuantity { get; set; }
        /// <summary>
        /// QuantityAvailable property is instance of <see cref="FoodDetails"/>
        /// </summary>
        /// <value>Quantity available Range (0-200000000)</value>
        public int QuantityAvailable { get; set; }
        // parameterized constructor
        /// <summary>
        /// FoodDetials contructor is used for creating and assigning values from paramaters of  instance of <see cref="FoodDetails"/>
        /// </summary>
        /// <param name="foodName">food name</param>
        /// <param name="pricePerQuantity">pricce of the product</param>
        /// <param name="quantityAvailable">Available quantity</param>
        public FoodDetails(string foodName, int pricePerQuantity, int quantityAvailable)
        {
            FoodID = "FID" + ++s_foodID;
            FoodName = foodName;
            PricePerQuantity = pricePerQuantity;
            QuantityAvailable = quantityAvailable;
        }
        /// <summary>
        /// FoodDetails constructor is used for creating and assigning values from reading csv to its instance of <see cref="FoodDetails"/> 
        /// </summary>
        /// <param name="content">Contains all the details off the food</param>
        public FoodDetails(string content)
        {
            string[] values = content.Split(",");
            FoodID = values[0];
            s_foodID = int.Parse(values[0].Remove(0, 3));
            FoodName = values[1];
            PricePerQuantity = int.Parse(values[2]);
            QuantityAvailable = int.Parse(values[3]);
        }
    }
}