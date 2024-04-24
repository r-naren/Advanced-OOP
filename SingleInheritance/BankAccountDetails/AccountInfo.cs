using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccountDetails
{
   public class AccountInfo : PersonalInfo
    {
        private static int s_AccountNumber = 2000;
        public string AccountNumber { get; }
        public string BranchName { get; set; }
        public string IFSCCode { get; set; }
        public double Balance { get; set; }
        public AccountInfo(string name, string fatherName, string phone, string mail, DateTime dob, Gender gender, string branchName,string ifscCode, double balance) : base( name,  fatherName,  phone,  mail,  dob,  gender)
        {
            AccountNumber = "AID" + ++s_AccountNumber;
            BranchName = branchName;
            IFSCCode = ifscCode;
            Balance = balance;
        }

        public void ShowAccountInfo(){
            Console.WriteLine($"Reg. No : {AccountNumber}\nName : {Name}\nFather Name : {FatherName}\nPhone: {Phone}\nMail : {Mail}\nDOB : {DOB.ToString("dd/MM/yyyy")}\nGender : {Gender}\nBranchName : {BranchName}\nIFSC code: {IFSCCode}\nShow Balance : {Balance}");
        }
        public void Deposit(double amount){
            Balance += amount;
        }
        public void Withdraw(double amount){
            Balance -= amount;
        }
        public void ShowBalance(){
            Console.WriteLine($"Balance : {Balance}");
        }

    }
}