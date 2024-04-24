using System;
namespace Overriding;
public class Animal{
    public virtual void Eat(){
        Console.WriteLine($"Animals eats food.");
    }
}
public class Dog:Animal{
    public override void Eat(){
        Console.WriteLine($"Dog eats bone");
        base.Eat();
    }
    
}
public class Pomerian:Dog{
    public override void Eat()
    {
        Console.WriteLine($"Pomerian eats food"); 
        base.Eat();
    }
}
class Program{
    public static void Main(string[] args)
    {
        Animal animal = new Animal();
        animal.Eat();
        Dog dog = new Dog();
        dog.Eat();
        Pomerian pomerian = new Pomerian();
        pomerian.Eat();

    }
}