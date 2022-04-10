using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Task1
{
    class StringCompare
    {
        MyDelegate _del;
        public static string _str1;
        public static string _str2;
        public void DelegateRegister(MyDelegate del)
        {
            _del = del;
        }
        private int i = 0;
        public static void OutPut(out string str1, out string str2)
        {
            str1 = _str1;
            str2 = _str2;
        }
        public int CompareString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return -1;
            }
            if (str1.Length > str2.Length)
            {
                return 1;
            }

            return string.Compare(str1, str2);

        }
    }
}
/*arr_str[i] = string.Concat(arr_str[i].Replace(" ", "")
                            .OrderBy(char.ToLower).ThenBy(char.IsLower));
arr_str[j] = string.Concat(arr_str[j].Replace(" ", "")
    .OrderBy(char.ToLower).ThenBy(char.IsLower));*/