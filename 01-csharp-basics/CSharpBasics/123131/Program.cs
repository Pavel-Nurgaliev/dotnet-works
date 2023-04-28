using System;
using System.Collections.Generic;

namespace _123131
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string parameter = "AAA";

            List<string> list = new List<string>();
            list.Add(parameter);

            DoSomething(list);

            foreach (var elem in list)
                Console.WriteLine(elem);
        }

        private static void DoSomething(List<string> list) => list.Add("123");
    }
}
