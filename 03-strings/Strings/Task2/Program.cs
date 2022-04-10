using System;
using System.Text.RegularExpressions;
namespace Task2
{   
    class Program
    {   
        public static void DoubleSymbols(String FirstMessage, String SecondMessage,out String OutputMessage)
            /*удваивает кол-во
            повторяющихся элементов
            в выходной строке*/
        {
            OutputMessage = "";
            for (int i = 0; i < FirstMessage.Length; i++)//пробег по элементам 1-ой строки
            {
                OutputMessage += FirstMessage[i];//добавление символа в выходную строку
                for (int j = 0; j < SecondMessage.Length; j++)//пробег по элементам второй строки
                {
                    if ((FirstMessage[i] == SecondMessage[j]) && FirstMessage[i] != FirstMessage[i + 1])
                        //проверка на совпадение и исключение повторения больше двух раз
                    {
                        OutputMessage += FirstMessage[i];//добавление к выходной строке
                        break;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            String OutputMessage;//объявление выходной строки
            String FirstMessage = Console.ReadLine();//ввод первой строки
            String SecondMessage = Console.ReadLine();//вод второй строки
            DoubleSymbols(FirstMessage, SecondMessage, out OutputMessage);//удвоение символов
            Console.WriteLine(OutputMessage);//вывод
        }
    }
}
