using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApplication
{
    public enum AccountType{Savings, Balance}
    public class SavingAccount : IDInfo, ICalculate, IBankInfo
    {
        private static int s_accountNumber  = 1000;
        public string AccountNumber{get;set;}
        public AccountType AccountType {get;set;}
        public double Balance {get;set;}
        public string BankName {get;set;}
        public string IFSC {get;set;}
        public string Branch {get;set;}
        public SavingAccount(string name,  string phone,  DateTime dob, Gender gender, string voterID, string aadharID, string panNumber, AccountType accountType, string bankName, string ifsc, string branch, double balance) : base( name,   phone,   dob,  gender,  voterID,  aadharID,  panNumber){
            AccountNumber = "AID"+ ++s_accountNumber;
            AccountType = accountType;
            BankName = bankName;
            IFSC = ifsc;
            Branch = branch;
            Balance = balance;
        }
        public void Deposit(double amount){
            Balance += amount;
        }
        public void Withdraw(double amount){
            Balance -= amount;
        
        }
        public void BalanceCheck(){
            Console.WriteLine($"Balance : {Balance}");
            
        }

    }
}