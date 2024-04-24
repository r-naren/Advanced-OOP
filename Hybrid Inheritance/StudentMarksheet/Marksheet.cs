using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace StudentMarksheet
{
    public class Marksheet : TheoryExamMarks, ICalculate
    {
        private static int s_markSheetNumber = 3000;
        public string MarkSheetNumber { get; set; }
        public DateTime DateOfIssue { get; set; }
        public double[] Total { get; set; }
        public double[] Percentage { get; set; }
        public double ProjectMark { get; set; }
        public Marksheet(string registrationNumber, string name, string fatherName, string phone, string mail, DateTime dob, Gender gender, double[] sem1, double[] sem2, double[] sem3, double[] sem4, DateTime dateOfIssue, double projectMark) : base(registrationNumber,name, fatherName, phone, mail, dob, gender, sem1, sem2, sem3, sem4)
        {
            MarkSheetNumber = "MSN"+ ++s_markSheetNumber;
            DateOfIssue = dateOfIssue;
            ProjectMark = projectMark;
            Total = new double[]{0,0,0,0};
            Percentage = new double[]{0,0,0,0};

        }
        public void CalculateUG()
        {
            foreach(double mark in Sem1){
                Total[0]+=mark;
            }
            foreach(double mark in Sem2){
                Total[1]+=mark;
            }
            foreach(double mark in Sem3){
                Total[2]+=mark;
            }
            foreach(double mark in Sem4){
                Total[3]+=mark;
            }
            Percentage[0] = Total[0]/6;
            Percentage[1] = Total[1]/6;
            Percentage[2] = Total[2]/6;
            Percentage[3] = Total[3]/6;

        }
        public void ShowUGMarksheet(){
            Console.WriteLine($"Mark Sheet Number : {MarkSheetNumber}\nDate of issue : {DateOfIssue.ToShortDateString()}\nProject mark : {ProjectMark}\nTotal Sem1 : {Total[0]}\nPercentage Sem1 : {Percentage[0]}%\nTotal Sem2 : {Total[1]}\nPercentage Sem2 : {Percentage[1]}%\nTotal Sem3 : {Total[2]}\nPercentage Sem3 : {Percentage[2]}%\nTotal Sem4 : {Total[3]}\nPercentage Sem4 : {Percentage[3]}%");
            
        }
    }
}