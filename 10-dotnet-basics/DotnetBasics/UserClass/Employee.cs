using System;
using System.Collections.Generic;
using System.Text;

namespace UserClass
{
    public class Employee : User
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

        protected string _title;
        protected DateTime _dateJob;
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
}
