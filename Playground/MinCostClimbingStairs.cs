using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class LeetMinCostClimbingStairs
    {
        public int MinCostClimbingStairs(int[] cost)
        {
            var dp = new int[cost.Length];
            dp[0] = 0;
            dp[1] = cost[1];
            for (int i = 2; i < cost.Length; i++)
            {
                dp[i] = Math.Min(dp[i-1], dp[i-2]) + cost[i];
            }
            return dp[cost.Length - 1];
        }
    }
}
