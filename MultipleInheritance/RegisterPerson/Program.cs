using System;
namespace RegisterPerson;
class Program{
    public static void Main(string[] args)
    {
        RegisterPerson person1 = new RegisterPerson("Luffy", "76543", "luffy@gmail.com", new DateTime(2002,01,01), Gender.Male, MaritalStatus.Single, DateTime.Now, "Dragon", "Curly", "One piece",1);
        person1.ShowInfo();
        Console.WriteLine();
        RegisterPerson person2 = new RegisterPerson("Sanji", "1234", "sanji@gmail.com", new DateTime(2003,11,01), Gender.Male, MaritalStatus.Married, DateTime.Now, "Vinsmoke", "Sora", "North Blue",5);
        person2.ShowInfo();
        Console.WriteLine();
        
    }
}