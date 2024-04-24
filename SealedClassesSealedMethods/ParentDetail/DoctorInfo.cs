using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParentDetail
{
    public class DoctorInfo //:  PatientInfo - Can't inherit sealed class
    {
        private static int s_DoctorID = 2000;
        public string DoctorID {get;set;}
        public string Name {get;set;}
        public string FatherName {get;set;}
        
        public DoctorInfo(string name, string fatherName){
            DoctorID = "DID"+ ++s_DoctorID;
            Name = name;
            FatherName =fatherName;
        }
        public void DisplayInfo(){
            Console.WriteLine($"Doctor ID : {DoctorID}\nName : {Name}\nFather Name : {FatherName}");
        }
    }
}