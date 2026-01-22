// using System;

// class Sorting
// {
//     public static void CountSort(int[] arr, int maxValue)
//     {
//         int[] count = new int[maxValue + 1];

//         foreach (int num in arr)
//             count[num]++;

//         int index = 0;
//         for (int i = 0; i <= maxValue; i++)
//         {
//             while (count[i] > 0)
//             {
//                 arr[index++] = i;
//                 count[i]--;
//             }
//         }
//     }

//     public static void RadixSort(int[] arr)
//     {
//         int max = GetMax(arr);

//         for (int exp = 1; max / exp > 0; exp *= 10)
//             CountingSortByDigit(arr, exp);
//     }

//     static int GetMax(int[] arr)
//     {
//         int max = arr[0];
//         foreach (int num in arr)
//             if (num > max)
//                 max = num;

//         return max;
//     }

//     static void CountingSortByDigit(int[] arr, int exp)
//     {
//         int n = arr.Length;
//         int[] output = new int[n];
//         int[] count = new int[10];

//         for (int i = 0; i < n; i++)
//             count[(arr[i] / exp) % 10]++;

//         for (int i = 1; i < 10; i++)
//             count[i] += count[i - 1];

//         for (int i = n - 1; i >= 0; i--)
//         {
//             int digit = (arr[i] / exp) % 10;
//             output[count[digit] - 1] = arr[i];
//             count[digit]--;
//         }

//         for (int i = 0; i < n; i++)
//             arr[i] = output[i];
//     }

//     public static void PrintArray(int[] arr)
//     {
//         foreach (int num in arr)
//             Console.Write(num + " ");

//         Console.WriteLine();
//     }
// }
