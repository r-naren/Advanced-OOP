using System;
namespace HierarchicalInheritance;
class Program
{
    public static void Main(string[] args)
    {
        PersonalDetails person = new PersonalDetails("Ram", "Ramasamy", Gender.Male, 30, "9876543210");
        Console.WriteLine($"| {person.UserID} | {person.Name} | {person.FatherName} | {person.Gender} | {person.Age} | {person.MobileNumber} |");
        StudentDetails student = new StudentDetails(person.UserID, person.Name,person.FatherName, person.Gender, person.Age, person.MobileNumber, 7, "2024");
        Console.WriteLine($"| {student.UserID} | {student.Name} | {student.FatherName} | {student.Gender} | {student.Age} | {student.MobileNumber} | {student.StudentID} | {student.Standard} | {student.YearOfJoining} | ");
        CustomerDetails customer = new CustomerDetails(person.UserID, person.Name,person.FatherName, person.Gender, person.Age, person.MobileNumber, 2000);
        Console.WriteLine($"| {customer.UserID} | {customer.Name} | {customer.FatherName} | {customer.Gender} | {customer.Age} | {customer.MobileNumber} | {customer.CustomerID} | {customer.WalletBalance} |");
        
    }
}