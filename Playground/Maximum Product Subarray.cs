namespace Playground;

public class Maximum_Product_Subarray
{
    public int MaxProduct(int[] nums)
    {
        var result = nums.Max();
        var min = 1;
        var max = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            var num = nums[i];
            if (num == 0)
            {
                result = Math.Max(result, max);
                min = 1;
                max = 1;
                continue;
            }

            var temp = num * max;
            min = new []{temp, num*min, num}.Min();
            max = new []{temp, num*min, num}.Max();
        }

        return Math.Max(result, max);
    }
}