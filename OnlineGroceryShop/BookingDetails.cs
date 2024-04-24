using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace OnlineGroceryShop
{
    /// <summary>
    /// Bookingstatus enum is used to store the status of the booking
    /// </summary>
    public enum BookingStatus {Default, Initiated, Booked, Cancelled}
    /// <summary>
    /// Booking details class is used to create and store the booking details of instance of <see cref="BookingDetials"/> 
    /// </summary>
    public class BookingDetails
    {
        /// <summary>
        /// this field is sused for auto incrementation
        /// </summary>
        private static int s_bookingID = 3000;
        //Property
        /// <summary>
        /// this property used to store booking id of instance of <see cref="BookingDetials"/> 
        /// </summary>
        /// <value></value>
        public string BookingID { get; }
        /// <summary>
        /// this property used to store customer id of instance of <see cref="BookingDetials"/> 
        /// </summary>
        /// <value></value>
        public string CustomerID {get;set;}
        /// <summary>
        /// total price used to store total price of order of instance of <see cref="BookingDetials"/> 
        /// </summary>
        /// <value>Range (0-16 digits)</value>
        public double TotalPrice {get;set;}
        /// <summary>
        /// this property used to store booking date of instance of <see cref="BookingDetials"/> 
        /// </summary>
        /// <value>Format : 01/01/2001</value>
        public DateTime DateOfBooking {get;set;}
        /// <summary>
        /// this property used to store booking status of instance of <see cref="BookingDetials"/> 
        /// </summary>
        /// <value></value>
        public BookingStatus BookingStatus {get;set;}
        /// <summary>
        /// BookingDetails used to create and assign values to its instance of <see cref="BookingDetials"/> 
        /// </summary>
        /// <param name="customerID">holds customer id</param>
        /// <param name="totalPrice">holds total price</param>
        /// <param name="dateOfBooking">holds date of booking</param>
        /// <param name="bookingStatus">bolds booking status</param>
        public BookingDetails(string customerID, double totalPrice, DateTime dateOfBooking, BookingStatus bookingStatus){
            BookingID = "BID"+ ++s_bookingID;
            CustomerID = customerID;
            TotalPrice = totalPrice;
            DateOfBooking = dateOfBooking;
            BookingStatus = bookingStatus;
        }
        /// <summary>
        /// BookingDetails used to create and assign values from csv to its instance of <see cref="BookingDetials"/> 
        /// </summary>
        /// <param name="content">Contains all details of the order</param> 
        public BookingDetails(string content){
            string[] values = content.Split(",");
            BookingID = values[0];
            s_bookingID = int.Parse(values[0].Remove(0,3));
            CustomerID = values[1];
            TotalPrice = double.Parse(values[2]);
            DateOfBooking = DateTime.ParseExact(values[3],"dd/MM/yyyy",null);
            BookingStatus = Enum.Parse<BookingStatus>( values[4],true);
        }

    }
}