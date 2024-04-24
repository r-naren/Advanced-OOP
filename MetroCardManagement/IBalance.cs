using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    //Interface
    public interface IBalance
    {
        //properties
        public int Balance { get; set; }
        //methods
        public void WalletRecharge(int balance);
        public void DeductBalance(int balance);
    }
}