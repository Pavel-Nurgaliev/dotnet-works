using System;
using System.Collections.Generic;

namespace RandomDigitsGenerate
{
    internal enum Algorithms : int
    {
        BubbleSort = 0,
        ShakerSort = 1
    }
    public static class ListSorter
    {
        public static void SortList(List<int> list)
        {
            var random = new Random();

            var algorithmChoice = random.Next((int)Algorithms.BubbleSort, (int)Algorithms.ShakerSort);

            switch (algorithmChoice)
            {
                case (int)Algorithms.BubbleSort:
                    BubbleSort(list);
                    break;
                case (int)Algorithms.ShakerSort:
                    ShakerSort(list);
                    break;
            }
        }

        public static void BubbleSort(List<int> list)
        {
            int template = 0;
            for (var i = 0; i < list.Count; i++)
            {
                for (var j = 0; j < list.Count - i - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        template = list[j];

                        list[j] = list[j + 1];
                        list[j + 1] = template;
                    }
                }
            }
        }

        public static void ShakerSort(List<int> list)
        {
            int template = 0;
            for (var i = 0; i < list.Count / 2; i++)
            {
                var swapFlag = false;
                for (var j = i; j < list.Count - i - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        template = list[j];

                        list[j] = list[j + 1];
                        list[j + 1] = template;
                        swapFlag = true;
                    }
                }

                for (var j = list.Count - 2 - i; j > i; j--)
                {
                    if (list[j - 1] > list[j])
                    {

                        template = list[j - 1];

                        list[j - 1] = list[j];
                        list[j] = template;

                        swapFlag = true;
                    }
                }

                if (!swapFlag)
                {
                    break;
                }
            }
        }
    }
}
