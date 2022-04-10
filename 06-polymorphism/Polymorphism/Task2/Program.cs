using System;

namespace Task2
{



    class Program
    {
        public static void PrintSeries(ISeries Series, int elements)
        {
            Series.Reset();
            for (int i = 0; i < elements; i++)
            {

                Console.WriteLine(Series.GetCurrent());
                Series.MoveNext();
            }
            Console.WriteLine($"Numbers of elemets is {elements}");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Write denominator of geometric progression: ");
            int denominator = int.Parse(Console.ReadLine());
            const int elements = 5;
            Random r = new Random(9);
            Console.WriteLine("result geometric progression: ");


            ISeries GP = GeometricProgression.Instance(1, elements);
            PrintSeries(GP, elements);
            Console.WriteLine("Expected number: ");
        }
    }
}

