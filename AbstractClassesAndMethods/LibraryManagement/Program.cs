using System;
namespace LibraryManagement;
class Program{
    public static void Main(string[] args)
    {
        CSEDepartment cseDepartment = new CSEDepartment();
        cseDepartment.SetBookInfo("Author1", "Book1", "Publisher1", "2005");
        cseDepartment.DisplayInfo();
        Console.WriteLine();
        
        EEEDepartment eeeDepartment = new EEEDepartment();
        eeeDepartment.SetBookInfo("Author2", "Book2", "Publisher2", "2009");
        eeeDepartment.DisplayInfo();
    }
}