using System;

namespace Task5
{
    class Program
    {
        static void Main()
        {
            //float x1, x2;
            int a=0;
           for (int i = 1; i<10; i++)
            {
                //x1 = i % 3;
                //x2 = i % 5;
                if (i%3==0 || i%5==0)
                {
                    a +=i ;
                    
                }
            }
            Console.WriteLine(a);
        }
    }
}
