using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserDetail
{
    public class EmployeeInfo : FamilyInfo
    {
        private static int s_employeeID = 1000;
        public string EmployeeID {get;}
        public string DateOfJoining{get;set;}
        public EmployeeInfo(string dateOfJoining){
            EmployeeID = "EID"+ s_employeeID;
            DateOfJoining =dateOfJoining;
        }
        // public override void Update(string dateOfJoining){ - 'EmployeeInfo.Update(string)': cannot override inherited member 'FamilyInfo.Update(string)' because it is sealed    
        //   DateOfJoining =dateOfJoining;
        // }
        // public override void DisplayInfo(){ - 'EmployeeInfo.DisplayInfo()': cannot override inherited member 'FamilyInfo.DisplayInfo()' because it is sealed    
        //   Console.WriteLine(DateOfJoining);
        // }

    }
}