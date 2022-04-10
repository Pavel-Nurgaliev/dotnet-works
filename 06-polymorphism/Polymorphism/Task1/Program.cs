using System;

namespace Task1
{
    class Program
    {
        public static void PrintInfo(double length, double radiusRound, double radiusCircle,
            double radius1, double radius2, double width, double height)
        {
            Figure[] figures = new Figure[5];
            // 1. проинициализировать массив разными типами
            // 2. в цикле вызываем Draw().

            // Скриншоты: Line, PrintInfo, Console

            for (int i = 0; i < figures.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        Line line = new Line(length);
                        figures[i] = line;
                        break;
                    case 1:
                        Circle circle = new Circle(radiusCircle);
                        figures[i] = circle;
                        break;
                    case 2:
                        Rectangle rectangle = new Rectangle(width, height);
                        figures[i] = rectangle;
                        break;
                    case 3:
                        Ring ring = new Ring(radius1, radius2);
                        figures[i] = ring;
                        break;
                    case 4:
                        Round round = new Round(radiusRound);
                        figures[i] = round;
                        break;
                }
            }
            foreach (var figure in figures)
            {
                if (figure == null) break;
                figure.Draw();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write width for rectangle: ");
            double isWidth = double.Parse(Console.ReadLine());

            Console.WriteLine("Write height for rectangle: ");
            double isHeight = double.Parse(Console.ReadLine());

            Console.WriteLine("Write length for line: ");
            double isLength = double.Parse(Console.ReadLine());

            Console.WriteLine("Write radius for circle: ");
            double isRadiusCircle = double.Parse(Console.ReadLine());

            Console.WriteLine("Write radius for round: ");
            double isRadiusRound = double.Parse(Console.ReadLine());

            Console.WriteLine("Write inner radius for ring: ");
            double isradius1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Write outer radius for ring: ");
            double isradius2 = double.Parse(Console.ReadLine());
            PrintInfo(isLength, isRadiusRound, isRadiusCircle, isradius1, isradius2, isWidth, isHeight);
        }
    }
}
