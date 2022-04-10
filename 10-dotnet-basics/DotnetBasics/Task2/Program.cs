using System;
using UserClass;

namespace Task2
{
    class Program
    {

        static void Main(string[] args)
        {
            Employee user1 = new Employee(DateTime.Parse("05.05.1998"),
                "Павел", "Нургалиев", "Владимирович", DateTime.Parse("01.01.2019"), "Инженер");
            EmployeeModify user1_1 = new EmployeeModify(user1);
            var result = user1_1.Equals(user1);
        }
    }
}
//исправил в классе EmployModify reference Equals