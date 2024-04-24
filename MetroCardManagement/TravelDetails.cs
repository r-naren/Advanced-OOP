using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    //class
    /// <summary>
    /// This class is used to create the object of instance of <see cref="TravelDetails"/>
    /// </summary>
    public class TravelDetails
    {
        //private static field
        /// <summary>
        /// This static field is used to autoincrement and used to assignit to the TravelID property <see cref="TravelDetails"/>
        /// </summary>
        private static int s_travelID = 2000;
        //properties
        /// <summary>
        /// TravelID property is used to create instance of TravelID for Travel Details <see cref="TravelDetails"/>
        /// <value>It will be assigned from s_travelID</value>
        public string TravelID { get; }
        /// <summary>
        /// CardNumber property is used to create instance of CardNumber for Travel Details <see cref="TravelDetails"/>
        /// </summary>
        /// <value>Card Number - Ex : CMRL1001</value>
        public string CardNumber { get; set; }
        /// <summary>
        /// FromLocation property is used to create instance of FromLocation for Travel Details <see cref="TravelDetails"/>
        /// </summary>
        /// <value>From Location - Ex : Chennai</value>
        public string FromLocation { get; set; }
        /// <summary>
        /// ToLocation property is used to create instance of ToLocation for Travel Details <see cref="TravelDetails"/>
        /// </summary>
        /// <value>To Location - Ex : Coimbatore</value>
        public string ToLocation { get; set; }
        /// <summary>
        /// Date property is used to create instance of Date for Travel Details <see cref="TravelDetails"/>
        /// </summary>
        /// <value>Should be in format (dd/MM/yyyy) - Ex : 01/01/2002 </value>
        public DateTime Date { get; set; }
        /// <summary>
        /// TravelCost property is used to create instance of TravelCost for Travel Details <see cref="TravelDetails"/>
        /// </summary>
        /// <value>Range : 0 - 200000000</value>
        public int TravelCost { get; set; }
        // parameterized constructor

        /// <summary>
        /// This parameterized constructor is used to assign the values of the CardNumber, FromLocation, ToLocation, Date, TravelCost to instance of <see cref="TravelDetails"/>
        /// </summary>
        /// <param name="cardNumber">Contains the Card Number of the user</param>
        /// <param name="fromLocation">Containes the location of the user from which he is travelling</param>
        /// <param name="toLocation">Contains the location where the user wants to go</param>
        /// <param name="date">Contains the journey date</param>
        /// <param name="travelCost">Contains the cost of the travel</param> 
        public TravelDetails(string cardNumber, string fromLocation, string toLocation, DateTime date, int travelCost)
        {
            TravelID = "TID" + ++s_travelID; //auto increment
            CardNumber = cardNumber;
            FromLocation = fromLocation;
            ToLocation = toLocation;
            Date = date;
            TravelCost = travelCost;
        }
        /// <summary>
        /// This parameterzied constructor is used to assign values to TravelID, CardNumber, FromLocation, ToLocation, Date and TravelCost of instance of <see cref="TravelDetails"/>
        /// </summary>
        /// <param name="content">Contains the values of TravelID, CardNumber, FromLocation, ToLocation, Date, TravelCost</param>
        public TravelDetails(string content)
        {
            string[] values = content.Split(",");
            TravelID = values[0];
            s_travelID = int.Parse(values[0].Remove(0,3));
            CardNumber = values[1];
            FromLocation = values[2];
            ToLocation = values[3];
            Date = DateTime.ParseExact(values[4],"dd/MM/yyyy", null);
            TravelCost = int.Parse(values[5]);
        }
    }
}