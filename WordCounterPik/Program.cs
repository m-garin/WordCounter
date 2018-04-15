using System;
using System.Collections.Generic;

namespace WordCounterPik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your text:");
            IWordCounter wordCounter = new WordCounter(Console.ReadLine());
            PrintResult(wordCounter.CountedWords);
            Console.ReadKey(); //waiting
        }

        static void PrintResult(Dictionary<string, int> countedWords)
        {
            Console.WriteLine("\nResult:");
            foreach(KeyValuePair<string, int> kvp in countedWords)
            {
                Console.WriteLine(kvp.Key + ":" + kvp.Value);
            }
        }
    }
}
