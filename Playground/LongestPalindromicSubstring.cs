using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class LongestPalindromicSubstring
    {
        public string DynamicProgramming(string s)
        {
            var max = string.Empty;
            for (int i = 0; i < 2 * s.Length - 1; i++)
            {
                if (i % 2 == 0)
                {
                    var length = -1;
                    var left = 0;
                    var right = i / 2;
                    for (left = i / 2; left >= 0 && right < s.Length; left--)
                    {
                        if (s[left] == s[right])
                        {
                            length += 2;
                            right++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (length > max.Length)
                    {
                        max = s.Substring(left + 1, length);
                    }

                }
                else // middle of strings
                {
                    var length = 0;
                    var left = 0;
                    var right = i / 2 + 1;
                    for (left = i / 2; left >= 0 && right < s.Length; left--)
                    {
                        if (s[left] == s[right])
                        {
                            length += 2;
                            right++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (length > max.Length)
                    {
                        max = s.Substring(left + 1, length);
                    }
                }
            }
            return max;
        }

        /// <summary>
        /// O(n^3)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string BruteForce(string s)
        {
            var max = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j < s.Length; j++)
                {
                    var sub = s.Substring(i, j - i + 1);
                    if (CheckPalindromeByReverse(sub))
                    {
                        if (sub.Length > max.Length)
                        {
                            max = sub;
                        }
                    }
                }
            }
            return max;
        }

        /// <summary>
        /// O(n)
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public bool CheckPalindromicByIteration(string s1)
        {
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s1[s1.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// O(n)
        /// </summary>
        /// <param name="s1"></param>
        /// <returns></returns>
        public bool CheckPalindromeByReverse(string s1)
        {
            var s2 = new string(s1.Reverse().ToArray());
            return s1 == s2;
        }
    }
}
