using System;
namespace Inside;
using Outside;
class Program
{
    public static void Main(string[] args)
    {
        First first = new First();
        Second second = new Second();
        Console.WriteLine($"{first.PrivateOut} | {first.PublicNumber} | {second.ProtectedNumberOut}");
        Console.WriteLine($"{first.InternalProtectedNumber}");
        
        Console.WriteLine($"{first.InternalProtectOut}");

    }
}