using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    /// <summary>
    /// This class is used to create the object for the class <see cref="TicketFairDetails"/>
    /// </summary> 
    public class TicketFairDetails
    {
        //private static field
        /// <summary>
        /// This static field is used to autoincrement and assign the values to the Property TicketID <see cref="TicketFairDetails"/>
        /// </summary>
        private static int s_ticketID = 3000;
        //properties
        /// <summary>
        /// TicketID property is used to create the instance of TicketID for TicketFairDetails <see cref="TicketFairDetails"/>
        /// </summary>
        /// <value>It will be assigned from s_ticketID</value>
        public string TicketID { get; }
        /// <summary>
        /// FromLocation property is used to create the instance of FromLocation for TicketFairDetails <see cref="TicketFairDetails"/>
        /// </summary>
        /// <value>string value - Ex : Chennai</value>
        public string FromLocation {get;set;}
        /// <summary>
        /// ToLocation property is used to create the instance of ToLocation for TicketFairDetails <see cref="TicketFairDetails"/>
        /// </summary>
        /// <value>String value - Ex : Coimbatore</value>
        public string ToLocation {get;set;}
        /// <summary>
        /// TicketPrice property is used to create the instance of TicektPrice for TicketFairDetails <see cref="TicketFairDetails"/>
        /// </summary>
        /// <value>Range : 0 - 200000000</value>
        public int TicketPrice { get; set; }
        // parameterzied constrcutor
        /// <summary>
        /// This parameterizedd constructor is used to assign values to FromLocation, ToLocation and TicketPrice of instance of <see cref="TicketFairDetails"/>
        /// </summary>
        /// <param name="fromLocation">contains the from Location</param>
        /// <param name="toLocation">containes the to Location</param>
        /// <param name="ticketPrice">contains the ticket price</param>

        public TicketFairDetails(string fromLocation, string toLocation, int ticketPrice){
            TicketID = "MR"+ ++s_ticketID;
            FromLocation = fromLocation;
            ToLocation = toLocation;
            TicketPrice = ticketPrice;
        }
        /// <summary>
        /// This parameterized constructor is used to assign values to TicketID, FromLocation, ToLocation, TicektPrice of instance of <see cref="TicketFairDetails"/>
        /// </summary>
        /// <param name="content">contains the details of TicketID, FromLocation, ToLocation and TicketPrice</param>
        public TicketFairDetails(string content){
            string[] values = content.Split(",");
            TicketID = values[0];
            s_ticketID = int.Parse(values[0].Remove(0,2));
            FromLocation = values[1];
            ToLocation = values[2];
            TicketPrice = int.Parse(values[3]);
        }
    }
}