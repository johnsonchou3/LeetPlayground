namespace Playground;

public class Maximum_Length_of_a_Concatenated_String_with_Unique_Characters
{
    public int MaxLength(IList<string> arr)
    {
        var max = 0;
        Recurse(0, new HashSet<char>(), 0);
        return max;
        void Recurse(int i, HashSet<char> curChar, int curLength)
        {
            if (i == arr.Count)
            {
                return;
            }

            var originalChar = new HashSet<char>(curChar);
            foreach (var c in arr[i])
            {
                if (curChar.Contains(c))
                {
                    return;
                }
                else
                {
                    curChar.Add(c);
                }
            }
            Recurse(i + 1, originalChar, curLength);
            curLength += arr[i].Length;
            max = Math.Max(max, curLength);
            Recurse(i + 1, new HashSet<char>(curChar), curLength);
            // choose not to use 
        }
    }
}