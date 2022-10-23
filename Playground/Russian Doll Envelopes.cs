namespace Playground;

public class Russian_Doll_Envelopes
{
    public int MaxEnvelopes(int[][] envelopes)
    {
        var sortByHeightAndWidth = envelopes.OrderBy(x => x[1]).ThenByDescending(x => x[0]).ToArray();
        var n = envelopes.Length;
        var max = 0;
        var dp = new int[n + 1];
        var dp2 = new int[n + 1];
        var cur = 1;
        dp[0] = int.MinValue;
        dp2[0] = int.MinValue;
        for (int i = 0; i < sortByHeightAndWidth.Length; i++)
        {
            if (sortByHeightAndWidth[i][0] > dp[cur - 1] )
            {
                if (sortByHeightAndWidth[i][1] > dp2[cur - 1])
                {
                    dp[cur] = sortByHeightAndWidth[i][0];
                    dp2[cur] = sortByHeightAndWidth[i][1];
                    cur++;
                }
            }
            else
            {
                var index = Array.BinarySearch(dp, 1, cur - 1, sortByHeightAndWidth[i][0]);
                if (index < 0)
                {
                    dp[(index * -1) - 1] = sortByHeightAndWidth[i][0];
                    dp2[(index * -1) - 1] = sortByHeightAndWidth[i][1];
                }
            }
            max = Math.Max(max, dp[i]);
        }
        return cur - 1;
    }
}