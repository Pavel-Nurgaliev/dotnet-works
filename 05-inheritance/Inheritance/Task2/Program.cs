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
        public virtual double Circumference
        {
            get
            {
                return (2 * Math.PI * _radius);
            }
        }
        public virtual double Area
        {
            get
            {
                return (Math.PI * _radius * _radius);
            }
        }
    }

    class Ring : Round
    {
        public Ring(int radius, int innerradius, int x, int y) : base(radius, x, y)
        {
            _innerradius = innerradius;
        }
        private double _innerradius;
        public override double Circumference
        {
            get
            {
                var result = base.Circumference + (2 * Math.PI * _innerradius);
                return result; // todo
            }
        }
        public override double Area // todo
        {
            get
            {
                var result = base.Area - (Math.PI * _innerradius * _innerradius);
                return result;
            }
        }
        public override string ToString()
        {
            // todo
            return ($"Площадь кольца: {Area}, длина кольца: {Circumference}" +
                $", длина внешней окружности: {base.Circumference}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите параметры кольца");
            Console.WriteLine("Внешний радиус:");
            int radius = int.Parse(Console.ReadLine());

            Console.WriteLine("Внутренний радиус:");
            int innerradius = int.Parse(Console.ReadLine());

            Console.WriteLine("Координата центра кольца по оси Х");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Координата центра кольца по оси Y");
            int y = int.Parse(Console.ReadLine());

            Ring ring = new Ring(radius, innerradius, x, y);
            Console.WriteLine(ring.ToString());

            Round ring2 = new Ring(radius, innerradius, x, y);
            Console.WriteLine(ring2.ToString());
        }
    }
}

/*
 * Локальные переменные и параметры - с маеленькой буквы (example)
 * Публичные свойства - с большой буквы (Example)
 * Приватные поля - с нижнего подчеркивания и с маелнькой буквы (_example)
 * 
 * Cirumference и Area - переопределяюстя свойства базового класса.
 * 
 * Обновим класс User, согласно новым правкам.
*/
