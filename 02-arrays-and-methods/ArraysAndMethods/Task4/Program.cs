using System;
//using ClassLibrary1;

namespace Task4
{     
    class Program
    {   
        public static int[,] MassiveInit(int [,] arr)
        {
            Random r = new Random();
            for (int i=0; i<arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i,j] = r.Next(11);
                }
            }
            return arr;
        }
        public static void PrintArray2D(int [,] arr)
        {
            foreach (int x in arr)
            {
                Console.WriteLine(x);
            }
        }
        public static int GetSumOfElementsOnEvenPositions(int [,] arr)
        {
            int sum = 0;
            for (int i=0; i<arr.GetLength(0);i++)
            {
                for (int j=0; j < arr.GetLength(1); j++)
                {
                    if ((i+j)%2 ==0) 
                    { 
                        sum += arr[i, j];
                    }

                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[,] arr = new int[2,3];
            MassiveInit(arr);
            PrintArray2D(arr);
            int summa = GetSumOfElementsOnEvenPositions(arr);
            Console.WriteLine(summa);
        }
    }
}
