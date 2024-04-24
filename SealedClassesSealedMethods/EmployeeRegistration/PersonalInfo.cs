using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeRegistration
{
    public enum Gender {Male, Female, Other}
    public class PersonalInfo
    {
        public string Name {get;set;}
        public string FatherName {get;set;}
        public string Mobile {get;set;}
        public string Mail {get;set;}
        public Gender Gender{get;set;}
        public void UpdateInfo (string mobile, string mail){
            Mobile = mobile;
            Mail = mail;
        }
    }
}