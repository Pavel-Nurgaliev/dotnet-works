using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            OTwdp o1 = new OTwdp(1, 1);
            Console.WriteLine(o1.GetHashCode().ToString());
            o1 = new OTwdp(10, 10);
            Console.WriteLine(o1.GetHashCode().ToString());
            o1 = new OTwdp(1, 1);
            Console.WriteLine(o1.GetHashCode().ToString());
            o1 = new OTwdp(10, 10);
            Console.WriteLine(o1.GetHashCode().ToString());
        }
    }
}
