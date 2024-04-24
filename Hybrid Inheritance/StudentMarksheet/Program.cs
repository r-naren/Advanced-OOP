using System;
namespace StudentMarksheet;
class Program{
    public static void Main(string[] args)
    {
        PersonalInfo person1 = new PersonalInfo("Eren","Jaegar","9876543","eren@gmail.com",new DateTime(1999,12,12),Gender.Male);
        TheoryExamMarks theoryExamMarks1 = new TheoryExamMarks(person1.RegistrationNumber, person1.Name,person1.FatherName,person1.Phone, person1.Mail, person1.DOB, person1.Gender, new double[]{77,78,79,80,21,23},new double[]{77,78,79,82,21,23},new double[]{77,78,79,80,81,23},new double[]{77,78,79,80,91,23} );
        Marksheet marksheet1 = new Marksheet(theoryExamMarks1.RegistrationNumber, theoryExamMarks1.Name,theoryExamMarks1.FatherName,theoryExamMarks1.Phone, theoryExamMarks1.Mail, theoryExamMarks1.DOB, theoryExamMarks1.Gender, theoryExamMarks1.Sem1, theoryExamMarks1.Sem2, theoryExamMarks1.Sem3, theoryExamMarks1.Sem4, DateTime.Now, 75 );
        marksheet1.CalculateUG();
        marksheet1.ShowUGMarksheet();
        Console.WriteLine($"");
        PersonalInfo person2 = new PersonalInfo("Luffy","Dragon","132435","luffy@gmail.com",new DateTime(2001,03,12),Gender.Male);
        TheoryExamMarks theoryExamMarks2 = new TheoryExamMarks(person2.RegistrationNumber, person2.Name,person1.FatherName,person2.Phone, person2.Mail, person2.DOB, person2.Gender, new double[]{7,78,79,80,21,23},new double[]{77,78,79,2,21,23},new double[]{77,78,79,80,81,2},new double[]{77,78,0,80,91,23} );
        Marksheet marksheet2 = new Marksheet(theoryExamMarks2.RegistrationNumber, theoryExamMarks2.Name,theoryExamMarks2.FatherName,theoryExamMarks2.Phone, theoryExamMarks2.Mail, theoryExamMarks2.DOB, theoryExamMarks2.Gender, theoryExamMarks2.Sem1, theoryExamMarks2.Sem2, theoryExamMarks2.Sem3, theoryExamMarks2.Sem4, DateTime.Now, 80 );
        marksheet2.CalculateUG();
        marksheet2.ShowUGMarksheet();
        Console.WriteLine($"");
        
    }
}