using System;
using System.Text.RegularExpressions;

namespace Task1
{
    class User
    {
        private string _name;
        private string _lastname;
        private string _patronymic;
        private DateTime _datebithday;
        public User(DateTime datebithday, string name, string lastName, string patronymic)
        {
            _name = name;
            _lastname = lastName;
            _patronymic = patronymic;
            _datebithday = datebithday;
            CheckCorrect(name, lastName, patronymic, datebithday);

        }

        public override string ToString()
        {
            return string.Format("Фамилия: {0}, Имя: {1}, Отчество: {2}, Возраст: {3}"
                , LastName, Name, Patronymic, Age);
        }
        public void CheckCorrect(string name, string lastname, string patronymic, DateTime datebithday)
        {
            if (!Regex.IsMatch(name, @"[А-Я]{1}[а-я]*$") &&
            !Regex.IsMatch(lastname, @"[А-Я]{1}[а-я]*$") &&
            !Regex.IsMatch(patronymic, @"[А-Я]{1}[а-я]*$") && (datebithday >= DateTime.Today))
            {
                throw new ArgumentException("Неправильный ввод данных");
            }
            else if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(lastname)
                && string.IsNullOrEmpty(patronymic))
            {

                throw new ArgumentNullException();
            }

        }

        public string Name
        {
            get
            {
                return _name; // read-only property
            }
        }
        public string LastName
        {
            get
            {
                return _lastname;
            }
        }
        public string Patronymic
        {
            get
            {
                return _patronymic;
            }
        }
        public string Age
        {
            get
            {
                DateTime dateNow = DateTime.Today;
                var _age = dateNow.Year - _datebithday.Year - 1 +
                        ((dateNow.Month >= _datebithday.Month && dateNow.Day >= _datebithday.Day)
                        ? 1 : 0);
                return _age.ToString();
            }


        }

    }
    class Employee : User
    {

        public Employee(DateTime dateBithday, string name, string lastname, string patronymic,
            DateTime dateJob, string title)
            : base(dateBithday, name, lastname, patronymic)
        {
            CheckCorrect(title, dateJob);
            _title = title;
            _dateJob = dateJob;

        }
        public void CheckCorrect(string title, DateTime dateJob)
        {

            if ((title == null) && (dateJob >= DateTime.Today))
            {
                throw new ArgumentNullException("Title can't be null or date write not corectly");
            }
        }
        public override string ToString()
        {
            return string.Format("Фамилия: {0}, Имя: {1}, Отчество: {2}, Возраст: {3}, Должность:" +
                "{4}, Стаж работы: {5} "
                , LastName, Name, Patronymic, Age, Title, Experience);
        }

        private string _title;
        private DateTime _dateJob;
        public string Experience
        {
            get
            {
                DateTime dateNow = DateTime.Today;
                var exp = dateNow.Year - _dateJob.Year - 1 +
                    ((dateNow.Month >= _dateJob.Month && dateNow.Day > _dateJob.Day) ? 1 : 0);
                return exp.ToString();

            }
        }
        public string Title
        {
            get
            {

                return _title;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Авторизация!");
            Console.WriteLine("Введите Фамилию: ");
            String lastname = Console.ReadLine();

            Console.WriteLine("Имя: ");
            String name = Console.ReadLine();

            Console.WriteLine("Отчество: ");
            String patronymic = Console.ReadLine();

            Console.WriteLine("Дату раждения: ");
            DateTime datebithday = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Дата выхода на работу: ");
            DateTime datejob = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Должость: ");
            string title = Console.ReadLine();

            Employee emp = new Employee(datebithday, name, lastname, patronymic, datejob,
                title);
            Console.WriteLine(emp.ToString());
        }
    }
}
