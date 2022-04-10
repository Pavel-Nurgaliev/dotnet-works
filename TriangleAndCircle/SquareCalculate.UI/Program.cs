using ConsoleInput;
using System;
using System.Collections.Generic;
using FigureCreate;

namespace SquareCalculate.UI
{
    internal class Program
    {
        private const string InputCountMessage = "Input count of parameters";
        private const string InputDataMessage = "Enter the data";
        private const string ErrorInputMessage = "Data entry error";

        static void Main(string[] args)
        {
            try
            {
                var parameters = InputParameters();

                var figure = new FigureCreator(parameters);

                PrintResults(figure);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void PrintResults(FigureCreator figure)
        {
            Console.WriteLine(figure);

            Console.WriteLine(figure.FigureOperations.CalculateSquare());
        }

        private static double[] InputParameters()
        {
            var parameters = new List<double>();

            var countParameters = InvitationInputHelper.InputInteger(InputCountMessage, ErrorInputMessage, 0);

            for (var i = 0; i < countParameters; i++)
            {
                var parameter = InvitationInputHelper.InputDouble(InputDataMessage, ErrorInputMessage, 0);

                parameters.Add(parameter);
            }

            return parameters.ToArray();
        }
    }
}
