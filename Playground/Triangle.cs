using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class Triangle
    {
        public int BruteMinimumTotal(IList<IList<int>> triangle)
        {
            Dictionary<(int, int), int> memo = new();
            if (triangle.Count() == 1)
            {
                return triangle[0][0];
            }
            return Recurse(0, 0);

            int Recurse(int row, int index)
            {
                if (row == triangle.Count() - 1)
                {
                    return triangle[row][index];
                }
                else
                {
                    if (!memo.TryGetValue((row + 1, index), out int firstValue))
                    {
                        firstValue = Recurse(row + 1, index);
                    }
                    var curSum = triangle[row][index] + Math.Min(firstValue, Recurse(row + 1, index + 1));
                    memo.TryAdd((row, index), curSum);
                    return curSum;
                }
            }
        }
    }
}
