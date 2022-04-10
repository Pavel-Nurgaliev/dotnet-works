using System;
//using ClassLibrary1;

namespace Task3
{
    class Program
    {
        public static void MasiveInit(int [] arr)
        {
            Random r = new Random();
            for (int i=0; i<arr.Length;i++)
            {
                arr[i] = r.Next(11)-5;
            }
        }
        
        public static int GetSumOfNonNegativeElements(int[] arr)
        {
            int sum=0;
            for (int i=0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
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
            int[] arr = new int[5];
            MasiveInit(arr);
            PrintArray(arr);
            int summa = GetSumOfNonNegativeElements(arr);
            Console.WriteLine(summa);
        }
    }
}
