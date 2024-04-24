using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserDetail
{
    public enum Gender{Male, Female, Transgender}
    public class PersonalInfo
    {
        public string Name {get;set;}
        public string FatherName {get;set;}
        public string Mobile{get;set;}
        public string Mail{get;set;}
        public Gender Gender{get;set;}
        public virtual void Update( string mobile){
            Mobile = mobile;
            
        }
        public void DisplayInfo(){
            Console.WriteLine($"name : {Name}\nFather Name : {FatherName}\nMobile : {Mobile}\nMail : {Mail}\nGender : {Gender}");
            
        }
    }
}