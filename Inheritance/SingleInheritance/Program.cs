using System;
namespace SingleInheritance;
class Program
{
    public static void Main(string[] args)
    {
        PersonalDetails person = new PersonalDetails("Ram", "Ramasamy", Gender.Male, 30, "9876543210");
        Console.WriteLine($"| {person.UserID} | {person.Name} | {person.FatherName} | {person.Gender} | {person.Age} | {person.MobileNumber} |");
        StudentDetails student = new StudentDetails(person.UserID, person.Name,person.FatherName, person.Gender, person.Age, person.MobileNumber, 7, "2024");
        Console.WriteLine($"| {student.UserID} | {student.Name} | {student.FatherName} | {student.Gender} | {student.Age} | {student.MobileNumber} | {student.StudentID} | {student.Standard} | {student.YearOfJoining} | ");
    }
}