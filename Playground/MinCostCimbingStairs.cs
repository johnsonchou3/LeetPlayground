using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class MinCostCimbingStairs
    {
        public int MinCostClimbingStairs(int[] cost)
        {
            if (cost.Length < 3)
            {
                return cost.Min();
            }
            var dp = new int[cost.Length];
            dp[0] = cost[0];
            dp[1] = cost[1];
            for (int i = 2; i < cost.Length; i++)
            {
                dp[i] = Math.Min(dp[i-1], dp[i-2]) + cost[i];
            }
            return Math.Min(dp[cost.Length-1], dp[cost.Length-2]);
        }
    }
}
