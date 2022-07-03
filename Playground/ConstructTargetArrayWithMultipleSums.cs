using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class ConstructTargetArrayWithMultipleSums
    {
        public bool IsPossible(int[] target)
        {
            // max heap of target array items
            var queue = new PriorityQueue<int, int>();
            // precalculated target array items sum
            var sum = 0L;
            foreach (var item in target)
            {
                sum += item;
                queue.Enqueue(item, -item);
            }

            // process target items in decreasing order
            while (queue.Peek() > 1)
            {
                var value = queue.Dequeue();
                var otherItemsSum = sum - value;

                if (otherItemsSum == 0 // case when target array contains single item > 1 (in this case sum would only be one)
                   || otherItemsSum >= value // case when other items sum > max number 
                                             // case when target contains 2 items and one of them is 1 (in this case ) 
                   || (otherItemsSum != 1 && value % otherItemsSum == 0)) 
                {
                    return false;
                }

                value = value % (int)otherItemsSum;
                // update precalculated items sum
                sum = otherItemsSum + value;
                queue.Enqueue(value, -value);
            }

            return true;
        }
    }
}
