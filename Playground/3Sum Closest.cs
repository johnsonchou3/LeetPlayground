namespace Playground;

public class Sum_Closest {
    public int ThreeSumClosest(int[] nums, int target) {
        var min = int.MaxValue;
        var sorted = nums.OrderBy(x => x).ToArray();
        var result = 0;
        for(int i = 0; i < nums.Length - 2; i++)
        {
            var left = i + 1;
            var right = nums.Length - 1;
            while(left < right)
            {
                var sum = sorted[i] + sorted[left] + sorted[right];
                var diff = Math.Abs(sum - target);
                if(diff == 0)
                {
                    return sum;
                }
                if(diff < min)
                {
                    result = sum;
                    min = Math.Min(min, diff);
                }

                if(sum < target)
                {
                    left ++;
                }
                else
                {
                    right -- ;
                }
            }
        }
        return result;
    
    }
}