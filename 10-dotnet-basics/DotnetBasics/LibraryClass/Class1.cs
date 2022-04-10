using System;

namespace MathLibrary
{
    public static class MathFunction
    {
        public static long Factorial(int number)
        {
            long result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
        public static double Power(double x, double y)
        {
            double result = 1;
            if (y == 0)
            {
                return result;
            }
            for (int i = 1; i <= y; i++)
            {
                result *= x;
            }
            return result;
        }

    }
}
