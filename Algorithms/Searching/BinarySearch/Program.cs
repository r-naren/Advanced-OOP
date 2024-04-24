using System;
using System.Security.Cryptography.X509Certificates;
namespace BinarySearch;
class Program
{
    public static void Main(string[] args)
    {
        int[] arr1 = new int[] { 45, 33, 12, 55, 77, 22, 33, 14, 67, 78, 22, 11, 44, 66, 88, 12, 35, 84, 93, 77 };
        for (int i = 0; i < arr1.Length - 1; i++)
        {
            for (int j = 0; j < arr1.Length - i - 1; j++)
            {
                if (arr1[j] > arr1[j + 1])
                {
                    int temp = arr1[j];
                    arr1[j] = arr1[j + 1];
                    arr1[j + 1] = temp;
                }
            }
        }
        
        int key1 = 66;
        string[] arr2 = new string[] { "SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092" };
        for (int i = 0; i < arr2.Length - 1; i++)
        {
            for (int j = 0; j < arr2.Length - i - 1; j++)
            {
                if (arr2[j].CompareTo(arr2[j + 1]) > 0)
                {
                    string temp = arr2[j];
                    arr2[j] = arr2[j + 1];
                    arr2[j + 1] = temp;
                }
            }
        }
        
        string key2 = "SF3067";
        char[] arr3 = new char[] { 'c', 'a', 'f', 'b', 'k', 'h', 'j', 'I', 'i', 'z', 't', 'm', 'p', 'l', 'd' };
        for (int i = 0; i < arr3.Length - 1; i++)
        {
            for (int j = 0; j < arr3.Length - i - 1; j++)
            {
                if (arr3[j] > arr3[j + 1])
                {
                    char temp = arr3[j];
                    arr3[j] = arr3[j + 1];
                    arr3[j + 1] = temp;
                }
            }
        }
        char key3 = 'm';
        double[] arr4 = new double[] { 1.1, 65.3, 93.9, 55.5, 3.5, 6.9 };
        for (int i = 0; i < arr4.Length - 1; i++)
        {
            for (int j = 0; j < arr4.Length - i - 1; j++)
            {
                if (arr4[j] > arr4[j + 1])
                {
                    double temp = arr4[j];
                    arr4[j] = arr4[j + 1];
                    arr4[j + 1] = temp;
                }
            }
        }

        double key4 = 3.5;
        int count1 = 0, count2 = 0, count3 = 0, count4 = 0;


        int left = 0, right = arr1.Length - 1;
        while (left <= right)
        {
            count1++;
            int mid = left + (right - left) / 2;
            if (arr1[mid] == key1)
            {
                break;
            }
            if (arr1[mid] < key1)
            {
                left = mid + 1;
            }

            else
            {
                right = mid - 1;
            }
        }
        left = 0;
        right = arr2.Length-1;
        while (left <= right)
        {
            count2++;
            int mid = left + (right - left) / 2;
            if (arr2[mid] == key2)
            {
                break;
            }
            if (arr2[mid].CompareTo(key2) < 0)
            {
                left = mid + 1;
            }

            else
            {
                right = mid - 1;
            }
        }
        left = 0;
        right = arr3.Length-1;
        while (left <= right)
        {
            count3++;
            int mid = left + (right - left) / 2;
            if (arr3[mid] == key3)
            {
                break;
            }
            if (arr3[mid] < key3)
            {
                left = mid + 1;
            }

            else
            {
                right = mid - 1;
            }
        }
        left = 0;
        right = arr4.Length-1;
        while (left <= right)
        {
            count4++;
            int mid = left + (right - left) / 2;
            if (arr4[mid] == key4)
            {
                break;
            }
            if (arr4[mid]< key4)
            {
                left = mid + 1;
            }

            else
            {
                right = mid - 1;
            }
        }
        Console.WriteLine($"Binary Search : ");
        Console.WriteLine($"Time Complexity : {count1} | {count2} | {count3} | {count4} "); // 4 | 2 | 2 | 3
    }
}