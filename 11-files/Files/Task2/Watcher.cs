using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Task2
{
    class Watcher
    {

        protected string logs =
            @"C:\Git\project.git2\dotnet-courses-2021-2\11-files\Files\Task2\logs\logs.txt";
        protected string logs_rewrite = @"C:\Git\project.git2\dotnet-courses-2021-2\11-files\Files\Task2\logs\logs_rewrite.txt";
        protected string dir_path = @"C:\Git\project.git2\dotnet-courses-2021-2\11-files\Files\Task2\test";
        protected DateTime date;

        public Watcher()
        {
            LogCreate();//создаем файлы логов
            FileSystemWatcher watcher = new FileSystemWatcher(dir_path);//включаем вотчер
            watcher.Filter = "*.txt";//фильтр по расшир файлов
            watcher.IncludeSubdirectories = true; // чек каталогов
            watcher.Created += new FileSystemEventHandler(Watcher_Created);//подписки на события
            watcher.Deleted += new FileSystemEventHandler(Watcher_Delete);
            watcher.Renamed += new RenamedEventHandler(Watcher_Renamed);
            watcher.EnableRaisingEvents = true;
            while (Console.ReadLine() != "-b") ;
            watcher.Created -= Watcher_Created;
            watcher.Deleted -= Watcher_Delete;
            watcher.Renamed -= Watcher_Renamed;
            RewriteLogs();
        }
        protected void RewriteLogs()
        {
            using (StreamWriter stw = new StreamWriter(logs_rewrite, true))
            {
                using (StreamReader str = new StreamReader(logs))
                {
                    string data = "";
                    while (data != null)
                    {
                        data = str.ReadLine();
                        stw.WriteLine(data);
                    }
                }
            }
        }
        protected void LogCreate()//создаем файл для хранения логов
        {
            if (!File.Exists(logs))
            {
                using (FileStream fs = File.Create(logs))
                {

                    Console.WriteLine("Create logs");
                }
            }
            if (!File.Exists(logs_rewrite))
            {
                using (FileStream fs = File.Create(logs_rewrite))
                {

                    Console.WriteLine("Create logs_rewrite");
                }
            }

            File.WriteAllText(logs, "");
            File.WriteAllText(logs_rewrite, "");
            Console.WriteLine("All files of logs was cleared");

        }
        private void LogsWrite(string text)
        {
            using (StreamWriter swx = new StreamWriter(logs, true))
            {
                swx.WriteLine(text);
            }

        }

        private void Watcher_Renamed(object sender, RenamedEventArgs e)//переименование файла
        {
            date = DateTime.Now;
            string text = $"Date: {date}. File {e.OldName} was renamed to {e.Name}." +
                $"{Environment.NewLine} Full path is \"{e.FullPath}\"";
            Console.WriteLine(text);

            LogsWrite(date.ToString());
            LogsWrite(e.ChangeType.ToString());
            LogsWrite(e.OldFullPath);
            LogsWrite(e.FullPath);
        }
        private void Watcher_Delete(object sender, FileSystemEventArgs e)//удаление файла из каталога
        {
            date = DateTime.Now;
            string text = $"Date: {date}. File {e.Name} was {e.ChangeType}" +
                $"{Environment.NewLine} Full path is \"{e.FullPath}\"";
            Console.WriteLine(text);

            LogsWrite(date.ToString());
            LogsWrite(e.ChangeType.ToString());
            LogsWrite(e.FullPath);
        }
        private void Watcher_Created(object sender, FileSystemEventArgs e)//создание нового файла в каталоге
        {
            date = DateTime.Now;
            string text = $"Date {date}. File {e.Name} was {e.ChangeType}" +
                $"{Environment.NewLine} Full path is \"{e.FullPath}\"";
            Console.WriteLine(text);

            LogsWrite(date.ToString());
            LogsWrite(e.ChangeType.ToString());
            LogsWrite(e.FullPath);
        }
    }
}
