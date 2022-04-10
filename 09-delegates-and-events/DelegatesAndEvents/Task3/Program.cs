using System;
using System.Linq;
using System.Threading;

namespace Task3
{
    delegate int MyDelegate(string str1, string str2);
    delegate void MyDelegate3(string[] arr_str, MyDelegate del);

    class Program
    {

        public static void Sort(string[] arr_str, MyDelegate del)
        {

            int x;
            string change_str;
            for (int j = 0; j < arr_str.Length; j++)
            {
                for (int i = j; i < arr_str.Length; i++)
                {
                    if ((i - 1) < 0) continue;

                    x = del(arr_str[i], arr_str[j]);
                    if (x < 0)
                    {
                        change_str = arr_str[i];
                        arr_str[i] = arr_str[j];
                        arr_str[j] = change_str;
                    }
                    else if (x == 0)
                    {
                        arr_str[i] = string.Concat(arr_str[i].Replace(" ", "")
                            .OrderBy(char.ToLower).ThenBy(char.IsLower));
                        arr_str[j] = string.Concat(arr_str[j].Replace(" ", "")
                            .OrderBy(char.ToLower).ThenBy(char.IsLower));
                    }

                }
            }
        }
        static void Main(string[] args)
        {
            Thread main_thread = Thread.CurrentThread;
            main_thread.Name = "Main_Thread";
            string[] arr_main = { "AbcDe", "CeabD", "My", "Name", "Is", "Pavel" };
            var comp_str = new StringCompare();
            SortAsync(arr_main, new MyDelegate(comp_str.CompareString));
            Sort(arr_main, new MyDelegate(comp_str.CompareString));
            Console.WriteLine($"{main_thread} is complete");
        }
        public static Thread SortAsync(string[] arr_str, MyDelegate del)
        {
            var sort_method = new MyDelegate3(Sort);
            Sleep sl = new Sleep(arr_str, del, sort_method);
            sl.SortCompleted += Display;
            Thread thr = new Thread(sl.Cancel);
            thr.Start();
            return thr;
        }
        public static void Display()
        {
            Console.WriteLine("Сортировка завершена");
        }
    }
    class Sleep
    {
        public event Action SortCompleted;
        private bool _cancelled;
        private string[] _arr_str;
        MyDelegate _del;
        MyDelegate3 _sort;
        public Sleep(string[] arr_str, MyDelegate del, MyDelegate3 sort)
        {
            _arr_str = arr_str;
            _del = del;
            _sort = sort;
        }
        public void Cancel()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Thread 2 = {i}");
            }
            _sort(_arr_str, _del);
            _cancelled = true;
            SortCompleted?.Invoke();
        }
    }
}
//Исправлен StrCmp, как и в первой задаче - вывод результата сравнения в одну строчку