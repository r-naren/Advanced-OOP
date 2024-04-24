using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student
{
    public partial class StudentInfo
    {
        public StudentInfo(string name, Gender gender, DateTime dob, string mobile, double physicsMark, double chemistryMark, double mathsMark){
            StudentID = "SID"+ ++s_studentID;
            Name = name;
            Gender = gender;
            DOB = dob;
            Mobile = mobile;
            PhysicsMark = physicsMark;
            ChemistryMark = chemistryMark;
            MathsMark= mathsMark;
        }
        
    }
}