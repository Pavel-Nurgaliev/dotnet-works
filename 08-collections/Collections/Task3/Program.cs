using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Task3
{
    class Program
    {

        public static List<string> Control(string str)
        {
            var list = new List<string> { };
            str = str.Replace(" ", "");
            list = Regex.Split(str, @"[-.?!)(,:]", RegexOptions.IgnoreCase).ToList();
            return list;
        }
        public static Dictionary<string, int> CountWords(List<string> str)
        {
            var dic = new Dictionary<string, int>();
            int value;
            for (int i = 0; i < str.Count; i++)
            {
                str[i] = str[i].ToLower();
                if (dic.ContainsKey(str[i]))
                {
                    continue;
                }
                value = 1;
                dic.Add(str[i], value);
                for (int j = i + 1; j < str.Count; j++)
                {
                    if (str[i].Contains(str[j], StringComparison.CurrentCultureIgnoreCase))
                    {
                        if (dic.ContainsKey(str[i]) || dic.ContainsKey(str[j]))
                        {
                            value = dic[str[i]] + 1;
                            dic.Remove(str[i]);
                            dic.Add(str[i], value);
                        }
                    }
                }
            }
            return dic;
        }
        static void Main(string[] args)
        {
            string s = "Hello, world. hello. World, world, hello, hello, HelLo";
            var str = Control(s);
            var dic = CountWords(str);
            var keys = dic.Keys;
            foreach (var i in keys)
            {
                Console.WriteLine(keys);
            }
        }
    }
}
