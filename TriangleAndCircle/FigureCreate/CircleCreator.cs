using System;

namespace FigureCreate
{
    internal class CircleCreator : IFigureOperations
    {
        private const int RadiusDegreeForCalculateSquare = 2;

        private const string FigureMessage = "This figure is circle with radius {0}";

        public CircleCreator(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; private set; }

        public double CalculateSquare()
        {
            return Math.PI * Math.Pow(Radius, RadiusDegreeForCalculateSquare);
        }

        public override string ToString()
        {
            return String.Format(FigureMessage, Radius);
        }
    }
}
