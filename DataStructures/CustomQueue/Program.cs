using System;
namespace CustomQueue;
class Program{
    public static void Main(string[] args)
    {
        CustomQueue<int> queue = new CustomQueue<int>();
        queue.Enqueue(6);
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);
        Console.WriteLine($"{queue.Peek()}");
        Console.WriteLine($"{queue.Dequeue()}");
        Console.WriteLine($"{queue.Dequeue()}");
        Console.WriteLine($"");
        
        foreach(int value in queue){
            Console.WriteLine($"{value}");
            
        }
    }
}