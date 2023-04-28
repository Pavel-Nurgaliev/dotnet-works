using System;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, dear user!\nThis project presents solution for calculate area of rectangle");
            while (true)
            {
                Console.WriteLine("So, write length: ");
                string sideAxStr = Console.ReadLine();

                Console.WriteLine("write width: ");
                string sideBxStr = Console.ReadLine();
                try
                {
                    int sideAx = int.Parse(sideAxStr);
                    int sideBx = int.Parse(sideBxStr);
                    if (sideAx > 0 && sideBx > 0)
                    {
                        Console.WriteLine($"{sideAx * sideBx}");
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
