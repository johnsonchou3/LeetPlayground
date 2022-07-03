using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class MaximumPointsYouCanObtainfromCards
    {
        // test case [1,2,3,4,5,6,1], 3, length = 7
        // notChosen: 0~4
        // n, k = 2
        // window = 0 ~ n - 3
        // test case [1 1000 1], k = 1, l = 3
        // 
        public int MaxScore(int[] cardPoints, int k)
        {
            var sum = cardPoints.Sum();
            var subarrayLength = cardPoints.Length - k;
            var notChosenSum = cardPoints.Take(subarrayLength).Sum();
            var maxScore = sum - notChosenSum;
            for (int i = 0; i < cardPoints.Length - subarrayLength; i++) // i = 0, 
            {
                notChosenSum -= cardPoints[i];
                notChosenSum += cardPoints[cardPoints.Length - k + i]; //5 6 7 
                maxScore = Math.Max(maxScore, sum - notChosenSum);
            }
            return maxScore;
        }
    }
}
