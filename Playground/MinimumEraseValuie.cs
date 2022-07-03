using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    internal class MinimumEraseValue
    {
        public int MaximumUniqueSubarray(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }
            
            var left = 0;
            var right = 1;
            var maxScore = int.MinValue;
            var seen = new HashSet<int>();
            seen.Add(nums[left]);
            var subArraySum = nums[left] + nums[right];
            var maxSum = 0;
            
            while (right < nums.Length - 1)
            {
                Slide();
            }

            void Slide()
            {
                if (seen.Contains(nums[right]))
                {
                    seen.Remove(nums[left]);
                    subArraySum -= nums[left];
                    left++;
                }
                else
                {
                    right ++;
                    seen.Add(nums[right]);
                    subArraySum += nums[right];
                }
                maxSum = Math.Max(maxSum, subArraySum);
            }
            return maxSum;
        }
    }
}
