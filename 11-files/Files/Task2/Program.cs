using System;
using System.IO;

namespace Task2
{
    class Program
    {

        static void Main(string[] args)
        {

            string key = "";
            Console.WriteLine("Hello dear user!");
            Console.WriteLine("For continue send any symbol");
            while (Console.ReadLine() != "-q")//выход из проги
            {
                key = First_Display();
                Console.WriteLine("For out to program send -q");
                Watcher watcher1 = key == "-o" ? new Watcher() : null;//запуск режима наблюдения
                Change watcher2 = key == "-c" ? new Change() : null;//запуск режима отката
            }
        }
        public static string First_Display()
        {
            while (true)
            {
                Console.WriteLine("Select mode: key \"-o\" - observation mode;" +
                    "key \"-c\" - change mode");
                string key = Console.ReadLine();
                switch (key)
                {
                    case "-o":
                        Console.WriteLine("Observation mode successfully sellected, for back send \"-b\"");
                        return key;

                    case "-c":
                        Console.WriteLine("Change mode successfully sellected, for back send \"-b\"");
                        return key;
                    default:
                        Console.WriteLine("Repeat write command");
                        break;
                }
            }
        }
    }
}
//исправлена работа программы