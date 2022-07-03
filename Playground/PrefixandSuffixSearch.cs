using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class WordFilter
    {
        private Dictionary<(string prefix, string suffix), int> map = new();

        public WordFilter(string[] words)
        {
            for (var i = 0; i < words.Length; i++)
                for (var j = 1; j <= words[i].Length; j++)
                    for (var k = words[i].Length - 1; k >= 0; k--)
                        if (!map.TryAdd((words[i].Substring(0, j), words[i].Substring(k)), i))
                            map[(words[i].Substring(0, j), words[i].Substring(k))] = i;
        }

        public int F(string prefix, string suffix)
            => map.TryGetValue((prefix, suffix), out int value) ? value : -1;
    }
}
