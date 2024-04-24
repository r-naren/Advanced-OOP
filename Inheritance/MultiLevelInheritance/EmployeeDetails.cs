using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public class EmployeeDetails : StudentDetails
    {
        private static int s_employeeID= 3000;
        public string EmployeeID{get;}
        public string Designation{get;set;}
        public EmployeeDetails(string studentID, string userID, string name, string fatherName, Gender gender, int age, string mobileNumber, int standard, string yearOfJoining,string designation):base( studentID,  userID,  name,  fatherName,  gender,  age,  mobileNumber,  standard,  yearOfJoining)
        {
            EmployeeID = "EID"+ ++s_employeeID;
            Designation = designation;
        }
    }
}