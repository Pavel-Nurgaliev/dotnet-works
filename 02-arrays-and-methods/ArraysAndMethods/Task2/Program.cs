using System;
//using ClassLibrary1;
namespace Task2
{   
    class Program
    {
        public static void ReplacePositiveElementsWithZero(int[,,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        if (arr[i, j, k] > 0)
                        {
                            arr[i, j, k] = 0;
                        }
                        Console.Write("\t{0}", arr[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n");
            }
        }

        public static int[,,] MassiveInit(int[,,] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        arr[i, j, k] = random.Next(11);
                    }
                }
            }
            return arr;
        }
        public static int[,,] PrintArray3D(int[,,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.Write("\t{0}", arr[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            return arr;
        }
        static void Main(string[] args)
        {
            int[,,] arr = new int[2, 3, 4];
            MassiveInit(arr);
            PrintArray3D(arr);
            Console.WriteLine("=====================================================");
            ReplacePositiveElementsWithZero(arr);
            //PrintArray3D(arr);
        }
    }
}
