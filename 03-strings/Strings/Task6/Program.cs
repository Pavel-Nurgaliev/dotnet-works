using System;
using System.Text.RegularExpressions;

namespace Task6
{
    class Program
    {
        // 1. сделать ТОЛЬКО - доп элементом
        // 2. оставить только проверку на e внутри чисел
        public static void calculate()
        {
            while (true)
            {
                String str = Console.ReadLine();
                if (Regex.IsMatch(str, @"^[-]?[0-9]*[.,][0-9]+([e][-+]?[0-9]+)$"))
                {
                    Console.WriteLine("Это число в научной нотации");
                }
                else if (Regex.IsMatch(str, @"(^[-]?[0-9]*([.,][0-9])?$)"))
                {
                    Console.WriteLine("Это число в обычной нотации");
                }
                else
                {
                    Console.WriteLine("Это не число");
                }
            }
        }
        static void Main(string[] args)
        {
            calculate();
        }
    }
}
