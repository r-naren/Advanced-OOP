using System;
namespace SelectoionSort;
class Program
{
    public static void Main(string[] args)
    {
        int[] arr1 = new int[] { 45, 33, 12, 55, 77, 22, 33, 14, 67, 78, 22, 11, 44, 66, 88, 12, 35, 84, 93, 77 };
        string[] arr2 = new string[] { "SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092" };
        char[] arr3 = new char[] { 'c', 'a', 'f', 'b', 'k', 'h', 'j', 'I', 'i', 'z', 't', 'm', 'p', 'l', 'd' };
        double[] arr4 = new double[] { 1.1, 65.3, 93.9, 55.5, 3.5, 6.9 };
        int count1 = 0, count2 = 0, count3 = 0, count4 = 0;

        for (int i = 0; i < arr1.Length - 1; i++)
        {
            int min_idx = i;
            for (int j = i + 1; j < arr1.Length; j++)
            {
                
                if (arr1[j] < arr1[min_idx])
                {
                    count1++;
                    min_idx = j;
                }
            }
            int temp = arr1[min_idx];
            arr1[min_idx] = arr1[i];
            arr1[i] = temp;
        }
        for (int i = 0; i < arr2.Length - 1; i++)
        {
            int min_idx = i;
            for (int j = i + 1; j < arr2.Length; j++)
            {
                
                if (arr2[j].CompareTo(arr2[min_idx])>0)
                {
                    count2++;
                    min_idx = j;
                }
            }
            string temp = arr2[min_idx];
            arr2[min_idx] = arr2[i];
            arr2[i] = temp;
        }
        for (int i = 0; i < arr3.Length - 1; i++)
        {
            int min_idx = i;
            for (int j = i + 1; j < arr3.Length; j++)
            {
               
                if (arr3[j] < arr3[min_idx])
                {
                    count3++;
                    min_idx = j;
                }
            }
            char temp = arr3[min_idx];
            arr3[min_idx] = arr3[i];
            arr3[i] = temp;
        }
        for (int i = 0; i < arr4.Length - 1; i++)
        {
            int min_idx = i;
            for (int j = i + 1; j < arr4.Length; j++)
            {
                
                if (arr4[j] < arr4[min_idx])
                {
                    count4++;
                    min_idx = j;
                }
            }
            double temp = arr4[min_idx];
            arr4[min_idx] = arr4[i];
            arr4[i] = temp;
        }
        Console.WriteLine($"Selection sort (Ascending): ");
        Console.WriteLine($"Number of iteration : {count1} | {count2} | {count3} | {count4} ");
        count1 = 0;
         count2 = 0;
          count3 = 0;
           count4 = 0;

        for (int i = 0; i < arr1.Length - 1; i++)
        {
            int min_idx = i;
            for (int j = i + 1; j < arr1.Length; j++)
            {
                
                if (arr1[j] > arr1[min_idx])
                {
                    count1++;
                    min_idx = j;
                }
            }
            int temp = arr1[min_idx];
            arr1[min_idx] = arr1[i];
            arr1[i] = temp;
        }
        for (int i = 0; i < arr2.Length - 1; i++)
        {
            int min_idx = i;
            for (int j = i + 1; j < arr2.Length; j++)
            {
                
                if (arr2[j].CompareTo(arr2[min_idx])<0)
                {
                    count2++;
                    min_idx = j;
                }
            }
            string temp = arr2[min_idx];
            arr2[min_idx] = arr2[i];
            arr2[i] = temp;
        }
        for (int i = 0; i < arr3.Length - 1; i++)
        {
            int min_idx = i;
            for (int j = i + 1; j < arr3.Length; j++)
            {
               
                if (arr3[j] > arr3[min_idx])
                {
                    count3++;
                    min_idx = j;
                }
            }
            char temp = arr3[min_idx];
            arr3[min_idx] = arr3[i];
            arr3[i] = temp;
        }
        for (int i = 0; i < arr4.Length - 1; i++)
        {
            int min_idx = i;
            for (int j = i + 1; j < arr4.Length; j++)
            {
                
                if (arr4[j] > arr4[min_idx])
                {
                    count4++;
                    min_idx = j;
                }
            }
            double temp = arr4[min_idx];
            arr4[min_idx] = arr4[i];
            arr4[i] = temp;
        }
        Console.WriteLine($"Selection sort (Descending): ");
        Console.WriteLine($"Number of iteration : {count1} | {count2} | {count3} | {count4} ");
    
    }
}