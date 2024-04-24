using System;
namespace StudentDetails;
class Program{
    public static void Main(string[] args)
    {
        PersonalInfo personal1 = new PersonalInfo("Naren", "Ramasamy", "9876543201", "naren@gmail.com", new DateTime(2012,02,02), Gender.Male);
        StudentInfo student1 = new StudentInfo(personal1.Name,personal1.FatherName, personal1.Phone, personal1.Mail, personal1.DOB, personal1.Gender, 7, "CSE", "2022");
        student1.ShowStudentInfo();
        Console.WriteLine();
        
        PersonalInfo personal2 = new PersonalInfo("Luffy", "Dragon", "9800000201", "luffy@gmail.com", new DateTime(2014,02,02), Gender.Male);
        StudentInfo student2 = new StudentInfo(personal2.Name,personal2.FatherName, personal2.Phone, personal2.Mail, personal2.DOB, personal2.Gender, 5, "BioMaths", "2023");
        student2.ShowStudentInfo();
    }
}