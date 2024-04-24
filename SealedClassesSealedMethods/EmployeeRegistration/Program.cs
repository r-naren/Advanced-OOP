using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
namespace EmployeeRegistration;
class Program{
    
    public static void Main(string[] args)
    {
       EmployeeInfo employeeInfo = new EmployeeInfo("naren","password");
       employeeInfo.UpdateInfo("Narendranath","Pass123");
       employeeInfo.DisplayInfo();
       Hack hack = new Hack("Store1", "Password1");
       hack.ShowKeyInfo(); //  commented because key info is not present
    }
}