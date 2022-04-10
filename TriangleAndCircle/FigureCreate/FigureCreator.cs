using System;

namespace FigureCreate
{
    public class FigureCreator
    {
        private const string NotFoundNeededFigure = "Figure with {0} count parameters is not found";

        public FigureCreator(params double[] parameters)
        {
            InitFigure(parameters);
        }

        public IFigureOperations FigureOperations { get; private set; }

        private void InitFigure(double[] parameters)
        {
            switch (parameters.Length)
            {
                case 1:
                    FigureOperations = new CircleCreator(parameters[0]);
                    break;
                case 3:
                    FigureOperations = new TriangleCreator(parameters[0], parameters[1], parameters[2]);
                    break;
                default:
                    throw new ArgumentException(nameof(parameters.Length), string.Format(NotFoundNeededFigure, parameters.Length));
            }
        }

        public override string ToString()
        {
            return FigureOperations.ToString();
        }
    }
}
