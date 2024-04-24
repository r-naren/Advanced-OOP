using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    // class
    /// <summary>
    /// This class is used to create the object for the UserDetails class <cref="UserDetails"/>.
    /// This class inherites the PersonalDetails class <cref=""/> and also IBalance interface.
    /// </summary>
    public class UserDetails : PersonalDetails, IBalance
    {
        //private static field
        /// <summary>
        /// This static field is used to autoincrement and assign the value to the CardNumber porperty <see cref="UserDetails"/>
        /// </summary>
        private static int s_cardNumber = 1000;
        //properties
        /// <summary>
        /// CardNumber Property is used to create instance of CardNumber for UserDetails <see cref="UserDetails"/>
        /// </summary>
        /// <value>It will be assigned from s_cardNumber field</value>
        public string CardNumber { get; }
        /// <summary>
        /// Balance property is used to create instance of Balance for UserDetails <see cref="UserDetails"/>
        /// </summary> 
        /// <value>Range : 0 - 200000000</value>
        public int Balance { get; set; }
        // parameterized constructor
        /// <summary>
        /// UserDetails paramterized constructor used to create and assign values of instance for <see cref="UserDetails"/>
        /// </summary>
        /// <param name="userName">Conatains userName of the user</param>
        /// <param name="phoneNumber">Contains phoneNumber of the user</param>
        /// <param name="balance">Containes balance of the user</param> <summary>
        /// <returns>Since it is inherited from  <see cref="PersonalDetails"/> it passes parameters to its base class  <see cref="PersonalDetails"/></returns>
        public UserDetails(string userName, string phoneNumber, int balance) : base(userName, phoneNumber)
        {
            CardNumber = "CMRL" + ++s_cardNumber;//  auto increment
            Balance = balance;
        }
        /// <summary>
        /// This paramterized constructor is used to assign values to CardNumber, Username, PhoneNumber, Balance of instance of <see cref="UserDetails"/> 
        /// </summary>
        /// <param name="content">Contains the details of CardNumber, Username, PhoneNumber, Balance</param>
        /// <returns>Since it is inherited from  <see cref="PersonalDetails"/> it passes empty parameters to its base class  <see cref="PersonalDetails"/></returns>
        public UserDetails(string content)
        {
            string[] values = content.Split(",");
            CardNumber = values[0];
            s_cardNumber = int.Parse(values[0].Remove(0,4));
            UserName = values[1];
            PhoneNumber = values[2];
            Balance = int.Parse(values[3]);
        }
        //methods
        /// <summary>
        /// WalletRecharge method is used to add amount to the balance of instance of <see cref="UserDetails"/>
        /// </summary>
        /// <param name="amount">Contains the amount which is used to add in Balance</param>
        public void WalletRecharge(int amount)
        {
            Balance += amount;
        }
        /// <summary>
        /// DeductBalance method is used to deduct amount from the balance of instance of <see cref="UserDetails"/>
        /// </summary>
        /// <param name="amount">Containes amount which is useed to dedect from the Balance</param>
        public void DeductBalance(int amount)
        {
            Balance -= amount;
        }
        /// <summary>
        /// Return Balance method is used to return the Balance of the instance of <see cref="UserDetails"/>
        /// </summary>
        /// <returns>Returns the balance of the current instance of <see cref="UserDetails"/></returns> 
        public int ReturnBalance(){
            return Balance;
        }

    }
}