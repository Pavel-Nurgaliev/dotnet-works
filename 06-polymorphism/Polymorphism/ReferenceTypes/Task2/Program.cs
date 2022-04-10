using System;

namespace Task2
{
    class Round
    {
        /*Radius – получение радиуса;
        X – X-координата центра;
        Y – Y-координата центра;
        Circumference – получение длины окружности;
        Area – получение площади.*/
        public Round(int radius, int x, int y)
        {
            Radius = radius;
            X = x;
            Y = y;
        }
        private double _radius;
        private double _x;
        private double _y;
        public override string ToString()
        {
            return ($"Длина окружности: {Circumference}, Площадь окружности:{Area}");
        }
        public double Radius
        {
            get
            {
                return _radius;
            }


            private set
            {
                if (value >= 0)
                {
                    _radius = value;
                }
                else
                {
                    throw new ArgumentException("Введите неотрицательное число");
                }

            }
        }
        public double X
        {
            get
            {
                return _x;
            }
            private set
            {
                _x = value;
            }
        }
        public double Y
        {
            get
            {
                return _y;
            }
            private set
            {
                _y = value;
            }
        }
        public double Circumference
        {
            get
            {
                return (2 * Math.PI * _radius);
            }
        }
        public double Area
        {
            get
            {
                return (Math.PI * _radius * _radius);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите параметры круга");
            Console.WriteLine("Радиус:");
            int radius = int.Parse(Console.ReadLine());

            Console.WriteLine("Координата центра круга по оси Х");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Координата центра круга по оси Y");
            int y = int.Parse(Console.ReadLine());

            Round round = new Round(radius, x, y);
            Console.WriteLine(round.ToString());

        }
    }
}
