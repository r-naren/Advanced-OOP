using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace RegisterPerson
{
    public class RegisterPerson : PersonalInfo, IShowData, IFamilyInfo
    {
        public static int s_registrationNumber = 1000;
        public string RegistrationNumber {get;set;}
        public DateTime DateOfRegistration{get;set;}
        public string FatherName{get;set;}
        public string MotherName{get;set;}
        public string HouseAddress{get;set;}
        public int NoOfSiblings{get;set;}
        public RegisterPerson(string name, string phone, string mail, DateTime dob, Gender gender, MaritalStatus maritalStatus, DateTime dateOfRegistration, string fatherName, string motherName, string houseAddress, int noOfSiblings) : base( name,  phone,  mail,  dob,  gender,  maritalStatus){
            RegistrationNumber = "RID"+ ++s_registrationNumber;
            DateOfRegistration = dateOfRegistration;
            FatherName = fatherName;
            MotherName = motherName;
            HouseAddress = houseAddress;
            NoOfSiblings = noOfSiblings;
        }
        public new void ShowInfo(){
            Console.WriteLine($"{Name} | {Phone} | {Mail} | {DOB} | {Gender} | {MaritalStatus} | {RegistrationNumber} | {DateOfRegistration.ToShortDateString()} | {FatherName} | {MotherName} | {HouseAddress} | {NoOfSiblings}");
        } 
    }
}