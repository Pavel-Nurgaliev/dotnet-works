using System;
using System.Collections.Generic;
using System.Text;

namespace UserClass
{
    public class EmployeeModify : IEquatable<Employee>
    {
        protected string _title;
        protected string _name;
        protected string _lastname;
        protected string _patronymic;
        protected string _age;
        public EmployeeModify(Employee user)
        {
            _title = user.Title;
            _name = user.Name;
            _lastname = user.LastName;
            _patronymic = user.Patronymic;
            _age = user.Age;
        }
        public string Title
        {
            get => _title;
        }
        public string Name
        {
            get => _name;
        }
        public string Lastname
        {
            get => _lastname;
        }
        public string Patronymic
        {
            get => _patronymic;
        }
        public string Age
        {
            get => _age;
        }
        public bool Equals(Employee employee)
        {
            if (ReferenceEquals(null, employee))
            {
                return false;
            }

            if (ReferenceEquals(this, employee))
            {
                return true;
            }

            return (Title == employee.Title && Name == employee.Name && Lastname == employee.LastName &&
                Patronymic == employee.Patronymic && Age == employee.Age);
        }
    }
}
