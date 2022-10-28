namespace Playground;

public class Group_Anagrams
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var dict = new Dictionary<string, IList<string>>();
        foreach (var s in strs)
        {
            var arr = s.ToCharArray();
            Array.Sort(arr);
            var orderedKey = new string(arr);
            if (dict.TryGetValue(orderedKey, out var list))
            {
                list.Add(s);
            }
            else
            {
                dict.Add(orderedKey, new List<string>(){s});
            }
        }
        return dict.Select(x => x.Value).ToList();
    }
}