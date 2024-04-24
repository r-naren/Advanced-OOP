using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student
{
    public partial class StudentInfo
    {
         public void Calculate(){
            Total = PhysicsMark + MathsMark + ChemistryMark;
            Percentage = Total/3;
        }
        public string Display(){
            return "Name :"+Name+"\nGender :"+Gender+"\nDOB :"+DOB.ToString("dd/MM/yyyy")+"\nMobile :"+Mobile+"\nPhysics mark :"+PhysicsMark+"\nChemistry mark :"+ChemistryMark+"\nMaths mark :"+MathsMark+"\nTotal :"+Total+"\nPercentage :"+Percentage;
        }
        
    }
}