using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClassesAndMethods
{
    public partial class PersonalDetails
    {
        //methods declaration list class
        public partial int CalculateAge()
        {
            TimeSpan span = DateTime.Now - DOB;
            Age = (int)span.TotalDays / 365;
            return Age;
        }
    }
}