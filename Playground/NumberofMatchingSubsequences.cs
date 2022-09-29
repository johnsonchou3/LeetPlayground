using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class NumberofMatchingSubsequences
    {
        public int NumMatchingSubseq(string s, string[] words)
        {
            var count = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (IsSubsequence(s, words[i]))
                {
                    count++;
                }
            }
            return count;
        }

        private bool IsSubsequence(string s2, string s1)
        {
            int i = 0; int j = 0;

            while (i < s1.Length && j < s2.Length)
            {
                if (s1[i] == s2[j])
                {
                    i++; j++;
                }
                else
                    j++;
            }

            if (i == s1.Length)
                return true;
            return false;
        }
    }
}
