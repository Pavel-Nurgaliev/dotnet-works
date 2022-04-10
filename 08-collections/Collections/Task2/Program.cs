using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] numnum = { 1, 2, 3, 4 };
            Num<int> num = new Num<int>(numnum);
            DynamicArray<int> a1 = new DynamicArray<int>(num);
            foreach (int i in num)
            {

            }
        }
    }
}
