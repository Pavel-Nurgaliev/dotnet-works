using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public static int[] GenerateArray(int num)
        {
            int[] arr = new int[num];
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(11);
            }
            return arr;
        }
        public static int[] SortAndGetMinAndMaxValues(int num, int[] arr1)
        {
            int x;
            for (int i = 0; i < num; i++)
            {
                for (int j = i; j < num; j++)
                {
                    if (arr1[i] > arr1[j])
                    {
                        x = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = x;
                    }
                }
            }
            return arr1;
        }
        public static void PrintArray(int[] arrx)
        {
            foreach (int x in arrx)
            {
                Console.WriteLine(x);
            }
        }
            public static int [,,] PrintArray3D(int[,,] arrx)
            {
                for (int i = 0; i < arrx.GetLength(0); i++)
                {
                    for (int j = 0; j < arrx.GetLength(1); j++)
                    {
                        for (int k = 0; k < arrx.GetLength(2); k++)
                        {
                            Console.Write("\t{0}", arrx[i, j, k] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\n");
                }
                return arrx;
            }
        }
    }
