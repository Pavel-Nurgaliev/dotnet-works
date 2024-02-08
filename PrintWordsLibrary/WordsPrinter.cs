
using System.Text;

namespace PrintWordsLibrary
{
    public class WordsPrinter
    {
        const string ChooseMesage = "Press E for print English words\r\nPress R for print Russian words/\r\nPress Escape for exit";
        public WordsPrinter()
        {

        }
        public static string[] GetSortedWords(string[] words)
        {
            var random = new Random();

            return words.OrderBy(x => random.Next(x.Length)).ToArray();
        }

        public static string[] GetRussianWords(string[] sortedWords)
        {
            List<string> words = new List<string>();
            foreach (var item in sortedWords)
            {
                var trimmedWord = item.Trim();
                var startIndexWord = trimmedWord.IndexOf('-') + 1;
                var lengthWord = trimmedWord.Length - startIndexWord;

                words.Add(trimmedWord.Substring(startIndexWord, lengthWord).Trim());
            }

            return words.ToArray();
        }

        public static string[] GetEnglishWords(string[] sortedWords)
        {
            List<string> words = new List<string>();
            foreach (var item in sortedWords)
            {
                var trimmedWord = item.Trim();
                if (trimmedWord == string.Empty)
                {
                    continue;
                }

                words.Add(trimmedWord.Substring(0, trimmedWord.IndexOf('-')));
            }

            return words.ToArray();
        }
    }
}