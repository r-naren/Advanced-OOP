using System;
namespace ListDS;
class Program
{
    public static void Main(string[] args)
    {

        CustomList<string> customList = new CustomList<string>();
        customList.Add("RAM");
        customList.Add("dsf");
        customList.Add("hfg");
        customList.Add("eqwre");
        customList.Add("RAlkiujhM");
        customList.Add("2wed");
        CustomList<string> list1 = new CustomList<string>();
        list1.Add("Befca");
        list1.Add("[;.l[;]]");
        
        customList.AddRange(list1);
        for(int i=0;i<customList.Count;i++){
            Console.WriteLine($"{customList[i]} ");
            
        }
        Console.WriteLine(customList.Contains("Befca"));
        Console.WriteLine(customList.IndexOf("Beca"));
        customList.Insert(2,"asdfghjk");
        for(int i=0;i<customList.Count;i++){
            Console.WriteLine($"{customList[i]} ");
            
        }
        customList.RemoveAt(13);
        for(int i=0;i<customList.Count;i++){
            Console.WriteLine($"{customList[i]} ");
            
        }
        Console.WriteLine($"{customList.Remove("RAM")}");
        customList.Reverse();
        Console.WriteLine($"Reverse");
        
        foreach(string value in customList){
            Console.WriteLine($"{value }");
        }
        Console.WriteLine($"Insert range");
        
        customList.InsertRange(1,new CustomList<string>{"abc","bcd"});
        foreach(string value in customList){
            Console.WriteLine($"{value }");
        }
        Console.WriteLine($"");
        customList.Sort();
        foreach(string value in customList){
            Console.WriteLine($"{value }");
        }

        
    }
}