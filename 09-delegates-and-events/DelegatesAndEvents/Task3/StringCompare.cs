using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class StringCompare
    {
        public int CompareString(string str1, string str2)
        {
            return (str1.Length < str2.Length) ? -1 : (str1.Length > str2.Length) ? 1 : 0;
        }



    }
}
