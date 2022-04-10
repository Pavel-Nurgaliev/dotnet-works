using NUnit.Framework;
using System;
using FigureCreate;

namespace Figure.Test
{
    public class CircleTests
    {
        private const string ExpectedString7 = "This figure is circle with radius 7";

        [TestCase(7, ExpectedResult = ExpectedString7, TestName = "CreateCircle_CheckToString_Success")]
        public string CreateCircle_CheckToString_Success(double radius) =>
            new FigureCreator(radius).ToString();

        [TestCase(3, ExpectedResult = 28.274333882308138)]
        public double CalculateCircle_CalculateSquare_Success(int radius) =>
            new FigureCreator(radius).FigureOperations.CalculateSquare();
    }

}
