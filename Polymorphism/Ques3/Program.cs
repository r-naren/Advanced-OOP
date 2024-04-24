using System;
namespace Ques3;
class Program
{
    public static void Main(string[] args)
    {
       EEEDepartment eeeDepartment = new EEEDepartment();
       eeeDepartment.SetBookInfo("Author1","Book1", "publisher1", "2004");
       eeeDepartment.DisplayInfo();

       CSEDepartment cseDepartment = new CSEDepartment();
       cseDepartment.SetBookInfo("Author2","Book2", "publisher2", "2007");
       cseDepartment.DisplayInfo();

    }
}