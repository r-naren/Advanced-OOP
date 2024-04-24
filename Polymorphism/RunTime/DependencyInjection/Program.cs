using System;
using System.Collections.Generic;
namespace DependencyInjection;
class Program
{
    public static void Main(string[] args)
    {
        CCAccount ccAccount = new CCAccount()
        {
            AccountNumber = 65432,
            Name = "dsfd",
            Balance = 243567,
            extra = 243

        };
        SBAccount sbAccount = new SBAccount()
        {
            AccountNumber = 1234,
            Name = "olkjhgf",
            Balance = 98765

        };
        List<CCAccount> ccList = new List<CCAccount>();
        ccList.Add(ccAccount);
        List<SBAccount> sbList = new List<SBAccount>();
        sbList.Add(sbAccount);
        List<IAccount> accountsList = new List<IAccount>();
         accountsList.Add(ccAccount);
         accountsList.Add(sbAccount);
         foreach(IAccount account in accountsList){
            Console.WriteLine($"{account.AccountNumber} | {account.Name} | {account.Balance} |");
         }
         //accountsList[0].extra; eventhough cc account has extra property it can't be accessed

    }
}