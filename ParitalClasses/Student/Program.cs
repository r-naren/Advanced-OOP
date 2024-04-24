using System;
namespace Student;
class Program{
    public static void Main(string[] args)
    {
        StudentInfo studentInfo = new StudentInfo("Naren", Gender.Male, new DateTime(2002,01,01), "987654310", 89.5, 74, 97);

        studentInfo.Calculate();
         Console.WriteLine(studentInfo.Display());
    }
}