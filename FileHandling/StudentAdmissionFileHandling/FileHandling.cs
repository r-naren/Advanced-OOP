using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Data.Common;
namespace StudentAdmissionFileHandling
{
    public static class FileHandling
    {
        public static void Create()
        {
            if (!Directory.Exists("StudentAdmissionFiles"))
            {
                Console.WriteLine($"Creating directory");
                Directory.CreateDirectory("StudentAdmissionFiles");
            }
            else
            {
                Console.WriteLine($"Folder Already Exists");
            }

            //Student details file
            if (!File.Exists("StudentAdmissionFiles/StudentDetails.csv"))
            {
                Console.WriteLine($"Creating StudentDetails file");
                File.Create("StudentAdmissionFiles/StudentDetails.csv").Close();
            }
            // Department details file
            if (!File.Exists("StudentAdmissionFiles/DepartmentDetails.csv"))
            {
                Console.WriteLine($"Creating DepartmentDetails file");
                File.Create("StudentAdmissionFiles/DepartmentDetails.csv").Close();
            }
            // Admission Details file 
            if (!File.Exists("StudentAdmissionFiles/AdmissionDetails.csv"))
            {
                Console.WriteLine($"Creating AdmissionDetails file");
                File.Create("StudentAdmissionFiles/AdmissionDetails.csv").Close();
            }
        }
        public static void WriteToCSV()
        {
            // student details
            string[] students = new string[Operations.studentList.Count];
            for (int i = 0; i < Operations.studentList.Count; i++)
            {
                students[i] = Operations.studentList[i].StudentID + "," + Operations.studentList[i].StudentName + "," + Operations.studentList[i].FatherName + "," + Operations.studentList[i].DOB.ToString("dd/MM/yyyy") + "," + Operations.studentList[i].Gender + "," + Operations.studentList[i].PhysicsMark + "," + Operations.studentList[i].ChemistryMark + "," + Operations.studentList[i].MathsMark;
            }
            File.WriteAllLines("StudentAdmissionFiles/StudentDetails.csv", students);
            //Department Details
            string[] departments = new string[Operations.departmentList.Count];
            for (int i = 0; i < Operations.departmentList.Count; i++)
            {
                departments[i] = Operations.departmentList[i].DepartmentID + "," + Operations.departmentList[i].DepartmentName + "," + Operations.departmentList[i].NumberOfSeats;
            }
            File.WriteAllLines("StudentAdmissionFiles/DepartmentDetails.csv", departments);
            // Admission Details
            string[] admissions = new string[Operations.admissionList.Count];
            for (int i = 0; i < Operations.admissionList.Count; i++)
            {
                admissions[i] = Operations.admissionList[i].AdmissionID + "," + Operations.admissionList[i].StudentID + "," + Operations.admissionList[i].DepartmentID + "," + Operations.admissionList[i].AdmissionDate.ToString("dd/MM/yyyy") + "," + Operations.admissionList[i].AdmissionStatus;
            }
            File.WriteAllLines("StudentAdmissionFiles/AdmissionDetails.csv", admissions);
        }
        public static void ReadFromCSV()
        {
            // student details
            string[] students = File.ReadAllLines("StudentAdmissionFiles/StudentDetails.csv");
            foreach (string student in students)
            {
                StudentDetails student1 = new StudentDetails(student);
                Operations.studentList.Add(student1);
            }

            //Department Details
            string[] departments = File.ReadAllLines("StudentAdmissionFiles/DepartmentDetails.csv");
            foreach (string department in departments)
            {
                DepartmentDetails department1 = new DepartmentDetails(department);
                Operations.departmentList.Add(department1);
            }

            // Admission Details
            string[] admissions = File.ReadAllLines("StudentAdmissionFiles/AdmissionDetails.csv");
            foreach (string admission in admissions)
            {
                AdmissionDetails admission1 = new AdmissionDetails(admission);
                Operations.admissionList.Add(admission1);
            }

        }
    }
}