using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    delegate void PersonStateHandler(object sender, OfficeEventArgs e);

    class OfficeEventArgs : EventArgs
    {
        public string _name { get; }
        public DateTime _time { get; }

        public OfficeEventArgs(string name, DateTime time)
        {

            _name = name;

            _time = time;
        }
    }
    class Office
    {
        public event PersonStateHandler PersonCame;//задание события прихода на работу
        public event PersonStateHandler PersonLeft;//задание события на уход с работы

        public void Come(Person person, DateTime time)//исправить по времени
        {
            Console.WriteLine($"[На работу пришел {person._name}]");
            var user = new OfficeEventArgs(person._name, time);//что будет выполняться при определенном событии
            PersonCame?.Invoke(this, user);

            PersonCame += person.Greetings;
            PersonLeft += person.Parting;



        }

        public void Leave(Person person, DateTime time)
        {
            Console.WriteLine($"[{person._name} ушел домой]");
            var user = new OfficeEventArgs(person._name, time);
            PersonLeft?.Invoke(this, user);

            PersonCame -= person.Greetings;
            PersonLeft -= person.Parting;
        }

    }
}
