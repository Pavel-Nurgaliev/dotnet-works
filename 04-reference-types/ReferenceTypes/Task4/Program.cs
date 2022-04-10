using System;
/*Написать свой собственный класс MyString, описывающий строку как массив символов.

Класс должен содержать:

Конструктор без параметров – «пустая строка».

Конструктор, принимающий один параметр типа string – создание «строки» из «строки».

Конструктор, принимающий один параметр типа char[] – создание «строки» из массива символов.

Перегруженные операторы:

‘+’ – добавляет строку в конец текущей;
‘-’ – удаляет подстроку из текущей строки (только первое вхождение);
‘==’ – сравнивает два объекта MyString.
Метод ToString для получения представления объекта MyString в виде объекта стандартного string.
Требования
Обеспечить нахождение объектов класса MyString в заведомо корректном состоянии.
Продемонстрировать использование класса MyString в консольном приложении.
Продемонстрировать использование объекта класса MyString в проверке на null.*/
namespace Task4
{
    public class MyString
    {
        private char[] _str;

        public MyString()
        {
            _str = new char[0];
        }

        public MyString(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                _str = str.ToCharArray();
            }
        }
        public MyString(char[] ch)
        {
            _str = new char[ch.Length];
            Array.Copy(ch, _str, ch.Length);
        }
        public static MyString operator +(MyString str1, MyString str2)
        {
            MyString res = new MyString(str1.ToString() + str2.ToString());
            return res;
        }
        public static MyString operator -(MyString str1, MyString str2)
        {
            MyString res = new MyString(str1.ToString().Replace(str2.ToString(), string.Empty));
            return res;
        }
        public override string ToString()
        {

            string value = new string(_str);
            return value;
        }
        public static bool operator ==(MyString str1, MyString str2)
        {
            if (str2 is null && str1 is null)
            {
                return true;
            }
            else if (str2 is null || str1 is null)
            {
                return false;
            }
            else
            {
                if (str1._str.Length != str2._str.Length)
                {
                    return false;
                }
                for (int i = 0; i < str1._str.Length; i++)
                {
                    if (!str1._str[i].Equals(str2._str[i]))
                    {
                        return false;
                    }

                }
            }


            return true;



        }
        public static bool operator !=(MyString str1, MyString str2)
        {
            return !(str1 == str2);
        }
    }
    class Program
    {
        public static void Configure(string str1, string str2)
        {
            char[] ch = { 'h', 'i' };
            MyString ch1 = new MyString(ch);
            Console.WriteLine(ch1.ToString());
            //string strNULL = null;
            //MyString strNull = new MyString(strNULL);
            MyString str11 = new MyString(str1);
            MyString str22 = new MyString(str2);
            MyString c = new MyString();
            MyString str33 = str11 + str22;
            Console.WriteLine(str11 == str22);
            Console.WriteLine(str11 + c);
            Console.WriteLine(str33.ToString());
            str33 = str33 - str11;
            Console.WriteLine(str33.ToString());
        }
        public static void Check(string str)
        {
        }
        static void Main(string[] args)
        {

            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            Check(str1);
            Check(str2);
            Configure(str1, str2);
        }
    }
}

