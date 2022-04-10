using System;
using System.Globalization;
using System.Threading;
/*Основное
Разработать консольное приложение, которое выводит на экран (в виде таблицы) отличия в параметрах культур:
"ru" vs "en"
"en" vs "invariant"
"ru" vs "invariant"

Необходимо вывести на экране отличия в:

формате отображения даты и времени,
формате отображения числовых данных (разделитель дробной и целой части, разделитель групп разрядов и т.п.)
NOTE: Целесообразно реализовать отдельный метод,
который принимает на входе объекты CultureInfo и выводит отличия на экран.
Повторно использовать этот метод (Code Reuse) для вывода различных пар культур.*/
namespace Task3
{
    class Program
    {   
        public static void OutputCulture()
        {
            Console.WriteLine("{0,-22}{1,-20}{2,-12}{3,-25}{4,-20}", "FORMAT", "OF CULTURE", "VS", "FORMAT", "OF CULTURE");
            String[] str = new String[3];
            String[] cult = { "Invariant", "ru-Ru", "en-Us" };
            str[0] = DateTime.Now.ToString("", CultureInfo.InvariantCulture);
            str[1] = DateTime.Now.ToString("", CultureInfo.CreateSpecificCulture(cult[1]));
            str[2] = DateTime.Now.ToString("", CultureInfo.CreateSpecificCulture(cult[2]));
            Console.WriteLine("{0,-22}{1,-20}{2,-12}{3,-25}{4,-20}", str[1], cult[1], "", str[2], cult[2]);
            Console.WriteLine("{0,-22}{1,-20}{2,-12}{3,-25}{4,-20}", str[1], cult[1], "", str[0], cult[0]);
            Console.WriteLine("{0,-22}{1,-20}{2,-12}{3,-25}{4,-20}", str[2], cult[2], "", str[0], cult[0]);
        }
        static void Main(string[] args)
        {
            OutputCulture();
        }
    }
}
