namespace Playground;

public class Top_K_Frequent_Words
{
    public IList<string> TopKFrequent(string[] words, int k)
    {
        var dict = new Dictionary<string, int>();
        for (int i = 0; i < words.Length; i++)
        {
            var word = words[i];
            if (!dict.TryAdd(word, 1))
            {
                dict[word]++;
            }
        }

        var x = dict.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
        return x.Select(q => q.Key).Take(k).ToList();
    }
}