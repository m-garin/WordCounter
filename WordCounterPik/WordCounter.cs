using System;
using System.Collections.Generic;

namespace WordCounterPik
{
    public class WordCounter : IWordCounter
    {
        public Dictionary<string, int> CountedWords { get; private set; }

        public WordCounter(string text)
        {
            CountedWords = CountWords(SplitString(text));
        }

        /// <summary>
        /// Подсчитать вхождения слов
        /// </summary>
        Dictionary<string, int> CountWords(IEnumerable<string> words)
        {
            Dictionary<string, int> countedWords = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (countedWords.ContainsKey(word))
                {
                    countedWords[word]++;
                }
                else
                {
                    countedWords.Add(word, 1);
                }
            }
            return countedWords;
        }

        /// <summary>
        /// Разделить и привести к одному регистру
        /// </summary>
        string[] SplitString(string text)
        {
            return text.ToLower().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
