using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class FindandReplacePattern
    {
        public IList<string> FindAndReplacePattern(string[] words, string pattern)
        {
            var dict = new Dictionary<char, int>();
            var mappedPattern = new int[pattern.Length];
            var patternCounter = 0;
            var result = new List<string>();
            for (int i = 0; i < pattern.Length; i++)
            {
                if (dict.TryGetValue(pattern[i], out var mappedNum))
                {
                    mappedPattern[i] = mappedNum;
                }
                else
                {
                    dict.Add(pattern[i], patternCounter);
                    mappedPattern[i] = patternCounter;
                    patternCounter++;
                }
            }

            foreach (var word in words)
            {
                if (word.Length != pattern.Length)
                {
                    continue;
                }
                var isPattern = true;
                dict = new Dictionary<char, int>();
                var tempPattern = new int[pattern.Length];
                patternCounter = 0;
                for (int i = 0; i < word.Length; i++)
                {
                    if (dict.TryGetValue(word[i], out var mappedNum))
                    {
                        tempPattern[i] = mappedNum;
                    }
                    else
                    {
                        dict.Add(word[i], patternCounter);
                        tempPattern[i] = patternCounter;
                        patternCounter++;
                    }
                    if (tempPattern[i] != mappedPattern[i])
                    {
                        isPattern = false;
                        break;
                    }
                }
                if (isPattern)
                {
                    result.Add(word);
                }
            }
            return result;
        }
    }
}
