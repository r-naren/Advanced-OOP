using System;
namespace CustomStack;
class Program{
    public static void Main(string[] args)
    {
        Stack<int> myStack = new Stack<int>();
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);
        myStack.Push(4);
        myStack.Push(5);
        myStack.Push(6);
        myStack.Push(7);
        Console.WriteLine($"{myStack.Peek()}");
        Console.WriteLine($"{myStack.Pop()}");
        Console.WriteLine($"{myStack.Peek()}");
        Console.WriteLine($"{myStack.Contains(4)}");
        myStack.Clear();
        
        
        
    }
}