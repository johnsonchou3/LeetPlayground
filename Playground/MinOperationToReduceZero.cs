using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class MinOperationToReduceZero
    {
        private int  min = int.MaxValue;
        public int BruteMinOperations(int[] nums, int x)
        {
            Recurse(0, x, 0, nums.Length - 1);
            return min == int.MaxValue ? -1 : min;
            void Recurse(int steps, int curX, int left, int right)
            {
                if (curX < 0)
                {
                    return;
                }
                if (curX ==  0)
                {
                    min = Math.Min(min, steps);
                    return;
                }
                ChooseLeft(steps, curX, left, right);
                ChooseRight(steps, curX, left, right);
            }
            
            void ChooseLeft(int steps, int curX, int left, int right)
            {
                steps++;
                curX = curX - nums[left];
                left++;
                Recurse(steps, curX, left, right);
            }
            void ChooseRight(int steps, int curX, int left, int right)
            {
                steps++;
                curX = curX - nums[right];
                right--;
                Recurse(steps, curX, left, right);
            }
        }
    }
}
