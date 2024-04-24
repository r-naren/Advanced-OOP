using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public class TemporaryEmployee : SalaryInfo
    {
        private static int s_employeeID = 100;
        public string EmployeeID { get; set; }
        public string EmployeeType { get; set; }
        public double DA { get; set; }
        public double HRA { get; set; }
        public double PF { get; set; }
        public double TotalSalary { get; set; }
        public TemporaryEmployee(double basicSalary, int month, string employeeType) : base(basicSalary, month)
        {
            EmployeeID = "PID" + s_employeeID;
            EmployeeType = employeeType;
            DA = 0.15 * basicSalary;
            HRA = 0.13 * basicSalary;
            PF = 0.1 * basicSalary;
            TotalSalary = 0;
        }
        public void CalulateTotalSalary()
        {
            TotalSalary = BasicSalary + DA + HRA - PF;
            TotalSalary *=Month;
        }
        public void ShowSalary()
        {
            Console.WriteLine($"Total salary : {TotalSalary}");

        }
    }
}