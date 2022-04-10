using System;
using System.Linq;

namespace Task1
{
    delegate int MyDelegate(string str1, string str2);

    class Program
    {
        public static void Sort(string[] arr_str, MyDelegate del) //передача метода в качестве параметра
        {
            int res;

            string change_str;
            for (int j = 0; j < arr_str.Length; j++)//сортировка
            {
                for (int i = j + 1; i < arr_str.Length; i++)
                {

                    res = del(arr_str[i], arr_str[j]);
                    StringCompare.OutPut(out arr_str[i], out arr_str[j]);
                }
            }

        }
        static void Main(string[] args)
        {
            string[] arr_main = { "AbcDe", "CeabD", "My", "Name", "Is", "Pavel" };
            var comp_str = new StringCompare();
            Sort(arr_main, new MyDelegate(comp_str.CompareString));
        }
    }
}
//вывод результата сравнения в StrCmp в одну строчку