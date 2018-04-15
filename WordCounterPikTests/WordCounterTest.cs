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
            IWordCounter wordCounter = new WordCounter("� � �� ��� ���� ������� ���");

            Dictionary<string, int> result = new Dictionary<string, int> { { "�", 1 }, { "�", 1 },
                { "��", 1 }, {"���" , 2}, {"����" , 1}, {"�������" , 1} };
            Assert.Equal(wordCounter.CountedWords, result);
        }
    }
}
