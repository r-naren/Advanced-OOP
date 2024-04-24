using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdmissionFileHandling
{
    public class DepartmentDetails
    {
        //Static private field
        private static int s_departmentID = 100;
        //Property
        public string DepartmentID { get; } //Read-Only property
        public string DepartmentName { get; set; }
        public int NumberOfSeats { get; set; }
        //Constructor
        public DepartmentDetails(string departmentName, int numberOfSeats)
        {
            DepartmentID = "DID" + ++s_departmentID; //Auto increment
            DepartmentName = departmentName;
            NumberOfSeats = numberOfSeats;
        }
        public DepartmentDetails(string department)
        {
            string[] values = department.Split(",");
            DepartmentID =  values[0];
            s_departmentID = int.Parse(values[0].Remove(0,3));
            DepartmentName = values[1];
            NumberOfSeats = int.Parse(values[2]);
        }
    }
}