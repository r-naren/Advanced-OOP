using System;
namespace StudentDetails;
class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo person1 = new PersonalInfo("Ram", "Ramasamy", "9876543201", "Ram@gmail.com", new DateTime(2001,01,01), Gender.Male);
        StudentInfo student1 = new StudentInfo( person1.Name,person1.FatherName,  person1.Phone, person1.Mail,person1.DOB, person1.Gender);
        student1.GetStudentInfo(7,"CSE","2021");
        student1.ShowStudentInfo();
        HSCDetails hsc1 = new HSCDetails(student1.Name, student1.FatherName, student1.Phone, student1.Mail, student1.DOB, student1.Gender, student1.RegistrationNumber, student1.Standard, student1.Branch, student1.AcademicYear);
        hsc1.GetMarks(71.9,80.9,90.8);
        hsc1.Calculate();
        hsc1.ShowMarksheet();
        Console.WriteLine();
        
        PersonalInfo person2 = new PersonalInfo("Luffy", "Dragon", "9834567201", "Luffy@gmail.com", new DateTime(2011,01,31), Gender.Male);
        StudentInfo student2 = new StudentInfo( person2.Name,person2.FatherName,  person2.Phone, person2.Mail,person2.DOB, person2.Gender);
        student2.GetStudentInfo(9,"Maths","2022");
        student2.ShowStudentInfo();
        HSCDetails hsc2 = new HSCDetails(student2.Name, student2.FatherName, student2.Phone, student2.Mail, student2.DOB, student2.Gender, student2.RegistrationNumber, student2.Standard, student2.Branch, student2.AcademicYear);
        hsc2.GetMarks(11.9,70.9,100);
        hsc2.Calculate();
        hsc2.ShowMarksheet();
 
    }
}