using System;
using System.Security.Cryptography.X509Certificates;
namespace Ques4;
class Program
{
    public static void Main(string[] args)
    {   
        PersonalDetails personalDetails = new PersonalDetails("Luffy", "Dragon", Gender.Male, "B.Tech");
        FreeLancer freeLancer = new FreeLancer("Luffy", "Dragon", Gender.Male, "B.Tech", "Developer",23 );
        freeLancer.CalculateSalary();
        freeLancer.Display();
        Syncfusion syncfusion = new Syncfusion("Luffy", "Dragon", Gender.Male, "B.Tech", "Developer",23, "Chennai");
        syncfusion.CalculateSalary();
        syncfusion.Display();
    }
}