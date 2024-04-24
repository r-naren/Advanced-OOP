using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeRegistration
{
    public sealed class EmployeeInfo 
    {
        private int s_keyInfo = 100;
        public string UserID {get;set;}
        public string Password {get;set;}
        public string KeyInfo {get;}
        public EmployeeInfo(string userID, string password)
        {
            KeyInfo = "K"+ ++s_keyInfo;
            UserID = userID;
            Password = password;
        }
        public void UpdateInfo(string userID, string password){
            UserID = userID;
            Password = password;
        }public void DisplayInfo(){
            Console.WriteLine($"User ID : {UserID}\nKey Info : {KeyInfo}\nPassword : {Password}");
            
        }
    }
}