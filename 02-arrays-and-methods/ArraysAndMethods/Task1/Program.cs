using System;
//using ClassLibrary1;
namespace ArraysAndMethods
{
    class Program
    {
        public static int[] GenerateArray()
        {
            int[] arr = new int[5];
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(11);
            }
            return arr;
        }
        public static int[] SortAndGetMinAndMaxValues(int[] arr, out int min, out int max)
        {
            for (int i = 0; i <arr.Length; i++)
            {
                for (int j = i; j <arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int x = arr[i];
                        arr[i] = arr[j];
                        arr[j] = x;
                    }
                }
            }
            min = arr[0];
            max = arr[arr.Length-1];

            return arr;
        }
        public static void PrintArray(int[] arr)
        {
            foreach (int x in arr)
            {
                Console.WriteLine(x);
            }
        }
        static void Main(string[] args)
        {
            int[] arr =GenerateArray();
            SortAndGetMinAndMaxValues(arr,out int min,out int max);
            PrintArray(arr);
           // Console.Write($"min -{min}\tmax- {max}");
        }
    }
}
