using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class LongestConsecutiveSequence
    {
        public int LongestConsecutive(int[] nums)
        {
            var set = new HashSet<int>();
            var longest = 0;
            foreach (var n in nums)
            {
                set.Add(n);
            }

            foreach (var n in nums)
            {
                if (!set.Contains(n - 1))
                {
                    var curLength= 1;
                    var currentNum = n;
                    while (set.Contains(curLength + 1))
                    {
                        curLength++;
                        currentNum++;
                    }
                    longest = Math.Max(longest, curLength);
                }
            }
            return longest;
        }

    }
}
