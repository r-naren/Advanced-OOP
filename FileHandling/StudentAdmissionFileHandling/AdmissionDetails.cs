using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdmissionFileHandling
{
    public enum AdmissionStatus { Select, Booked, Cancelled }
    public class AdmissionDetails
    {
        //Static private field
        private static int s_admissionID = 1000;
        //property
        public string AdmissionID { get; } //Read-Only property
        public string StudentID { get; set; }
        public string DepartmentID { get; set; }
        public DateTime AdmissionDate { get; set; }
        public AdmissionStatus AdmissionStatus { get; set; }
        //Constructor
        public AdmissionDetails(string studentID, string departmentID, DateTime admissionDate, AdmissionStatus admissionStatus)
        {
            AdmissionID = "AID" + ++s_admissionID; // Auto increment
            StudentID = studentID;
            DepartmentID = departmentID;
            AdmissionDate = admissionDate;
            AdmissionStatus = admissionStatus;
        }
        public AdmissionDetails(string admission)
        {
            string[]  values = admission.Split(",");
            AdmissionID = values[0]; 
            s_admissionID = int.Parse(values[0].Remove(0,3));
            StudentID = values[1];
            DepartmentID = values[2];
            AdmissionDate = DateTime.ParseExact(values[3],"dd/MM/yyyy",null);
            AdmissionStatus = Enum.Parse<AdmissionStatus>(values[4], true);
        }

    }
}