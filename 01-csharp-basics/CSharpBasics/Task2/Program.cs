using System;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, dear user!\n Result of program is image, which hight in N quantity of lines");
            while (true)
            {
                Console.WriteLine("Write number N:");
                string N = Console.ReadLine();
                if (int.TryParse(N, out int n) && n > 0)
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;
                }
                else Console.WriteLine("Sorry, you write not correct data. Numbers must be not negative and non-zero. Please, try again!");
            }
        }
    }
}
