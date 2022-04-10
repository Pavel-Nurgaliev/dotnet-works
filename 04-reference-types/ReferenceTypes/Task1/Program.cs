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


        public User(DateTime datebithday, string name, string lastname, string patronymic)
        {
            CheckCorrect(name, lastname, patronymic, datebithday);
            _name = name;
            _lastname = lastname;
            _patronymic = patronymic;
            _datebithday = datebithday;
        }

        public override string ToString()
        {
            return string.Format("Фамилия: {0}, Имя: {1}, Отчество: {2}, Возраст: {3}"
                , LastName, Name, Patronymic, Age);
        }
        private static void CheckCorrect(string name, string lastname, string patronymic, DateTime datebithday)
        {
            if (!Regex.IsMatch(name, @"[А-Я]{1}[а-я]*$") &&
            !Regex.IsMatch(lastname, @"[А-Я]{1}[а-я]*$") &&
            !Regex.IsMatch(patronymic, @"[А-Я]{1}[а-я]*$") && (datebithday >= DateTime.Today))
            {
                throw new ArgumentException("Неправильный ввод данных");
            }
            else if (string.IsNullOrEmpty(name) && (lastname == "") && (patronymic == ""))
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
    class Program
    {

        static void Main()
        {
            Console.WriteLine("Авторизация!");
            Console.WriteLine("Введите Фамилию: ");
            String lastname = Console.ReadLine();

            Console.WriteLine("Имя: ");
            String name = Console.ReadLine();

            Console.WriteLine("Отчество: ");
            String patronymic = Console.ReadLine();

            Console.WriteLine("Дату раждения: ");
            String bithday = Console.ReadLine();

            DateTime datebithday = DateTime.Parse(bithday);
            User user = new User(datebithday, name, lastname, patronymic);
            Console.WriteLine(user.ToString());
        }
    }

}
