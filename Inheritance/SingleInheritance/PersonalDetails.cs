using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance
{
    public enum Gender { Select, Male, Female }
    public class PersonalDetails
    {
        private static int s_userID = 1000;
        public string UserID { get; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public string MobileNumber { get; set; }
        public PersonalDetails(string name, string fatherName, Gender gender, int age, string mobileNumber)
        {
            UserID = "UID" + ++s_userID;
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            Age = age;
            MobileNumber = mobileNumber;
        }
        public PersonalDetails(string userID, string name, string fatherName, Gender gender, int age, string mobileNumber)
        {
            UserID = userID;
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            Age = age;
            MobileNumber = mobileNumber;
        }

    }
}