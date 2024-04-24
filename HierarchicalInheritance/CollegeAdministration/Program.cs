using System;
namespace CollegeAdmission;
class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo person1 = new PersonalInfo("Ram", "Saran", "98765432", "ram@gmail.com", new DateTime(1999, 11, 11), Gender.Male);
        Teacher teacher1 = new Teacher(person1.Name, person1.FatherName, person1.Phone, person1.Mail, person1.DOB, person1.Gender, "EEE", "Electronics", "M.E", 4, new DateTime(2020, 01, 01));
        StudentInfo student1 = new StudentInfo(person1.Name, person1.FatherName, person1.Phone, person1.Mail, person1.DOB, person1.Gender, "B.E", "EEE", 4);
        PrincipalInfo principal1 = new PrincipalInfo(person1.Name, person1.FatherName, person1.Phone, person1.Mail, person1.DOB, person1.Gender, "P.Hd", 5, new DateTime(2022, 03, 03));
        teacher1.ShowDetails();
        Console.WriteLine();
        student1.ShowDetails();
        Console.WriteLine();
        principal1.ShowDetails();
        Console.WriteLine();
        Console.WriteLine();
        PersonalInfo person2 = new PersonalInfo("Gold", "Rogger", "9823456", "Gold@gmail.com", new DateTime(2001, 12, 11), Gender.Male);
        Teacher teacher2 = new Teacher(person2.Name, person2.FatherName, person2.Phone, person2.Mail, person2.DOB, person2.Gender, "IT", "Data Structures", "M.Tech", 1, new DateTime(2022, 01, 01));
        StudentInfo student2 = new StudentInfo(person2.Name, person2.FatherName, person2.Phone, person2.Mail, person2.DOB, person2.Gender, "B.Tech", "IT", 1);
        PrincipalInfo principal2 = new PrincipalInfo(person2.Name, person2.FatherName, person2.Phone, person2.Mail, person2.DOB, person2.Gender, "P.Hd", 2, new DateTime(2024, 03, 03));
        Console.WriteLine();
        teacher2.ShowDetails();
        Console.WriteLine();
        student2.ShowDetails();
        Console.WriteLine();
        principal2.ShowDetails();
    }
}