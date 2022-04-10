using System;
using System.Text.RegularExpressions;

namespace UserClass
{

    public class User
    {
        protected string _name;
        protected string _lastname;
        protected string _patronymic;
        protected DateTime _datebithday;

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




}
