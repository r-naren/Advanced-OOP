using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    public class CustomerDetails : PersonalDetails
    {
        private static int s_customerID= 3000;
        public string CustomerID{get;}
        public int  WalletBalance{get;set;}
        public CustomerDetails(string userID, string name, string fatherName, Gender gender, int age, string mobileNumber,int walletBalance ):base(  userID,  name,  fatherName,  gender,  age,  mobileNumber)
        {
            CustomerID = "CID"+ ++s_customerID;
            WalletBalance = walletBalance;
        }
    }
}