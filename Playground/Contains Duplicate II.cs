namespace Playground;

public class Contains_Duplicate_II
{
    // T: O(N) S: O(N)
    // As we travers through, we remove values that are out of range of the window
    public bool SlidingWindow(int[] nums, int k)
    {
        var set = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            
            if (!set.Add(nums[i]))
            {
                return true;
            }
            if (i >= k)
            {
                // Remove options out of abs(i - j) <= k
                set.Remove(nums[i - k]);
            }
        }
        return false;
    }
    
    // T: O(N) S: O(N)
    // Traverse every point, when we encounter duplicate, we check if they are within k
    public bool MapAndCheck(int[] nums, int k)
    {
        // num -> j(index)
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!dict.TryAdd(nums[i], i))
            {
                // check we got answer, else we update new index
                if (i - dict[nums[i]] <= k)
                {
                    return true;
                }
                else
                {
                    dict[nums[i]] = i;
                }
            }
        }

        return false;
    }
}