using System.Collections.Generic;

namespace WordCounterPik
{
    public interface IWordCounter
    {
        Dictionary<string, int> CountedWords { get; }
    }
}
