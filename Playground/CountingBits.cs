namespace Playground;

public class CountingBits
{
    public int[] CountBits(int n)
    {
        var result = new int[n+1];
        var offset = 1;
        for (int i = 1; i < result.Length; i++)
        {
            if ((offset * 2) == i)
            {
                offset = i;
            }

            result[i] = 1 + result[i - offset];
        }

        return result;
    }
}