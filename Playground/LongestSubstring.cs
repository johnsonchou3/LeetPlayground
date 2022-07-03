using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class LongestSubstring
    {
        // qabddeee
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            if (s.Length == 1)
            {
                return 1;
            }
            var seen = new HashSet<char>();
            var left = 0;
            var right = 1;
            var max = 1;
            seen.Add(s[left]);
            while (right != s.Length)
            {
                if (seen.Contains(s[right]))
                {
                    seen.Remove(s[left]);
                    left++;
                }
                else
                {
                    max = Math.Max(max, right - left + 1);
                    seen.Add(s[right]);
                    right++;
                }
            }
            return max;
        }
    }
}
