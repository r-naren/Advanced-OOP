using System;
namespace Dictionary;
class Program
{
    public static void Main(string[] args)
    {
        CustomDictionary<string, string> customDictionary = new CustomDictionary<string, string>();
        customDictionary.Add("54", "jjj");
        customDictionary.Add("55", "ytresr");
        foreach (KeyValue<string, string> data in customDictionary)
        {
            Console.WriteLine($"Key : {data.Key}, Value : {data.Value}");
        }
        Console.WriteLine($"{customDictionary["54"]}");
        customDictionary["54"] = "Ram";
        Console.WriteLine($"{customDictionary["54"]}");

    }
}