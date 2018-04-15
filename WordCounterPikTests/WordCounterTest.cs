using System.Collections.Generic;
using WordCounterPik;
using Xunit;

namespace WordCounterPikTests
{
    public class WordCounterTest
    {
        [Fact]
        public void CountedWordsTest()
        {
            IWordCounter wordCounter = new WordCounter("А в ГК ПИК есть комната пик");

            Dictionary<string, int> result = new Dictionary<string, int> { { "а", 1 }, { "в", 1 },
                { "гк", 1 }, {"пик" , 2}, {"есть" , 1}, {"комната" , 1} };
            Assert.Equal(wordCounter.CountedWords, result);
        }
    }
}
