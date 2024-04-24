using System;
using System.Security.AccessControl;
namespace LinearSearch;
class Program
{
    public static void Main(string[] args)
    {
        int[] arr1 = new int[] { 45, 33, 12, 55, 77, 22, 33, 14, 67, 78, 22, 11, 44, 66, 88, 12, 35, 84, 93, 77 };
        int key1 =  66;
        string[] arr2 = new string[] { "SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092" };
        string key2 = "SF3067";
        char[] arr3 = new char[] { 'c', 'a', 'f', 'b', 'k', 'h', 'j', 'I', 'i', 'z', 't', 'm', 'p', 'l', 'd' };
        char key3= 'm';
        double[] arr4 = new double[] { 1.1, 65.3, 93.9, 55.5, 3.5, 6.9 };
        double key4 = 3.5;
        int count1=0, count2=0, count3=0, count4=0;

        for (int i = 0; i < arr1.Length; i++)
        {
            count1++;
            if (arr1[i] == key1){
                break;
            }
        }
        for (int i = 0; i < arr2.Length; i++)
        {
            count2++;
            if (arr2[i] == key2){
                break;
            }
        }
        for (int i = 0; i < arr3.Length; i++)
        {
            count3++;
            if (arr3[i] == key3){
                break;
            }
        }
        for (int i = 0; i < arr4.Length; i++)
        {
            count4++;
            if (arr4[i] == key4){
                break;
            }
        }
        Console.WriteLine($"Linear Search : ");
        Console.WriteLine($"Time Complexity : {count1} | {count2} | {count3} | {count4} "); // 14 | 3 | 12 | 5

        
    }
}