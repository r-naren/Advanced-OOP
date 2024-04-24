using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission
{
    public class StudentInfo : PersonalInfo
    {
        private static int s_studentID = 1000;
        public string StudentID {get;}
        public string Degree { get; set; }
        public string Department { get; set; }
        public int Semester { get; set; }
        public StudentInfo(string name, string fatherName, string phone, string mail, DateTime dob, Gender gender, string degree, string department, int semester) : base(name,  fatherName,  phone,  mail,  dob,  gender){
            StudentID = "SID"+ ++s_studentID;
            Degree = degree;
            Department = department;
            Semester = semester;
        }
        public void ShowDetails(){
            Console.WriteLine($"Student ID : {StudentID}\nDegree : {Degree}\nDepartment : {Department}\nSemester : {Semester}");            
        }
    }
}