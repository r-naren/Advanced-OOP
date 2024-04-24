using System;
namespace BankingApplication;
class Program{
    public static void Main(string[] args)
    {
        SavingAccount account1 = new SavingAccount("Luffy", "Dragon",new DateTime(2000,01,01), Gender.Male, "VID1002", "AID20483", "PID2384", AccountType.Savings, "HDFC", "HDFC1001", "Anna nagar", 2013 );
        account1.BalanceCheck();
        account1.Deposit(100);
        account1.Withdraw(1000);
        account1.BalanceCheck();
        Console.WriteLine($"");

        SavingAccount account2 = new SavingAccount("Sanji", "Vinsmoke",new DateTime(2002,11,17), Gender.Male, "VID1004", "AID6483", "PID8423", AccountType.Balance, "SBI", "SBI1003", "Poonamale", 18 );
        account2.BalanceCheck();
        account2.Deposit(1000.17);
        account2.Withdraw(100);
        account2.BalanceCheck();
        Console.WriteLine($"");
        
    }
}