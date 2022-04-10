using System;

namespace Task4
{
    class Program
    {
        static void Main()
        { int a = 0;
            Console.WriteLine("Hello, dear user!\n This program outputs triangle, which has hight is equal to N entered from keyboard");
            while (true)
            {
                Console.WriteLine("So, write N: ");
                string N = Console.ReadLine();
                if (int.TryParse(N, out int n) && n > 0)
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.SetCursorPosition(n - i -1, Console.CursorTop);
                        for (int j = 0; j <= i * 2; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                        if (i == a && a<n-1)
                        {
                            a++;
                            i = 0;
                            Console.SetCursorPosition(n - i -1, Console.CursorTop);
                            Console.Write("*");
                        Console.WriteLine();
                    }
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, you write not correct data. Numbers must be not negative and non-zero. Please, try again!");
                }

            }
        }
    }
}

