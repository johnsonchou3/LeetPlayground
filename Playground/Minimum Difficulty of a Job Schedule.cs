using System.Collections;

namespace Playground;

public class Minimum_Difficulty_of_a_Job_Schedule
{
    public int MinDifficultyOptimized(int[] jobDifficulty, int d)
    {
        var n = jobDifficulty.Length;
        if(n < d)
        {
            return -1;
        }
        var dp = new int[n];
        var dp2 = new int[n];
        var temp = dp2;
        Array.Fill(dp, int.MaxValue/2);
        var stack = new Stack<int>();
        
        for (int i = 0; i < d; i++)
        {
            stack.Clear();
            for (int j = i; j < n; j++)
            {
                dp2[j] = j == 0 ? jobDifficulty[j] : dp[j - 1] + jobDifficulty[j];
                
                while(stack.Count()!=0 && jobDifficulty[stack.Peek()] <= jobDifficulty[j])
                {
                    var k = stack.Pop();
                    dp2[j] = Math.Min(dp2[j], dp2[k] - jobDifficulty[k] + jobDifficulty[j]);
                }
                if (stack.Count() != 0)
                {
                    dp2[j] = Math.Min(dp2[j], dp2[stack.Peek()]);
                }
                stack.Push(j);
            }
            temp = dp;
            dp = dp2;
            dp2 = temp;
        }

        return dp[n - 1];
    }
    
    public int MinDifficulty(int[] jobDifficulty, int d)
    {
        var n = jobDifficulty.Length;
        
        // days can't be filled with n < d
        if (n < d)
        {
            return -1;
        }
        
        // Initialize with days * jobs array, and fill them with Int.MaxValue/2
        var dp = new int[d + 1][];
        for (int i = 0; i < dp.Length; i++)
        {
            dp[i] = new int[n + 1];
            Array.Fill(dp[i], int.MaxValue/2);
        }
        
        // InitialCase
        dp[0][0] = 0;

        //For each day (i), we will find Min Difficulty for every j cut 
        for (int i = 1; i <= d; i++)
        {
            for (int j = i; j <= n; j++)
            {
                // Max Job Difficulty of right boundary
                var md = 0;
                // Iterate from i - 1, where we only choose 1 job for last day, till j + 1, else there won't be enough jobs for j days
                for (int k = j; k >= i; k--)
                {
                    md = Math.Max(md, jobDifficulty[k - 1]);
                    dp[i][j] = Math.Min(dp[i][j], dp[i - 1][k - 1] + md);
                }
            }
        }

        return dp[d][n];
    }
    
    public int Demo(int[] jobDifficulty, int d) {
        var n = jobDifficulty.Length;
        if(d > n)
        {
            return -1;
        }
        
        var dp = new int[n + 1][];
        for (int i = 0; i < dp.Length; i++)
        {
            dp[i] = new int[d + 1];
            Array.Fill(dp[i], int.MaxValue/2);
        }

        dp[0][0] = 0;

        for (int i = 1; i <= n; i++)
        {
            for (int k = 1; k <= d; k++)
            {
                int md = 0;
                for (int j = i - 1; j >= k - 1; j--)
                {
                    md = Math.Max(md, jobDifficulty[j]);
                    dp[i][k] = Math.Min(dp[i][k], dp[j][k - 1] + md);
                }
            }
        }

        return dp[n][d];
    }
}