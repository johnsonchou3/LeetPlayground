using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class JumpGameVI
    {
        public int MaxResult(int[] nums, int k)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }
            // SpecialCase k>nums.Length
            if (k > nums.Length)
            {

                var sum = nums[0];
                for (int i = 1; i < nums.Length - 1; i++)
                {
                    if (nums[i] > 0)
                    {
                        sum += nums[i];
                    }
                }
                sum += nums[nums.Length - 1];
                return sum;
            }


            var dp = new int[nums.Length];
            var queue = new Queue<int>(k);

            // Initialize 
            dp[0] = nums[0];
            queue.Enqueue(dp[0]);
            var prevMaxScore = dp[0];
            for (int i = 1; i < k; i++)
            {

                dp[i] = prevMaxScore + nums[i];
                if (dp[i] > prevMaxScore)
                {
                    prevMaxScore = dp[i];
                }
                queue.Enqueue(dp[i]);
            }
            for (int i = k; i < nums.Length; i++)
            {

                dp[i] = prevMaxScore+ nums[i];
                var remove = queue.Dequeue();
                queue.Enqueue(dp[i]);
                if (remove == prevMaxScore)
                {
                    prevMaxScore = queue.Max();
                }
                if (dp[i] > prevMaxScore)
                {
                    prevMaxScore = dp[i];
                }
            }
            return dp[nums.Length - 1];
        }
    }
}
