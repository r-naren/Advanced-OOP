using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMarksheet
{
    public interface ICalculate
    {
        double ProjectMark{get;set;}
        public void CalculateUG();
    }
}