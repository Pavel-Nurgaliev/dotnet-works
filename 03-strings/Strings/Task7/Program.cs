using System;
using System.Text.RegularExpressions;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = Console.ReadLine();
            Regex regex = new Regex(@"^([0-1]?[0-9]|2[0-3]):[0-5][0-9]$");
            MatchCollection match = regex.Matches(str);
            String result = match.Count.ToString();
            Console.WriteLine("в тексте присутствует {0} раз",result);
        }
    }
}
