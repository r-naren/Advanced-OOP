using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public class StudentDetails : PersonalDetails
    {
        private static int s_studentID = 2000;
        public string StudentID { get; }
        public int Standard { get; set; }
        public string YearOfJoining { get; set; }
        public StudentDetails(string userID, string name, string fatherName, Gender gender, int age, string mobileNumber, int standard, string yearOfJoining) : base(userID, name,  fatherName,  gender,  age,  mobileNumber)
        {
            StudentID = "SID" + ++s_studentID;
            Standard = standard;
            YearOfJoining = yearOfJoining;

        }
        public StudentDetails(string studentID, string userID, string name, string fatherName, Gender gender, int age, string mobileNumber, int standard, string yearOfJoining) : base(userID, name,  fatherName,  gender,  age,  mobileNumber)
        {
            StudentID = studentID;
            Standard = standard;
            YearOfJoining = yearOfJoining;

        }
    }
}