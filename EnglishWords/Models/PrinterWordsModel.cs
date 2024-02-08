using PrintWordsLibrary;

namespace EnglishWords.Models
{
    public class PrinterWordsModel
    {
        public PrinterWordsModel(bool isEnglishWords)
        {
            string wordsString = string.Empty;
            using (var streamReader = new StreamReader(@"C:\Users\pava-\Documents\trash2\trash2\trash2\words.txt"))
            {
                wordsString = streamReader.ReadToEnd();
            }

            string[] words = wordsString.Split(Environment.NewLine);

            var sortedWords = WordsPrinter.GetSortedWords(words);

            Words = isEnglishWords ? WordsPrinter.GetEnglishWords(sortedWords) : WordsPrinter.GetRussianWords(sortedWords);
        }

        public string[] Words { get; set; }
    }
}
