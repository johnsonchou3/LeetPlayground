using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class PascalTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            int row = numRows;
            var dp = new int[row][];

            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = new int[i + 1];
                // set the first and last cell value to 1
                dp[i][0] = dp[i][i] = 1;

                // will start setting from 2nd cell, index = 1
                for (int j = 1; j < i; j++)
                {
                    // (current cell from previous row + previous cell from previous row)
                    dp[i][j] = dp[i - 1][j] + dp[i - 1][j - 1];
                }
            }

            return dp;
        }
    }
}
