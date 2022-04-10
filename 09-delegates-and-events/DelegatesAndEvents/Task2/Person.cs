using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Person
    {
        public Person(string AnotherName)
        {

        }
        public void Greetings(object sender, OfficeEventArgs e)//исправить сендер в выводе
        {
            if (e._time.Hour <= 12 && e._time.Hour >= 8)
                Console.WriteLine($"'Доброе утро, {e._name}!' - сказал {_name}");
            else if (e._time.Hour > 12 && e._time.Hour <= 17)
                Console.WriteLine($"'Добрый день, {e._name}!' - сказал {_name}");
            else
                Console.WriteLine($"'Добрый вечер, {e._name}!' - сказал {_name}");
        }
        public void Parting(object sender, OfficeEventArgs e)
        {
            Console.WriteLine($"'До свидания, {e._name}!' - сказал {_name}");
        }
        public string _name { get; set; }
        public DateTime _time { get; private set; }
    }
}
