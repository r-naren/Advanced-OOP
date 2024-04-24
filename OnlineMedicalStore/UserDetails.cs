using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace onlineMedicalStore
{
    /// <summary>
    /// UserDetails class used to create and store the details of Users <see cref="UserDetails"/> 
    /// </summary>
    public class UserDetails : PersonalDetails, IWallet
    {
        /// <summary>
        /// autoincrementation of userid
        /// </summary>
        private static int s_userID = 1000;
        /// <summary>
        /// this property used to return the user id of instance of <see cref="UserDetails"/>
        /// </summary>
        /// <value></value>
        public string UserID { get; }
        /// <summary>
        /// this field is used to store the balance of the user
        /// </summary>
        private int _balance;
        /// <summary>
        /// this property used to get the balance of user of instance of <see cref="UserDetails"/>
        /// </summary>
        /// <value></value>
        public int WalletBalance { get { return _balance; } }
        /// <summary>
        /// UserDetails Constructor used to create and assign the values to its instance of <see cref="UserDetails"/>
        /// </summary>
        /// <param name="name">holds name</param>
        /// <param name="age">holds age</param>
        /// <param name="city">holds city</param>
        /// <param name="phoneNumber">holds phone number</param>
        /// <param name="balance">holds balance</param>
        /// <returns>Since inhertied return base class variable values</returns>
        public UserDetails(string name, int age, string city, string phoneNumber, int balance) : base(name, age, city, phoneNumber)
        {
            UserID = "UID" + ++s_userID;
            _balance = balance;
        }
        /// <summary>
        /// UserDetails constructor used to create and assign values from csv to its instance of <see cref="UserDetails"/>
        /// </summary>
        /// <param name="content">Contains all details of user</param>
        public UserDetails(string content)
        {
            string[] values = content.Split(",");
            UserID = values[0];
            s_userID = int.Parse(values[0].Remove(0, 3));
            Name = values[1];
            Age = int.Parse(values[2]);
            City = values[3];
            PhoneNumber = values[4];
            _balance = int.Parse(values[5]);

        }
        /// <summary>
        /// this method used to  recharge amount to user
        /// </summary>
        /// <param name="amount">amount to be recharged from balance</param>
        public void WalletRecharge(int amount)
        {
            _balance += amount;
        }
        /// <summary>
        /// this method used to deduct amount from user
        /// </summary>
        /// <param name="amount">amount to be deducted from balance</param>
        public void DeductBalance(int amount)
        {
            _balance -= amount;
        }


    }
}