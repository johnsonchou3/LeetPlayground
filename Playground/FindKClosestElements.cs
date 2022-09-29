namespace Playground;

public class FindKClosestElements
{
    // v   v
    // 1 2 3 4 5
    public IList<int> FindClosestElements(int[] arr, int k, int x)
    {
        if(k >= arr.Length)
        {
            return arr;
        }
        var result = new List<int>();
        var left = 0;
        var right = k;
        while ( right < arr.Length && arr[right] < x)
        {
            left++;
            right++;
        }

        while (left < arr.Length && left <= right)
        {
            result.Add(arr[left]);
            left ++;
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
        Console.WriteLine(result.Count());
        var comp = new ClosestElementComparer(x);
        result.Sort(comp);
        return result.Take(k).OrderBy(x => x).ToList();
    }
}

public class ClosestElementComparer : IComparer<int>
{
    private readonly int Num;
    public ClosestElementComparer(int num)
    {
        Num = num;
    }
    public int Compare(int x, int y)
    {
        
        if (Math.Abs(Num - x) == Math.Abs(Num - y))
        {
            if (x < y)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
        else
        {
            if (Math.Abs(Num - x) < Math.Abs(Num - y))
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
}