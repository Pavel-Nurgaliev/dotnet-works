using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;

namespace RandomDigitsGenerate
{
    public class Program
    {
        #region ConstantsPart
        private const int AmountMinValue = 20;
        private const int AmountMaxValue = 100;

        private const int ElementMinValue = -100;
        private const int ElementMaxValue = 100;

        private const string SortedListMessage = "Сортированный список: ";
        private const string UnsortedListMessage = "Несортированный список: ";
        #endregion

        public static void Main(string[] args)
        {
            var randomDigitsList = new List<int>();

            FillListByRandomElements(randomDigitsList);

            PrintList(randomDigitsList, false);

            ListSorter.SortList(randomDigitsList);

            PrintList(randomDigitsList, true);

            TransmitData(randomDigitsList);
        }

        private static void FillListByRandomElements(List<int> list)
        {
            var random = new Random();

            for (int i = 0; i < random.Next(AmountMinValue, AmountMaxValue); i++)
                list.Add(random.Next(ElementMinValue, ElementMaxValue));
        }

        private static void PrintList(List<int> list, bool isSortedList)
        {
            StringBuilder resultStringBuilder = new StringBuilder();

            resultStringBuilder.Append(isSortedList ? SortedListMessage : UnsortedListMessage);

            list.ForEach(digit => resultStringBuilder.Append(string.Format("{0} |", digit)));

            Console.WriteLine(resultStringBuilder);
        }

        private static void TransmitData(List<int> list)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

                    var response = client.PostAsJsonAsync(client.BaseAddress + "RandomDigits", list).Result;
                }
            }
            catch (AggregateException ex) when (ex.InnerException is HttpRequestException || ex.InnerException is SocketException)
            {
                Console.WriteLine($"Нет соединения с сервером {ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString}");
            }

        }
    }
}
