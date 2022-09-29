namespace Playground;

public class FindKClosestElements
{
    // v   v
    // 1 2 3 4 5
    public IList<int> FindClosestElements(int[] arr, int k, int x)
    {
        var result = new List<int>();
        var left = 0;
        var right = k - 1;
        while (arr[right] < x && right < arr.Length)
        {
            left++;
            right++;
        }

        while (left <= right)
        {
            result.Add(arr[left]);
        }

        for (int i = 0; i < k; i++)
        {
            right++;
            if (right >= arr.Length)
            {
                break;
            }
            result.Add(arr[right]);
        }
        return result.Sort()
    }
}

public class ClosestElementComparer : IComparer<int>
{
    public int Compare(int x, int y)
    {
        
        if (x == y)
        {
            if (x < y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }
    throw new NotImplementedException();
    }
}