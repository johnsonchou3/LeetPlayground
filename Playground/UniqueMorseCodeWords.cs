using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    internal class UniqueMorseCodeWords
    {
        private Dictionary<char, string> MorseDict = null;
        public int UniqueMorseRepresentations(string[] words)
        {
            if (MorseDict == null)
            {
                MorseDict = new Dictionary<char, string>();
                var allMorse = new string[]
                {
                    ".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."
                };
                for (int i = 0; i < allMorse.Length; i++)
                {
                    MorseDict.Add((char)(97 + i), allMorse[i]);
                }
            }
            var map = new HashSet<string>();
            foreach (var word in words)
            {
                var morses = new List<string>();
                foreach (var c in word)
                {
                    morses.Add(MorseDict[c]);
                }
                map.Add(string.Join("", morses));
            }
            return map.Count;
        }
    }
}
