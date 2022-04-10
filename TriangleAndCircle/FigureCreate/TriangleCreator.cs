using System;

namespace FigureCreate
{
    internal class TriangleCreator : IFigureOperations
    {
        private const string FigureMessage = "This figure is triangle with sides {0}, {1}, {2}.";

        private const string InvalidTriangleErrorMessage = "Triangle with sides {0}, {1}, {2} not exists.";
        public TriangleCreator(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        private double Perimeter => A + B + C;
        private double HalfPerimeter => (double)Perimeter / 2;

        private static bool CheckExisting(double a, double b, double c) => a + b > c && c + b > a && c + a > b;
        private static bool CheckValueSizeIsMoreThanZero(double a, double b, double c) => a > 0 && b > 0 && c > 0;

        public static bool CheckStraightTriangle(double a, double b, double c)
        {
            var twoPowSideA = Math.Pow(a, 2);
            var twoPowSideB = Math.Pow(b, 2);
            var twoPowSideC = Math.Pow(c, 2);

            if (twoPowSideA + twoPowSideB == twoPowSideC ||
                twoPowSideB + twoPowSideC == twoPowSideA ||
                twoPowSideA + twoPowSideC == twoPowSideB)
            {
                return true;
            }

            return false;
        }

        public double CalculateSquare()
        {
            if (CheckExisting(A, B, C) && CheckValueSizeIsMoreThanZero(A, B, C))
            {
                return Math.Sqrt(HalfPerimeter * (HalfPerimeter - A) * (HalfPerimeter - B) * (HalfPerimeter - C));
            }
            else
            {
                throw new InvalidOperationException(String.Format(InvalidTriangleErrorMessage, A, B, C));
            }
        }

        public override string ToString()
        {
            return string.Format(FigureMessage, A, B, C);
        }
    }
}
