using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ques6
{
    public class SBI : Bank
    {
        public override double GetInterestInfo()
        {
            return 7.5;
        }
    }
}