using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ques8
{
    public class Calculator
    {
         double _mark1{get;set;}
         double _mark2{get;set;}
         double _mark3{get;set;}
         double _mark4{get;set;}
         double _mark5{get;set;}
         double _mark6{get;set;}
        public Calculator(double mark1, double mark2, double mark3, double mark4, double mark5, double mark6){
            _mark1 = mark1;
            _mark2 = mark2;
            _mark3 = mark3;
            _mark4 = mark4;
            _mark5 = mark5;
            _mark6 = mark6;
        }
        public static Calculator operator+ (Calculator sem1, Calculator sem2)
        {
            Calculator sem = new Calculator(0,0,0,0,0,0);
            sem._mark1 = sem1._mark1 + sem2._mark1;
            sem._mark2 = sem1._mark2 + sem2._mark2;
            sem._mark3 = sem1._mark3 + sem2._mark3;
            sem._mark4 = sem1._mark4 + sem2._mark4;
            sem._mark5 = sem1._mark5 + sem2._mark5;
            sem._mark6 = sem1._mark6 + sem2._mark6;
            return sem;
        }
        public double Total(){
            return _mark1+_mark2+_mark3+_mark4+_mark5+_mark6;
        }
        public double Percentage(){
            return Total()/24;
        }
    }
}