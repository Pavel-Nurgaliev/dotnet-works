using System;

namespace Strings
{
    class Program
    {
        
        public static double Arithmeticmean(string InputStr)
        {
            int x = 0;
            double AM = 0;
            int[] LenSubStr = new int[20];
            
            string[] SubStr = InputStr.Split(' ');
            for (int i = 0; i < SubStr.Length; i++) //пробег по всем подстрокам
            {
                for (int j = 0; j < SubStr[i].Length; j++)//пробег по элементам подстрок
                {
                    char ch = SubStr[i][j];
                    if (char.IsPunctuation(ch) != true) //проверка на знаки пунктуации
                    {
                        LenSubStr[i]++; //вывод длины каждой подстроки
                    }

                }
                x += LenSubStr[i]; //суммирование количества элементов подстрок
            }
            AM = (double) x / SubStr.Length; //среднее арифметическое
            Console.WriteLine(x);
            Console.WriteLine(SubStr.Length);
            return AM;
        }
        static void Main()
        {
            string InputStr = Console.ReadLine();
            Console.WriteLine(Arithmeticmean(InputStr));
        }
        
    }
}
