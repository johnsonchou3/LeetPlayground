using System.Dynamic;

namespace Playground;

public class StringCompressionII
{
    public int GetLengthOfOptimalCompressionOptimal(string s, int k)
    {
        var n = s.Length;
        var dp = new int[101][];
        for (int i = 0; i < dp.Length; i++)
        {
            dp[i] = new int [101];
            Array.Fill(dp[i], int.MaxValue);
        }

        dp[0][0] = 0;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j <= Math.Min(i, k); j++)
            {
                if (j > 0)
                    dp[i][j] = Math.Min(dp[i][j], dp[i - 1][j - 1]);

                int x = 0, y = 0;
                for (int l = i; l >= 1; l--)
                {
                    if (s[l - 1] == s[i - 1])
                    {
                        x++;
                    }
                    else
                    {
                        y++;
                    }
                    if (j >= y)
                        dp[i][j] = Math.Min(dp[i][j], dp[l - 1][j - y] + CalLength(x));
                }
            }
        }

        return dp[n][k];

        int CalLength(int num)
        {
            if (num >= 100) return 4;
            if (num >= 10) return 3;
            if (num >= 2) return 2;
            return 1;
        }
    }

    public int GetLengthOfOptimalCompression(string s, int k)
    {
        return DP(0, ' ', 0, k);

        int DP(int cur, char prev, int prevCount, int k)
        {
            //Stop Computing
            if (k < 0)
            {
                return int.MaxValue;
            }

            if (cur == s.Length)
            {
                return 0;
            }

            //choose to delete, prev won't change
            var delete = DP(cur + 1, prev, prevCount, k - 1);
            //choose not to delete, two cases
            // 1. char is same as prev, it will get grouped
            // 2. char is different from prev, add char into prev
            int keep;
            if (s[cur] == prev)
            {
                //Group into prev, although 1 9 99 needs to + 2, it won't affect dp, we can add that afterwards
                keep = DP(cur + 1, s[cur], prevCount + 1, k);
                //
                if (prevCount == 1 || prevCount == 9 || prevCount == 99)
                {
                    keep += 1;
                }
            }
            else
            {
                keep = DP(cur + 1, s[cur], 1, k) + 1;
            }

            return Math.Min(delete, keep);
        }
    }
}