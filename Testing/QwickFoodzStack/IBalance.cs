using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodzStack
{
    public interface IBalance
    {
        //properties
        int WalletBalance { get; }
        //Methods
        void WalletRecharge(int amount);
        void DeductBalance(int amount);
    }
}