using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    // class
    /// <summary>
    /// CustomerDetails class contains the instance of the customer which is inherited from PersonalDetails <see cref="PersonalDetails"/>  and IBalance  of instance of <see cref="CustomerDetails"/> 
    /// </summary>
    public class CustomerDetails : PersonalDetails, IBalance
    {
        // fields
        /// <summary>
        /// _balance is private field 
        /// </summary>
        private int _balance;
        /// <summary>
        /// s_customer id is auto incrementable for assigning to Customer ID property of instance of <see cref="CustomerDetails"/> 
        /// </summary>
        private static int s_customerID = 1000;
        //properties
        /// <summary>
        /// CustomerID property is instance of <see cref="CustomerDetails"/> 
        /// </summary>
        /// <value>Holds Customer ID</value>
        public string CustomerID { get; } // read only
        /// <summary>
        /// Walletbalance property is instance of <see cref="CustomerDetails"/> readonly
        /// </summary> 
        /// <value></value>
        public int WalletBalance { get { return _balance; } }
        //constructor
        /// <summary>
        /// CustomerDetails constructor creates and assigns values to instance of <see cref="CustomerDetails"/> 
        /// </summary>
        /// <param name="name">Name of customer</param>
        /// <param name="fatherName">Father name of customer</param>
        /// <param name="gender">Gender of customer</param>
        /// <param name="mobile">Mobile number of customer</param>
        /// <param name="dob">Date of Birth of customer</param>
        /// <param name="mailID">Mail ID of customer</param>
        /// <param name="location">Location of customer</param>
        /// <param name="balance">Balance of customer</param> 
        public CustomerDetails(string name, string fatherName, Gender gender, string mobile, DateTime dob, string mailID, string location, int balance) : base(name, fatherName, gender, mobile, dob, mailID, location)
        {
            CustomerID = "CID" + ++s_customerID;
            _balance = balance;
        }
        /// <summary>
        /// CustomerDetails constructor used to assign values from csv to its instance of <see cref="CustomerDetails"/> 
        /// </summary>
        /// <param name="content">Contains all the details of a customer</param>
        public CustomerDetails(string content)
        {
            string[] values = content.Split(",");
            CustomerID = values[0];
            s_customerID = int.Parse(values[0].Remove(0, 3));
            Name = values[1];
            FatherName = values[2];
            Gender = Enum.Parse<Gender>(values[3]);
            Mobile = values[4];
            DOB = DateTime.ParseExact(values[5], "dd/MM/yyyy", null);
            MailID = values[6];
            Location = values[7];
            _balance = int.Parse(values[8]);
        }
        //methods
        /// <summary>
        /// WalletRecharge method used to add amount to the wallet
        /// </summary>
        /// <param name="amount">Amount that needs to be recharged</param>
        public void WalletRecharge(int amount)
        {
            _balance += amount;
        }
        /// <summary>
        /// DeductBalance methods used to deduct amount from the customer wallet
        /// </summary>
        /// <param name="amount">Amount that need to be detected from user</param> 
        public void DeductBalance(int amount)
        {
            _balance -= amount;
        }
    }
}