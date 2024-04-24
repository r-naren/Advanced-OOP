using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission
{
    public class Teacher : PersonalInfo
    {
        private static int s_teacherID = 1000;
        public string TeacherID {get;}
        public string Department { get; set; }
        public string SubjectTeaching { get; set; }
        public string Qualification { get; set; }
        public int YearOfExperience { get; set; }
        public DateTime DateOfJoining{get;set;} 
        public Teacher(string name, string fatherName, string phone, string mail, DateTime dob, Gender gender, string department, string subjectTeaching,string qualification, int yearOfExperience, DateTime dateOfJoining) : base( name,  fatherName,  phone,  mail,  dob,  gender)
        {
            TeacherID = "TID" + ++s_teacherID;
            Department = department;
            SubjectTeaching = subjectTeaching;
            Qualification = qualification;
            YearOfExperience = yearOfExperience;
            DateOfJoining = dateOfJoining;
        }
        public void ShowDetails(){
            Console.WriteLine($"Teacher ID : {TeacherID}\nDepartment : {Department}\nSubject teaching : {SubjectTeaching}\nQualification : {Qualification}\nYears of Expereince : {YearOfExperience}\nDate Of Joining : {DateOfJoining.ToShortDateString()}");            
        }
    }
}