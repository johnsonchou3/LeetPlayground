namespace Playground;

public class Continuous_Subarray_Sum
{
    public bool CheckSubarraySum(int[] nums, int k)
    {
        // remainder -> index
        var dict = new Dictionary<int, int>();
        var sum = 0;
        // to make sure we return when sum % k == 0, except i = 0
        dict.Add(0, -1);
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            var remainder = sum % k;
            if (!dict.TryAdd(remainder, i))
            {
                // we two remainders separated by a answer, it must be 3_6_1 
                // where index diff is at least 2
                if (i - dict[remainder] > 1)
                {
                    return true;
                }
            }
        }
        return false;
    }

    public bool BruteForce(int[] nums, int k)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            var sum = 0;
            for (int j = i; j < nums.Length; j++)
            {
                sum += nums[j];
                if (sum % k == 0)
                {
                    return true;
                }
            }
        }

        return false;
    }
}