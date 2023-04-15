using NUnit.Framework;
using RandomDigitsGenerate;
using System.Collections.Generic;

namespace RandomDigits.Test
{
    public class RandomDigitsTests
    {
        [TestCaseSource(typeof(RandomDigitsData), nameof(RandomDigitsData.RandomDigits))]
        public int[] TestBubbleSortOfList_SortedList_Success(List<int> list)
        {
            var resList = new List<int>();
            resList.AddRange(list);

            ListSorter.BubbleSort(resList);

            return resList.ToArray();
        }

        [TestCaseSource(typeof(RandomDigitsData), nameof(RandomDigitsData.RandomDigits))]
        public int[] TestShakeSortOfList_SortedList_Success(List<int> list)
        {
            var resList = new List<int>();
            resList.AddRange(list);
            ListSorter.ShakerSort(resList);

            return resList.ToArray();
        }

        [TestCaseSource(typeof(RandomDigitsData), nameof(RandomDigitsData.RandomDigits))]
        public int[] TestSortList_SortedList_Success(List<int> list)
        {
            var resList = new List<int>();
            resList.AddRange(list);
            ListSorter.SortList(resList);

            return resList.ToArray();
        }
    }
}