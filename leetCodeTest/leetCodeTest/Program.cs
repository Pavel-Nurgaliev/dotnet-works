using System;
using System.Collections.Generic;

namespace leetCodeTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = RomanToInt("MCMXCIV");

            Console.WriteLine(num);
        }

        public static int RomanToInt(string s)
        {
            if (s.Length < 1 || s.Length > 15)
                throw new ArgumentException(s);

            List<int> numbers = new List<int>();

            foreach(char numSmb in s)
            {
                switch(numSmb)
                {
                    case 'I':
                        numbers.Add(1);
                        break;
                    case 'V':
                        numbers.Add(5);
                        break;
                    case 'X':
                        numbers.Add(10);
                        break;
                    case 'L':
                        numbers.Add(50);
                        break;
                    case 'C':
                        numbers.Add(100);
                        break;
                    case 'D':
                        numbers.Add(500);
                        break;
                    case 'M':
                        numbers.Add(1000);
                        break;
                    default: throw new ArgumentException(numSmb.ToString());
                }
            }

            float div = 0;

            int result = 0;

            for(var i=0; i<numbers.Count; i++)
            {
                if(i==numbers.Count-1)
                {
                    result += numbers[i];
                    break;
                }
                div = (float)numbers[i] / (float)numbers[i + 1];

                if (numbers[i]<numbers[i+1])
                {
                    if (div == (float)0.2 || div == (float)0.1)
                    {
                        result += numbers[i + 1] - numbers[i];
                        i++;
                        continue;
                    }

                    throw new ArgumentException($"queue: 1:{numbers[i]}, 2: {numbers[i+1]}");
                }
                else
                {
                    result += numbers[i];
                }
            }

            return result;
        }
    }
}
