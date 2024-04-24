using System;
namespace OnlineLibrary;
class Program
{
    public static void Main(string[] args)
    {
        DepartmentDetails department1 = new DepartmentDetails("IT", "B.Tech");
        RackInfo rackInfo1 = new RackInfo(department1.DepartmentName, department1.Degree, 17, 19);
        BookInfo bookInfo1 = new BookInfo(rackInfo1.DepartmentName, rackInfo1.Degree, rackInfo1.RackNumber, rackInfo1.ColumnNumber, "C#", "Author1", 213.70);
        bookInfo1.DisplayInfo();
        Console.WriteLine();

        DepartmentDetails department2 = new DepartmentDetails("EEE", "B.E");
        RackInfo rackInfo2 = new RackInfo(department2.DepartmentName, department2.Degree, 21, 34);
        BookInfo bookInfo2 = new BookInfo(rackInfo2.DepartmentName, rackInfo2.Degree, rackInfo2.RackNumber, rackInfo2.ColumnNumber, "Electical Engineering", "Author2", 1213.70);
        bookInfo2.DisplayInfo();
        Console.WriteLine();

        DepartmentDetails department3 = new DepartmentDetails("MECH", "B.E");
        RackInfo rackInfo3 = new RackInfo(department3.DepartmentName, department3.Degree, 01, 04);
        BookInfo bookInfo3 = new BookInfo(rackInfo3.DepartmentName, rackInfo3.Degree, rackInfo3.RackNumber, rackInfo3.ColumnNumber, "Engine & Motors", "Author3", 413.70);
        bookInf3.DisplayInfo();
        Console.WriteLine();


    }
}