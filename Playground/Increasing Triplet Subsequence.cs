using System.Runtime;

namespace Playground;

public class Increasing_Triplet_Subsequence
{
    public bool IncreasingTriplet(int[] nums)
    {
        var m1 = int.MaxValue;
        var m2 = int.MaxValue;
        for (int i = 0; i < nums.Length; i++)
        {
            if (m1 > nums[i])
            {
                m1 = nums[i];
            }
            else if (m2 > nums[i])
            {
                m2 = nums[i];
            }
            else
            {
                return true;
            }
        }

        return false;
    }
}