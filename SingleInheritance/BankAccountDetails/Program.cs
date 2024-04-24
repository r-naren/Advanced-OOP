using System;
namespace BankAccountDetails;
class Program{
    public static void Main(string[] args)
    {
        PersonalInfo personal1 = new PersonalInfo("Naren", "Ramasamy", "9876543201", "naren@gmail.com", new DateTime(2012,02,02), Gender.Male);
        AccountInfo account1 = new AccountInfo(personal1.Name,personal1.FatherName, personal1.Phone, personal1.Mail, personal1.DOB, personal1.Gender, "Chennai", "HDFC1001",1000);
        account1.ShowAccountInfo();
        account1.Deposit(100);
        account1.Withdraw(50);
        account1.ShowBalance();
        Console.WriteLine();
        
        PersonalInfo personal2 = new PersonalInfo("Nico", "Robin", "9999999999", "nico@gmail.com", new DateTime(2007,04,04), Gender.Female);
        AccountInfo account2 = new AccountInfo(personal2.Name,personal2.FatherName, personal2.Phone, personal2.Mail, personal2.DOB, personal2.Gender, "Rameshwaram", "HDFC1212",2000.45);
        account2.ShowAccountInfo();
        account2.Deposit(117.6);
        account2.Withdraw(50.9);
        account2.ShowBalance();
        Console.WriteLine();
        
        PersonalInfo personal3 = new PersonalInfo("Ram", "Geer", "88888888888", "ram@gmail.com", new DateTime(2002,11,30), Gender.Male);
        AccountInfo account3 = new AccountInfo(personal3.Name,personal3.FatherName, personal3.Phone, personal3.Mail, personal3.DOB, personal3.Gender, "Chengalpat", "HDFC3111",3134.45);
        account3.ShowAccountInfo();
        account3.Deposit(1017.78);
        account3.Withdraw(456.91);
        account3.ShowBalance();
    }
}