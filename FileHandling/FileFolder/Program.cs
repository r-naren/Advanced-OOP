using System;
using System.IO;
using System.Runtime.ConstrainedExecution;
namespace FileFolder;
class Program
{
    public static void Main(string[] args)
    {
        string path = @"C:\Users\NarendranathRamasamy\OneDrive - Syncfusion\Desktop\Programs\Assignments\Phase3_ClassWork\FileHandling\Files";
        string folderPath = path + "/DemoFolder";
        if (!Directory.Exists(folderPath))
        {
            Console.WriteLine($"Creating folder ..");
            Directory.CreateDirectory(folderPath);
        }
        else
        {
            Console.WriteLine($"Folder already exists");
        }
        string filePath = path + "\\myFile.csv";
        if (!File.Exists(filePath))
        {
            Console.WriteLine($"Creating file ..");
            File.Create(filePath);
        }
        else
        {
            Console.WriteLine($"file already exists");
        }
        path = path + "\\DemoFolder";
        Console.WriteLine($"1. Create folder\n2. Create file\n3. Delete folder\n4. Delete file");
        int option = int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                {
                    Console.WriteLine($"Enter folder name you want to create");
                    string folder = Console.ReadLine();
                    string newPath = path + "\\" + folder;
                    if (!Directory.Exists(newPath))
                    {
                        Console.WriteLine($"Creating folder ..");
                        Directory.CreateDirectory(newPath);
                    }
                    else
                    {
                        Console.WriteLine($"Folder already exists");
                    }
                    break;

                }
            case 2:
                {
                    Console.WriteLine($"Enter file name you want to create");
                    string fileName = Console.ReadLine();
                    Console.WriteLine($"Enter file extension : ");

                    string extension = Console.ReadLine();

                    string newPath = path + "\\" + fileName + "." + extension;
                    if (!File.Exists(newPath))
                    {
                        Console.WriteLine($"Creating file {fileName}.{extension}");
                        File.Create(newPath);
                    }
                    else
                    {
                        Console.WriteLine($"file already exists");
                    }
                    break;

                }
                case 3:{
                    foreach(string path1 in Directory.GetDirectories(path)){
                        Console.WriteLine($"{path1}");
                        
                    }
                    Console.WriteLine($"Enter folder path you want to delete : ");
                    string deleteDir = Console.ReadLine();
                    foreach(string path1 in Directory.GetDirectories(path)){
                        if(path1.Contains(deleteDir)){
                            Console.WriteLine($"Removing folder "+ deleteDir);
                            Directory.Delete(path1);
                        }    
                    }
                    break;
                }
                case 4:{
                    foreach(string file in Directory.GetFiles(path)){
                        Console.WriteLine($"{file}");
                    }
                    Console.WriteLine($"Enter File name you want to delete : ");
                    string deletefile = Console.ReadLine();
                    foreach(string file in Directory.GetFiles(path)){
                        if(file.Contains(deletefile)){
                            Console.WriteLine($"Removing file "+ deletefile);
                            Directory.Delete(file);
                        }    
                    }
                    break;
                }

        }
    }
}