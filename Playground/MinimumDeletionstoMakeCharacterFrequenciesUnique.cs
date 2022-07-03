using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class MinimumDeletionstoMakeCharacterFrequenciesUnique
    {
        // Time Complexity: O(N + K^2)
        // Space Complexity: O(K)
        public int MinDeletions(string s)
        {
            var dict = new Dictionary<char, int>();
            var hashSet = new HashSet<int>();
            var deleteCount = 0;
            foreach (var c in s)
            {
                if (!dict.TryAdd(c, 1))
                {
                    dict[c] += 1;
                }
            }
            foreach (var pair in dict)
            {
                var freq = pair.Value;
                while (hashSet.Contains(freq) && freq != 0)
                {
                    freq--;
                    deleteCount++;
                }
                hashSet.Add(freq);
            }
            return deleteCount;
        }

        ///
        public int MinDeletionsStoreMaxFreq(string s)
        {
            var dict = new Dictionary<char, int>();
            var deleteCount = 0;
            foreach (var c in s)
            {
                if (!dict.TryAdd(c, 1))
                {
                    dict[c] += 1;
                }
            }
            var descendingFreq = dict.Select(x => x.Value).OrderByDescending(x => x).ToArray();
            var maxFreq = descendingFreq[0] - 1;
            for (var i = 1; i < descendingFreq.Length; i++)
            {
                while (maxFreq < descendingFreq[i] && descendingFreq[i] != 0)
                {
                    descendingFreq[i]--;
                    deleteCount++;
                }
                if (maxFreq == descendingFreq[i])
                {
                    maxFreq--;
                }
                if (maxFreq > descendingFreq[i])
                {
                    maxFreq = descendingFreq[i] - 1;
                }
            }
            return deleteCount;
        }
    }
}
