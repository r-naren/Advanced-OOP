using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApplication
{
    public interface IBankInfo
    {
        string BankName {get;set;}
        string IFSC {get;set;}
        string Branch {get;set;}
        
    }
}