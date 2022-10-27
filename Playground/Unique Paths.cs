namespace Playground;

public class Unique_Paths
{
    public int UniquePaths(int m, int n)
    {
        var dp = new int[m + 1][];
        for (int i = 0; i < dp.Length; i++)
        {
            dp[i] = new int[n + 1];
        }

        dp[1][1] = 1;
        for (int i = 1; i < m + 1; i++)
        {
            for (int j = 1; j < n + 1; j++)
            {
                dp[i][j] = dp[i][j] + dp[i - 1][j] + dp[i][j - 1];
            }
        }
        return dp[m][n];
    }
}