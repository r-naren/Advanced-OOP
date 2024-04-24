using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterPerson
{
    public enum Gender { Select, Male, Female }
    public enum MaritalStatus { Single, Married }
    public class PersonalInfo : IShowData
    {
        public string Name { get; set; }

        public string Phone { get; set; }
        public string Mail { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }
        public MaritalStatus MaritalStatus{get;set;}


        public PersonalInfo(string name, string phone, string mail, DateTime dob, Gender gender, MaritalStatus maritalStatus)
        {
            Name = name;
            MaritalStatus = maritalStatus;
            Phone = phone;
            Mail = mail;
            DOB = dob;
            Gender = gender;
        }
        public void ShowInfo(){
            Console.WriteLine($"{Name} | {Phone} | {Mail} | {DOB} | {Gender} | {MaritalStatus}");
        } 
    }
}