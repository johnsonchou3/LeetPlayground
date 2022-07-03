using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class MinimumMovestoEqualArrayElementsII
    {
        public int MinMoves2(int[] nums)
        {
            var l = nums.Length;
            var sortedArr = nums.OrderBy(x => x).ToArray();
            if (l % 2 != 0)
            {
                l++;
            }
            var medianIndex = l / 2 - 1;
            var steps = 0;
            foreach (var num in nums)
            {
                steps += Math.Abs(num - sortedArr[medianIndex]);
            }
            return steps;
        }
    }
}
