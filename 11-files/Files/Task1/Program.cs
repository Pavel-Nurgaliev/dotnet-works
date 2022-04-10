using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string myfile = @"C:\Git\project.git2\dotnet-courses-2021-2\11-files\Files\disposable_task_file.txt";
            ProcesFile(myfile);
        }
        public static void ProcesFile(string myfile)
        {
            string str_result = "";

            string str = File.ReadAllText(myfile);
            Regex rx = new Regex(@"[1-9]");

            for (int i = 0; i < str.Length; i++)
            {

                if (rx.IsMatch(str[i].ToString()))
                {
                    int x = int.Parse(str[i].ToString()) * int.Parse(str[i].ToString());
                    str_result += x.ToString();
                    continue;
                }
                str_result += str[i];
            }
            File.WriteAllText(myfile, str_result);
        }
    }
}
