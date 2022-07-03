using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class LongestCommonSubsequence
    {
        public int MinDistance(string text1, string text2)
        {
            var memo = new int[text1.Length + 1][];
            for (int i = 0; i < text1.Length + 1; i++)
            {
                memo[i] = new int[text2.Length + 1];
            }
            return text1.Length + text2.Length - 2 * LCS(text1, text2, text1.Length, text2.Length, memo);
        }
        
        public int LCS(string s1, string s2, int m, int n, int[][] memo)
        {
            if (m == 0 || n == 0)
            {
                return 0;
            }
            if (memo[m][n] > 0)
            {
                return memo[m][n];
            }
            if (s1[m - 1] == s2[n - 1])
            {
                memo[m][n] = 1 + LCS(s1, s2, m - 1, n - 1, memo);
            }
            else
            {
                memo[m][n] = Math.Max(LCS(s1, s2, m - 1, n, memo), LCS(s1, s2, m, n - 1, memo));
            }
            return memo[m][n];
        }
    }
}
