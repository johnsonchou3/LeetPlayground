namespace Playground;

public class TimeMap
{
    private readonly IDictionary<string, IList<(int, string)>> keyTimeDict;
        
    public TimeMap() 
    {
        keyTimeDict = new Dictionary<string, IList<(int, string)>>();
    }
    
    public void Set(string key, string value, int timestamp)
    {
        if (!keyTimeDict.ContainsKey(key))
        {
            keyTimeDict[key] = new List<(int, string)>();
        }
        
        keyTimeDict[key].Add((timestamp, value));
    }
    
    public string Get(string key, int timestamp)
    {
        
        if (!keyTimeDict.ContainsKey(key))
        {
            return "";
        }
        
        var values = keyTimeDict[key];
        
        int left = 0, right = values.Count - 1;
        
        while (left + 1 < right)
        {
            int mid = left + (right - left) / 2;
            if (values[mid].Item1 < timestamp)
            {
                left = mid;
            }
            else
            {
                right = mid;
            }
        }
        
        
        if (values[left].Item1 > timestamp)
        {
            return "";
        }
        
        return values[right].Item1 <= timestamp ? values[right].Item2 : values[left].Item2;
    }
}