using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryShop
{
    /// <summary>
    /// CustomerRegistration class used to create and hold details of customer and inherited from Personaldetails and Ibalance
    /// </summary>
    public class CustomerRegistration : PersonalDetails, IBalance
    {
        /// <summary>
        /// Autoincrementation of customer id
        /// </summary>
        private static int s_customerID = 1000;
        //Property
        /// <summary>
        /// THis property used to store customer id of instance of <see cref="CustomerRegistration"/> 
        /// </summary>
        /// <value></value>
        public string CustomerID { get; }
        /// <summary>
        /// This property used to store the wallet balance of instance of <see cref="CustomerRegistration"/> 
        /// </summary>
        /// <value>Range (0-16 digits)</value>
        public double WalletBalance { get;set; }
        /// <summary>
        /// CustomerRegistration constructor used to create and assign values to its instance of <see cref="CustomerRegistration"/> 
        /// </summary>
        /// <param name="name">holds name</param>
        /// <param name="fatherName">holds fathername</param>
        /// <param name="gender">holds gender</param>
        /// <param name="mobileNumber">holds mobilenumber</param>
        /// <param name="mailID">holds mailid</param>
        /// <param name="dob">holds dob</param>
        /// <param name="balance">holds balance</param>
        /// <returns></returns>
        public CustomerRegistration(string name, string fatherName, Gender gender, string mobileNumber, string mailID, DateTime dob, double balance) : base(name, fatherName, gender, mobileNumber, mailID, dob)
        {
            CustomerID = "CID" + ++s_customerID;
            WalletBalance = balance;
        }
        /// <summary>
        /// CustomerRegistration used to cretae and store the details from csv to its instance of <see cref="CustomerRegistration"/> 
        /// </summary>
        /// <param name="content">Holds all the data of the customer</param>
        public CustomerRegistration(string content) : base(content)
        {
            string[] values = content.Split(",");
            CustomerID = values[0];
            s_customerID  = int.Parse(values[0].Remove(0,3));
            WalletBalance = double.Parse(values[7]);
        }
        /// <summary>
        /// this method is used to recharge the wallet
        /// </summary>
        /// <param name="amount"></param>
        public void WalletRecharge(double amount)
        {
            WalletBalance += amount;
        }
        /// <summary>
        /// Bineary seeach method is used to search the customer id using binary search algorithm
        /// </summary>
        /// <param name="customerID">customer id which is to be searched</param>
        /// <param name="customers">the list in which needs to be searched</param>
        /// <returns></returns>
        public static CustomerRegistration BinarySearch(string customerID, CustomList<CustomerRegistration> customers)
        {
            int left = 0, right = customers.Count - 1;
            while (left <= right)
            {

                int mid = (left + right) / 2;
                if (customers[mid].CustomerID == customerID)
                {
                    return customers[mid];
                }
                if (customers[mid].CustomerID.CompareTo(customerID) < 0)
                {
                    left = mid + 1;
                }

                else
                {
                    right = mid - 1;
                }
            }
            return null;
        }
        /// <summary>
        /// this method shows the customer details
        /// </summary>
        public void ShowCustomerDetails(){
            Console.WriteLine($"Customer ID : {CustomerID}\nName: {Name}\nFather Name: {FatherName}\nGender: {Gender}\nMobile : {MobileNumber}\nMail ID : {MailID}\nDOB: {DOB.ToString("dd/MM/yyyy")}");
            
        }
        /// <summary>
        /// this method shows the balance of the user
        /// </summary>
        public void ShowBalance(){
            Console.WriteLine($"Wallet balance : {WalletBalance}");
            
        }
    }
}