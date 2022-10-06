namespace Playground;

public class Maximum_Subarray
{
    public int MaxSubArray(int[] nums)
    {
        var max = nums[0];
        var sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (sum < 0)
            {
                sum = 0;
            }
            sum += nums[i];
            max = Math.Max(max, sum);
        }
        return max;
    }
}