using System;
namespace InsertionSort;
class Program{
    public static void Main(string[] args)
    {
        int[] arr1 = new int[] { 45, 33, 12, 55, 77, 22, 33, 14, 67, 78, 22, 11, 44, 66, 88, 12, 35, 84, 93, 77 };
        string[] arr2 = new string[] { "SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092" };
        char[] arr3 = new char[] { 'c', 'a', 'f', 'b', 'k', 'h', 'j', 'I', 'i', 'z', 't', 'm', 'p', 'l', 'd' };
        double[] arr4 = new double[] { 1.1, 65.3, 93.9, 55.5, 3.5, 6.9 };
        int count1 = 0, count2 = 0, count3 = 0, count4 = 0;
       
        for (int i = 1; i < arr1.Length; ++i) {
            int key = arr1[i];
            int j = i - 1;
            while (j >= 0 && arr1[j] > key) {
                count1++;
                arr1[j + 1] = arr1[j];
                j = j - 1;
            }
            arr1[j + 1] = key;
        }
        for (int i = 1; i < arr2.Length; ++i) {
            string key = arr2[i];
            int j = i - 1;
            while (j >= 0 && arr2[j].CompareTo( key) >0) {
                count2++;
                arr2[j + 1] = arr2[j];
                j = j - 1;
            }
            arr2[j + 1] = key;
        }
        
        for (int i = 1; i < arr3.Length; ++i) {
            char key = arr3[i];
            int j = i - 1;
            while (j >= 0 && arr3[j] > key) {
                count3++;
                arr3[j + 1] = arr3[j];
                j = j - 1;
            }
            arr3[j + 1] = key;
        }
        for (int i = 1; i < arr4.Length; ++i) {
            double key = arr4[i];
            int j = i - 1;
            while (j >= 0 && arr4[j] > key) {
                count4++;
                arr4[j + 1] = arr4[j];
                j = j - 1;
            }
            arr4[j + 1] = key;
        }
        Console.WriteLine($"Insertion sort (Ascending):");
        Console.WriteLine($"{count1} | {count2} | {count3} | {count4}");
        count1=0;
        count2=0;
        count3=0;
        count4=0;
        for (int i = 1; i < arr1.Length; ++i) {
            int key = arr1[i];
            int j = i - 1;
            while (j >= 0 && arr1[j] < key) {
                count1++;
                arr1[j + 1] = arr1[j];
                j = j - 1;
            }
            arr1[j + 1] = key;
        }
        for (int i = 1; i < arr2.Length; ++i) {
            string key = arr2[i];
            int j = i - 1;
            while (j >= 0 && arr2[j].CompareTo( key) <0) {
                count2++;
                arr2[j + 1] = arr2[j];
                j = j - 1;
            }
            arr2[j + 1] = key;
        }
        
        for (int i = 1; i < arr3.Length; ++i) {
            char key = arr3[i];
            int j = i - 1;
            while (j >= 0 && arr3[j] < key) {
                count3++;
                arr3[j + 1] = arr3[j];
                j = j - 1;
            }
            arr3[j + 1] = key;
        }
        for (int i = 1; i < arr4.Length; ++i) {
            double key = arr4[i];
            int j = i - 1;
            while (j >= 0 && arr4[j] < key) {
                count4++;
                arr4[j + 1] = arr4[j];
                j = j - 1;
            }
            arr4[j + 1] = key;
        }
        Console.WriteLine($"Insertion sort (Descending):");
        Console.WriteLine($"{count1} | {count2} | {count3} | {count4}");
        
        
        


        

    
    
        
    }
}