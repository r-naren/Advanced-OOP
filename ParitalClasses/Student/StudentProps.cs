using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student
{
    public enum Gender {Male, Female, Trangender}
    public partial class StudentInfo
    {
        private static int s_studentID = 1000;
        public string StudentID {get;set;}
        public string Name {get;set;}
        public Gender Gender {get;set;}
        public DateTime DOB {get;set;}
        public string Mobile{get;set;}
        public double PhysicsMark{get;set;}
        public double ChemistryMark{get;set;}
        public double MathsMark{get;set;}
        public double Total {get;set;}
        public double Percentage {get;set;}
    }
}