using System;

namespace Task2
{

    class Program
    {

        public static Person[] SummonWorker(int amount)
        {
            var worker = new Person[amount];
            string[] name_base = { "Павел", "Владимир", "Николай", "Федор", "Олег", "Дмитрий" };

            for (int i = 0; i < amount; i++)
            {
                worker[i] = new Person(null) { _name = name_base[i] };
            }
            return worker;
        }



        static void Main(string[] args)
        {
            var new_workers = new Person[3];//число новых персон
            new_workers = SummonWorker(new_workers.Length);//метод распределения персон в офис
            var office1 = new Office();//создание рабочего пространства офис
            DateTime[] time_work = { DateTime.Parse("16:30"), DateTime.Parse("8:00"), DateTime.Parse("00:00") };
            for (int i = 0; i < new_workers.Length; i++)//подписки на события каждой персоной
            {
                office1.Come(new_workers[i], time_work[i]);
            }
            for (int i = 0; i < new_workers.Length; i++)
            {
                office1.Leave(new_workers[i], time_work[i]);
            }
        }
        /*Task2(Офис и сотрудники): исправил следующее
         * Вынес в методы Come и Live подписку на события, соответственно
         * Исправил передачу времени прихода на работу сотрудника
         * Доделал условие задания - учел время суток, в которое приходят работники
         */
    }
}
