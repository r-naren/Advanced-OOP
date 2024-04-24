using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeRegistration
{
    public class Hack //: EmployeeInfo - cannot derive from sealed type 'EmployeeInfo' 
    {
        public string StoreUserID{get;set;}
        public string StorePassword {get;set;}
        public Hack(string storeUserID, string storePassword){
            StoreUserID = storeUserID;
            StorePassword = storePassword;
        }
        public void ShowKeyInfo(){
            // Console.WriteLine($"Store User ID :{KeyInfo}");  - name 'KeyInfo' does not exist in the current context
        }
        public void GetUserInfo(string userID){
           // UserID = userID;  - name 'UserID' does not exist in the current context
        }
        public void ShowUserInfo(){
           // Console.WriteLine($"User ID : {UserID}"); - name 'UserID' does not exist in the current context
        }
    }
}