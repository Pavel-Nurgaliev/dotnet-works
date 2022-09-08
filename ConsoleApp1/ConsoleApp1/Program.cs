using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите n чисел");
            int n = int.Parse(Console.ReadLine());

            int summa = 0;

            for(var i=0; i < n; i++)
            {
                summa = summa + int.Parse(Console.ReadLine());
            }

            Console.WriteLine(summa);
        }

    }
}
