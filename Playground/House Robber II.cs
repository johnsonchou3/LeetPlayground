namespace Playground;

public class House_Robber_II
{
    public int RobCircle(int[] nums)
    {
        return Math.Max(Rob(nums.SkipLast(1).ToArray()), Rob(nums.Skip(1).ToArray()));
    }

    public int Rob(int[] nums)
    {
        var n = nums.Length;
        var dp = new int[n];
        if(n == 0)
        {
            return 0;
        }

        if (n == 1)
        {
            return nums[0];
        }

        if (n == 2)
        {
            return Math.Max(nums[1], nums[0]);
        }

        dp[0] = nums[0];
        dp[1] = nums[1];
        for (int i = 2; i < dp.Length; i++)
        {
            dp[i] = Math.Max(dp[i - 1], dp[i - 2] + nums[i]);
        }

        return dp[n - 1];
    }
}