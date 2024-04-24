using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApplication
{
    public enum Gender { Select, Male, Female }
    public class PersonalInfo
    {
        private static int s_registrationNumber = 1000;
        public string RegistrationNumber;
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime DOB{get;set;}
        public Gender Gender { get; set; }

        public PersonalInfo(string name,  string phone,  DateTime dob, Gender gender)
        {
            RegistrationNumber = "RID"+ ++s_registrationNumber;
            Name = name;
            
            Phone = phone;
           
            DOB = dob;
            Gender = gender;
        }
         public PersonalInfo(string registrationNumber, string name,  string phone,  DateTime dob, Gender gender)
        {
            RegistrationNumber = registrationNumber;
            Name = name;
            
            Phone = phone;
   
            DOB = dob;
            Gender = gender;
        }
    }
}