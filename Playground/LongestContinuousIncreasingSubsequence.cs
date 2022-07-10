using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class LongestContinuousIncreasingSubsequence
    {
        public int FindLengthOfLCIS(int[] nums)
        {
            if (nums.Length == 1)
            {
                return 1;
            }
            var longestCount = 1;
            var curCount = 1;
            var lastVal = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > lastVal)
                {
                    curCount++;
                    lastVal = nums[i];
                }
                else
                {
                    longestCount = Math.Max(longestCount, curCount);
                    curCount = 1;
                    lastVal = nums[i];
                }
                    longestCount = Math.Max(longestCount, curCount);
            }
                return longestCount;
        }
    }
}
