using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetails
{
    public class StudentInfo : PersonalInfo
    {
        private static int s_registrationNumber = 2000;
        public string RegistrationNumber { get; }
        public int Standard { get; set; }
        public string Branch { get; set; }
        public string AcademicYear { get; set; }
        public StudentInfo(string name, string fatherName, string phone, string mail, DateTime dob, Gender gender) : base( name,  fatherName,  phone,  mail,  dob,  gender)
        {
            RegistrationNumber = "RID" + ++s_registrationNumber;
            Branch = "";
            AcademicYear = "";
            
        }
        public StudentInfo(string name, string fatherName, string phone, string mail, DateTime dob, Gender gender,string registrationNumber) : base( name,  fatherName,  phone,  mail,  dob,  gender)
        {
            RegistrationNumber = registrationNumber;
            Branch = "";
            AcademicYear = "";
            
        }
        public void GetStudentInfo(int standard,string branch, string academicYear){
            Standard = standard;
            Branch = branch;
            AcademicYear = academicYear;
        }
        public void ShowStudentInfo(){
            Console.WriteLine($"Reg. No : {RegistrationNumber}\nName : {Name}\nFather Name : {FatherName}\nPhone: {Phone}\nMail : {Mail}\nDOB : {DOB.ToString("dd/MM/yyyy")}\nGender : {Gender}\nStandard : {Standard}\nBranch: {Branch}\nYear of joining : {AcademicYear}");
        }
    }
}