using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Microsoft.Win32.SafeHandles;
namespace ReadWrite;
class Program
{
    public static void Main(string[] args)
    {
        if (!Directory.Exists("TestFolder"))
        {
            Console.WriteLine($"Creating folder");
            Directory.CreateDirectory("TestFolder");

        }
        else
        {
            Console.WriteLine($"Folder Already exists");
        }
        if (!File.Exists("TestFolder\\test.csv"))
        {
            Console.WriteLine($"Creating file");
            File.Create("TestFolder\\test.csv").Close();

        }
        else
        {
            Console.WriteLine($"csv File Already exists");
        }
        if (!File.Exists("TestFolder\\data.json"))
        {
            Console.WriteLine($"Creating file");
            File.Create("TestFolder\\data.json").Close();

        }
        else
        {
            Console.WriteLine($"json File Already exists");
        }
        if (!File.Exists("TestFolder\\data.txt"))
        {
            Console.WriteLine($"Creating txt file");
            File.Create("TestFolder\\data.txt").Close();

        }
        else
        {
            Console.WriteLine($"txt File Already exists");
        }
        List<Student> students = new List<Student>();
        students.Add(new Student() { Name = "Ravi", FatherName = "Bala", Gender = Gender.Male, DOB = new DateTime(1999, 01, 01), TotalMark = 455 });
        students.Add(new Student() { Name = "Luffy", FatherName = "Dragon", Gender = Gender.Male, DOB = new DateTime(1969, 01, 01), TotalMark = 475 });
        students.Add(new Student() { Name = "Nico", FatherName = "Robin", Gender = Gender.Female, DOB = new DateTime(1999, 05, 01), TotalMark = 459 });
        WriteToCSV(students);
        ReadFromCSV();
        WriteToJson(students);
        ReadFromJson();
        WriteToTXT();
        ReadFromTXT();
    }
    static void WriteToCSV(List<Student> students)
    {
        StreamWriter sw = new StreamWriter("TestFolder\\test.csv");
        foreach (Student student in students)
        {
            sw.WriteLine(student.Name + "," + student.FatherName + "," + student.DOB.ToString("dd/MM/yyyy") + "," + student.Gender + "," + student.TotalMark);
        }
        sw.Close();
        // or
        // string data = "dddddddd,dfgdsfghjk,kjhgk,01/05/1999,Male,464\n";
        // File.AppendAllText("TestFolder\\test.csv",data);
    }
    static void ReadFromCSV()
    {
        List<Student> newList = new List<Student>();
        StreamReader sr = new StreamReader("TestFolder\\test.csv");
        string line = sr.ReadLine();
        while (line != null)
        { // checking if there is empty space
            string[] values = line.Split(",");
            if (values[0] != "")
            { // to check if there is empty line in between
                newList.Add(new Student() { Name = values[0], FatherName = values[1], DOB = DateTime.ParseExact(values[2], "dd/MM/yyyy", null), Gender = Enum.Parse<Gender>(values[3]), TotalMark = double.Parse(values[4]) });

            }
            line = sr.ReadLine();

        }

        sr.Close();

        foreach (Student student in newList)
        {
            Console.WriteLine($"|{student.Name}|{student.FatherName}|{student.DOB.ToString("dd/MM/yyyy")}|{student.Gender}|{student.TotalMark}|");

        }

    }
    static void WriteToJson(List<Student> students)
    {
        StreamWriter sw = new StreamWriter("TestFolder\\data.json");
        var option = new JsonSerializerOptions
        {
            WriteIndented = true // placing neatly in Json
        };
        string jsonData = JsonSerializer.Serialize(students, option);
        sw.WriteLine(jsonData);
        sw.Close();
    }
    static void ReadFromJson()
    {

        List<Student> newList = JsonSerializer.Deserialize<List<Student>>(File.ReadAllText("TestFolder\\data.json"));
        foreach(Student student in newList){
            Console.WriteLine($"|{student.Name}|{student.FatherName}|{student.DOB.ToString("dd/MM/yyyy")}|{student.Gender}|{student.TotalMark}|");
        }
    }
    static void WriteToTXT(){
        string[] contents = File.ReadAllLines("TestFolder\\data.txt");
        StreamWriter sw = new StreamWriter("TestFolder\\data.txt");
        Console.WriteLine($"Enter what do you want to place in file ");
        string data = Console.ReadLine();
        string old = "";
        foreach(string line in contents){
            old = old+line+"\n";
        }
        old +=data;
        sw.WriteLine(old);        
        sw.Close();
    }
    static void ReadFromTXT(){
        StreamReader sr = new StreamReader("TestFolder\\data.txt");
        string line = sr.ReadLine();
        while(line!=null){
            Console.WriteLine(line);
            line = sr.ReadLine();            
        }
        sr.Close();
    }

    
}