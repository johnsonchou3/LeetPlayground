namespace Playground;

public class Delete_Operation_for_Two_Strings
{
    public int MinDistance(string word1, string word2)
    {
        var n = word1.Length;
        var m = word2.Length;
        var dp = new int[n + 1][];
        for (int i = 0; i <= n; i++)
        {
            dp[i] = new int[m + 1];
        }

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= m; j++)
            {
                if (word1[i - 1] == word2[j - 1] )
                {
                    dp[i][j] = dp[i - 1][j - 1] + 1;
                }
                else
                {
                    dp[i][j] = Math.Max(dp[i][j - 1], dp[i - 1][j]);
                }
            }
        }

        var LCS = dp[n][m];
        return n - LCS + m - LCS;
    }
}