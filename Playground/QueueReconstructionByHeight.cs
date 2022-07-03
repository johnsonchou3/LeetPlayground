using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class QueueReconstructionByHeight
    {
        public int[][] ReconstructQueue(int[][] people)
        {
            var result = new List<int[]>();
            var sortedPeople = people.OrderByDescending(x => x[0]).ThenBy(x => x[1]);
            foreach (var p in sortedPeople)
            {
                result.Insert(p[1], p);
            }
            return result.ToArray();
        }
    }
}
