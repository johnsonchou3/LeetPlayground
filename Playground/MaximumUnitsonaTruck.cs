using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class MaximumUnitsonaTruck
    {
        public int MaximumUnits(int[][] boxTypes, int truckSize)
        {
            var sortedBoxes = boxTypes.OrderByDescending(x => x[1]).ToArray();
            var sum = 0;
            foreach (var x in sortedBoxes)
            {
                if (x[1] >= truckSize)
                {
                    sum += truckSize * x[0];
                    break;
                }
                else
                {
                    truckSize = truckSize - x[0];
                    sum += x[1] * x[0];
                }
            }
            return sum;
        }
    }
}
