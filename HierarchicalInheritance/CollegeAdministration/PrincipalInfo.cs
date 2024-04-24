using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission
{
    public class PrincipalInfo : PersonalInfo
    {
        private static int s_principalID = 2000;
        public string PrincipalID {get;}
        public string Qualification { get; set; }
        public int YearOfExperience { get; set; }
        public DateTime DateOfJoining { get; set; }
        public PrincipalInfo(string name, string fatherName, string phone, string mail, DateTime dob, Gender gender, string qualification, int yearOfExperience, DateTime dateOfJoining) : base(name,  fatherName,  phone,  mail,  dob,  gender){
            PrincipalID = "PID"+ ++s_principalID;
            Qualification = qualification;
            YearOfExperience = yearOfExperience;
            DateOfJoining = dateOfJoining;
        }
        public void ShowDetails(){
            Console.WriteLine($"Principal ID : {PrincipalID}\nQualification : {Qualification}\nYear Of experience : {YearOfExperience}\nDate of joining : {DateOfJoining.ToShortDateString()}");            
        }
    }
}