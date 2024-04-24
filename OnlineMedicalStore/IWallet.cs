using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace onlineMedicalStore
{
    public interface IWallet
    {
    
        public int WalletBalance {get;}
        public void WalletRecharge(int amount);
        public void DeductBalance(int amount);
    }
}