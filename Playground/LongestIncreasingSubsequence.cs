using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class LongestIncreasingSubsequence
    {
        public int LengthOfLIS(int[] nums)
        {
            var dp = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                dp[i] = 1;
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                    }
                }
            }
            return dp.Max();
        }
        
        // Use Binary Search, nlogn
        public int LengthOfLISOptimized(int[] nums)
        {
            var curSequence = new int[nums.Length + 1];
            var curInsertIndex = 1;
            var curMax = 0;
            
            curSequence[0] = Int32.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > curSequence[curMax])
                {
                    curSequence[curInsertIndex] = nums[i];
                    curMax = curInsertIndex;
                    curInsertIndex += 1;
                }
                else
                {
                    // find index to replace
                    var index = Array.BinarySearch(curSequence, 1, curMax, nums[i]);
                    if (index < 0)// number is not found and we replace the next greater value
                    {
                        curSequence[index * -1 - 1] = nums[i];
                    }
                }
            }

            return curMax;
        }
    }
}
