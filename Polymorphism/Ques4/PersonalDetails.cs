using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ques4
{
    public enum Gender {Male, Female, Transgender}
    public class PersonalDetails
    {
        public string Name {get;set;}
        public string FatherName {get;set;}
        public Gender Gender {get;set;}
        public string Qualification {get;set;}
        public PersonalDetails(string name, string fatherName, Gender gender, string qualification){
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            Qualification = qualification;
        }

        public PersonalDetails()
        {
        }
    }
}