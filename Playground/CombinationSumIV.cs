using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    internal class CombinationSumIV
    {
        public int CombinationSum4(int[] nums, int target)
        {
            var dp = new int[target + 1];
            foreach (var n in nums)
            {
                if (n < target)
                {
                    dp[n] += 1;
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                var cur = nums[i];
                for (int j = 0; j < nums.Length; j++)
                {
                    if (cur + nums[j] > target)
                    {
                        continue;
                    }
                    dp[nums[i] + nums[j]] += dp[nums[i]];
                }
            }
            return dp[target];
        }
    }
}
