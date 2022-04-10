using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Task2
{
    class Change
    {
        protected string logs =
            @"C:\Git\project.git2\dotnet-courses-2021-2\11-files\Files\Task2\logs\logs_rewrite.txt";

        private DateTime _date;
        private int _iterations_date;
        private int _iterations_text;
        private string _prev_mode;
        private string _prev_path;
        public Change()
        {
            Console.WriteLine("Send date to left");
            _date = DateTime.Parse(Console.ReadLine());
            ReadingLogFile();
        }
        private void GetChange(int mode, string path)
        {

            if (mode == 1 && File.Exists(path))
            {


                using (FileStream fs = File.Create(path))
                {

                }

            }
            else if (mode == 2 && File.Exists(path))
            {
                File.Delete(path);
            }
        }
        private void GetChangeName(string old, string now)
        {
            if (File.Exists(now))
            {
                if (!string.Equals(_prev_path, old))
                {
                    using (FileStream fs = File.Create(old))
                    {
                    }

                }
                File.Delete(now);
            }
        }

        private void ReadingLogFile()
        {
            using (StreamReader sr1 = File.OpenText(logs))//чтение даты записи
            {
                string date = "";
                int i = 0;
                while (date != null)
                {
                    date = sr1.ReadLine();
                    _iterations_date = (string.Equals(date, _date.ToString())) ? i : -1;
                    i++;
                }
                _iterations_text = i;
            }
            using (StreamReader sr2 = File.OpenText(logs))
            {
                string data = "";
                int stop = 0;

                while (data != null)
                {
                    data = sr2.ReadLine();

                    if (data == "Created")
                    {

                        data = sr2.ReadLine();//нужно для проверки (при rename)
                        GetChange(2, data);

                        _prev_path = data;
                    }
                    if (data == "Renamed")
                    {
                        GetChangeName(sr2.ReadLine(), sr2.ReadLine());

                    }
                    if (data == "Deleted")
                    {
                        GetChange(1, sr2.ReadLine());
                    }
                    if (stop == _iterations_date + 4 && DateTime.TryParse(data, out DateTime date_stop)) break;
                    stop++;
                }

            }
        }
    }
}
