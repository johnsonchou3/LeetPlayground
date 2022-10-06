namespace Playground;

public class Binary_Search
{
    public int Search(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;
        var result = -1;
        while (left <= right)
        {
            var mid = (left + right) / 2;
            if (nums[mid] == target)
            {
                result = mid;
                break;
            }

            if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return result;
    }
}