using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class WiggleSubsequence
    {
        public int WiggleMaxLength(int[] nums)
        {
            if (nums.Length < 2)
                return nums.Length;
            int[] up = new int[nums.Length];
            int[] down = new int[nums.Length];
            up[0] = down[0] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    up[i] = down[i - 1] + 1;
                    down[i] = down[i - 1];
                }
                else if (nums[i] < nums[i - 1])
                {
                    down[i] = up[i - 1] + 1;
                    up[i] = up[i - 1];
                }
                else
                {
                    down[i] = down[i - 1];
                    up[i] = up[i - 1];
                }
            }
            return Math.Max(down[nums.Length - 1], up[nums.Length - 1]);
        }
    }
}
