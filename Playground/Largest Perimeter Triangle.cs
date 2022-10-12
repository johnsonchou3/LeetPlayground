namespace Playground;

public class Largest_Perimeter_Triangle
{
    public int LargestPerimeter(int[] nums)
    {
        var sorted = nums.OrderByDescending(x => x).ToArray();
        for (int i = 0; i < sorted.Length - 2; i++)
        {
            if (sorted[i] < sorted[i + 1] + sorted[i + 2])
            {
                return sorted[i] + sorted[i + 1] + sorted[i + 2];
            }
        }
        return 0;
    }
}