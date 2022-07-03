using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class HammingDistance
    {
        public int GetHammingDistance(int x, int y)
        {
            int result = x ^ y;
            int count = 0;

            // Code inside the loop is removing the right most 
            // bits of result one by one until result becomes 0
            // and number of bits we removed from result is our answer.

            while (result != 0)
            {
                count++;
                result = result & (result - 1);
            }

            return count;
        }
    }
}
