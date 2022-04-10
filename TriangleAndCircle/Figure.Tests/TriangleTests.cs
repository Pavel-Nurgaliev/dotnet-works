using FigureCreate;
using NUnit.Framework;
using System;

namespace Figure.Test
{
    public class TriangleTests
    {
        private const string ExpectedString735 = "This figure is triangle with sides 7, 3, 5.";

        [TestCase(7, 3, 5, ExpectedResult = ExpectedString735, TestName = "CreateTriangle_CheckToString_Success")]
        public string CreateTriangle_CheckToString_Success(int a, int b, int c) =>
            new FigureCreator(a, b, c).ToString();

        [TestCase(0, 1, 2)]
        [TestCase(1, 0, 2)]
        [TestCase(1, 2, 0)]
        public void CreateTriangle_CalculateSquare_Exeption(int a, int b, int c)
        {
            Assert.Throws<InvalidOperationException>(() =>
            new FigureCreator(a, b, c).FigureOperations.CalculateSquare());
        }

        [TestCase(7, 3, 5, ExpectedResult = 6.49519052838329)]
        public double Calculate_Square_Success(int a, int b, int c) =>
            new FigureCreator(a, b, c).FigureOperations.CalculateSquare();
    }

}