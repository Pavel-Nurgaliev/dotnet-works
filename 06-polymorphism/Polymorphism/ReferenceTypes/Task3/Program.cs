using System;
/*Основное
Написать класс Triangle, описывающий треугольник со сторонами A, B, C, и методами, позволяющими осуществить расчёт его площади и периметра.

NOTE: Учесть условия существования треугольника.

Класс должен содержать:

Конструктор, принимающий три целочисленных параметра – длины сторон треугольника.
Свойства A, B, C.
Методы:
GetArea – получение площади;
GetPerimeter – получение периметра треугольника.*/
namespace Task3
{
    class Triangle
    {
        public Triangle(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException($"{a},{b},{c},\"сторона треугольника отрицательная\"");
            }
            else if (a + b <= c && a + b <= c && a + b <= c)
            {
                throw new ArgumentException($"{a},{b},{c}," +
                    $"\"треугольник с заданными сторонами не существует\"");
            }
            _a = a;
            _b = b;
            _c = c;
        }

        private int _a;
        private int _b;
        private int _c;
        public double GetArea()
        {

            double p = GetPerimetr() / 2;
            double S = (double)(Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c)));

            return S;

        }
        public double GetPerimetr()
        {
            double P = _a + _b + _c;
            return P;
        }
        public override string ToString()
        {
            return ($"Периметр треугольника: {GetPerimetr()}, Площадь треугольника: {GetArea()} ");
        }

    }
    class Program
    {

        static void Main()
        {
            Console.WriteLine("Triangle");
            Console.WriteLine("Введите сторону первую сторону треугольника А");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите сторону первую сторону треугольника B");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите сторону первую сторону треугольника C");
            int c = int.Parse(Console.ReadLine());

            Triangle tr = new Triangle(a, b, c);
            Console.WriteLine(tr.ToString());
        }
    }
}
