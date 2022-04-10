using System;
using System.Text.RegularExpressions;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"<[^>]+>"); //<text>
            string str = Console.ReadLine();
            string result = regex.Replace(str,"_");
            Console.WriteLine("Результат замены: {0}",result);
        }
    }
}
