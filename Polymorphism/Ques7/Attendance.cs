using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ques7
{
    public class Attendance
    {
        public int TotalNoOfWorkingDaysInMonth{get;set;}
        public int NoOfLeavesTaken{get;set;}
        public int NoOfPermissionsTaken{get;set;}
        public Attendance(int totalNoOfWorkingDaysInMonth, int noOfLeavesTaken, int noOfPermissionsTaken){
            TotalNoOfWorkingDaysInMonth = totalNoOfWorkingDaysInMonth;
            NoOfLeavesTaken = noOfLeavesTaken;
            NoOfPermissionsTaken = noOfPermissionsTaken;
        }
        public double Salary(){
            return (TotalNoOfWorkingDaysInMonth-NoOfLeavesTaken-NoOfPermissionsTaken) *500;
        }


    }
}