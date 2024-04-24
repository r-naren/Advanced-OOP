using System;
namespace UserDetail;
class Program{
    public static void Main(string[] args)
    {
        EmployeeInfo employeeInfo = new EmployeeInfo("2002");
        employeeInfo.Update("Harur"); // shows Family details because of override
        employeeInfo.DisplayInfo();
        
    }
}