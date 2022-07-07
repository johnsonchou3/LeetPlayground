using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class LeetCandy
    {
        public int Candy(int[] ratings)
        {
            ratings = ratings.OrderBy(x => x).ToArray();
            var totalCandies = 1;
            var lastGivenCandy = 1;
            var lastScore = ratings[0];
            for (int i = 1; i < ratings.Length; i++)
            {
                if (ratings[1] > lastScore)
                {
                    lastGivenCandy++;
                    totalCandies += lastGivenCandy;
                }
                else
                {
                    totalCandies += lastGivenCandy;
                }
                lastScore = ratings[i];
            }
            return totalCandies;
        }
    }
}
