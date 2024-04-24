using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetails
{
    public class StudentInfo : IDisplay
    {
        private static int s_studentID = 1000;
        public string  StudentID {get;set;}
        public string Name {get;set;}
        public string FatherName {get;set;}
        public string Mobile {get;set;}
        public StudentInfo(string name, string fatherName, string mobile){
            StudentID = "SID" + ++s_studentID;
            Name = name;
            FatherName = fatherName;
            Mobile = mobile;
        }
        public void Display(){
            Console.WriteLine($"Student ID : {StudentID} | Name : {Name} | Father name : {FatherName} | Mobile : {Mobile}");
            
        }
    }
}