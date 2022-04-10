using System;
using System.Text;
using System.Diagnostics;

namespace Task4
{
    class Program
    {

        
    static void Main(string[] args)
        {
            string str = "";
            StringBuilder sb = new StringBuilder();
            int N = 50000;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < N; i++)
            {
                str += "*";
            }
            long ts = stopWatch.ElapsedMilliseconds;
            Stopwatch stopWatch2 = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }
            long ts2 = stopWatch2.ElapsedMilliseconds;
            Console.WriteLine("String: {0}",ts);
            Console.WriteLine("StringBuilder: {0}",ts2);
        }
    }
}
