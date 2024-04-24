using System;
namespace MultiLevelInheritance;
class Program
{
    public static void Main(string[] args)
    {
        PersonalDetails person = new PersonalDetails("Ram", "Ramasamy", Gender.Male, 30, "9876543210");
        Console.WriteLine($"| {person.UserID} | {person.Name} | {person.FatherName} | {person.Gender} | {person.Age} | {person.MobileNumber} |");
        StudentDetails student = new StudentDetails(person.UserID, person.Name,person.FatherName, person.Gender, person.Age, person.MobileNumber, 7, "2024");
        Console.WriteLine($"| {student.UserID} | {student.Name} | {student.FatherName} | {student.Gender} | {student.Age} | {student.MobileNumber} | {student.StudentID} | {student.Standard} | {student.YearOfJoining} | ");
        EmployeeDetails employee = new EmployeeDetails(student.StudentID,student.UserID,student.Name,student.FatherName,student.Gender,student.Age,student.MobileNumber,student.Standard,student.YearOfJoining,"Software Engineer");
        Console.WriteLine($"| {employee.UserID} | {employee.Name} | {employee.FatherName} | {employee.Gender} | {employee.Age} | {employee.MobileNumber} | {employee.StudentID} | {employee.Standard} | {employee.YearOfJoining} | {employee.EmployeeID} | {employee.Designation} |");
        
    }
}