using System;
namespace AnimalInfo;
class Program{
    public static void Main(string[] args)
    {
        Dog dog1 = new Dog("Pomerian", "Habitat1", "Bones");
        dog1.DisplayName();
        dog1.DisplayInfo();
        Console.WriteLine();
        
        Dog dog2 = new Dog("Husky", "Habitat2", "Non veg");
        dog2.DisplayName();
        dog2.DisplayInfo();
        Console.WriteLine();
        Duck duck1 = new Duck("Duckk1", "Habitat3", "Fish");
        duck1.DisplayName();
        duck1.DisplayInfo();
        Console.WriteLine();
        Duck duck2 = new Duck("Duck2", "Habitat4", "Frog");
        duck2.DisplayName();
        duck2.DisplayInfo();
        Console.WriteLine();
        
    }
}