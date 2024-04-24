using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetails
{
    public class HSCDetails : StudentInfo
    {
        private static int s_hscMarksheetNumber = 3000;
        public string HSCMarksheetNumber { get; }
        public double Physics { get; set; }
        public double Chemistry { get; set; }
        public double Maths { get; set; }
        public double Total { get; set; }
        public double PercentageMarks { get; set; }
        public HSCDetails(string name, string fatherName, string phone, string mail, DateTime dob, Gender gender, string registrationNumber, int standard, string branch, string academicYear) : base(name, fatherName, phone, mail, dob, gender, registrationNumber)
        {
            HSCMarksheetNumber = "HSC" + ++s_hscMarksheetNumber;
            
        }
        public void GetMarks(double physics, double chemistry, double maths)
        {
            Physics = physics;
            Chemistry = chemistry;
            Maths = maths;
        }
        public void Calculate()
        {
            Total = Physics + Chemistry + Maths;
            PercentageMarks = Total / 3;
        }
        public void ShowMarksheet()
        {
            Console.WriteLine($"HSC Marksheet Number : {HSCMarksheetNumber}\nPhysics  mark : {Physics}\nChemistry mark : {Chemistry}\nMaths mark : {Maths}\nTotal : {Total}\nPercentage Marks : {PercentageMarks}");

        }
    }
}