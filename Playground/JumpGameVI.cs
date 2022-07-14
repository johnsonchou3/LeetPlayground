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
            var queue = new PriorityQueue<int, int >(k, new Comparer());
            
            // Initialize 
            dp[0] = nums[0];
            queue.Enqueue(0 ,dp[0]);
            for (int i = 1; i < k; i++)
            {
                queue.TryPeek(out var index, out var prior);
                dp[i] = prior+ nums[i];
                queue.Enqueue(i, dp[i]);
            }
            for (int i = k; i < nums.Length; i++)
            {
                queue.TryPeek(out var index, out var prior);
                while (index< i - k)
                {
                    queue.Dequeue();
                    queue.TryPeek(out index, out prior);
                }
                dp[i] = prior + nums[i];
                queue.Enqueue(i, dp[i]);
            }
            return dp[nums.Length - 1];
        }

        public class Comparer : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                // y is larger, put it ahead
                if (x < y)
                {
                    return 1;
                }
                else if (x == y)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
}
