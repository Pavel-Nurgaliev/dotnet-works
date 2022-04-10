using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int elements = 5;
            ISeries progression = new ArithmeticalProgression(2, elements);
            IIndexableSeries progressionInd = new ArithmeticalProgression(2, elements);
            Console.WriteLine("Progression:");
            PrintSeries(progression, elements);


            Console.WriteLine("Progression indexable:");
            PrintIndexable(progressionInd, elements);


            ISeries list = new List(new double[] { 2, 7, 12, 22, 27 });
            IIndexableSeries listInd = new List(new double[] { 2, 7, 12, 22, 27 });
            Console.WriteLine("List:");
            PrintSeries(list, elements);


            Console.WriteLine("List indexable:");
            PrintIndexable(listInd, elements);
        }
        static void PrintSeries(ISeries series, int elements)
        {
            series.Reset();

            for (int i = 0; i < elements; i++)
            {
                Console.WriteLine(series.GetCurrent());
                series.MoveNext();
            }
        }

        static void PrintIndexable(IIndexable series, int elements)
        {

            for (int i = 0; i < elements; i++)
            {
                Console.WriteLine(series[i]);
            }
        }
    }
}
