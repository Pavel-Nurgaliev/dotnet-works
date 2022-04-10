using System;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, dear user!\nThis project presents solution for colcolate area of rectangle");
            while (true)
            {
                Console.WriteLine("So, write length: ");
                string ax = Console.ReadLine();
                Console.WriteLine("write width: ");
                string bx = Console.ReadLine();
                try
                {
                    int a = int.Parse(ax);
                    int b = int.Parse(bx);
                    if (a > 0 && b > 0)
                    {
                        Console.WriteLine($"{a * b}");
                        break;
                    }
                    else
                        Console.WriteLine("Sorry, you write not correct data. Numbers must be not negative and non-zero. Please, try again!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Sorry, you write not correct data. Numbers must be not negative and non-zero. Please, try again!");
                }
            }

        }
    }
}
