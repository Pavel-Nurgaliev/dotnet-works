using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace RandomDigits.Test
{
    public class RandomDigitsData
    {
        public static IEnumerable<TestCaseData> RandomDigits
        {
            get
            {
                var list = new List<int>();
                var parts = new Random();
                var amount = new Random();

                for (int i = 0; i < amount.Next(20, 100); i++)
                    list.Add(parts.Next(-100, 100));

                var sortedList = new List<int>();
                sortedList.AddRange(list.ToArray());
                sortedList.Sort();

                yield return new TestCaseData(list).Returns(sortedList.ToArray());
            }
        }
    }
}
