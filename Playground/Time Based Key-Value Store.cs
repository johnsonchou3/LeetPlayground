namespace Playground;

public class TimeMap
{
    private Dictionary<string, Dictionary<int, string>> Dict = new Dictionary<string, Dictionary<int, string>>();
    public TimeMap() {
        
    }
    
    public void Set(string key, string value, int timestamp)
    {
        if (Dict.TryGetValue(key, out var timestampDict))
        {
            if (timestampDict.TryGetValue(timestamp, out var val))
            {
                timestampDict[timestamp] = value;
            }
            else
            {
                timestampDict.Add(timestamp, value);
            }
        }
        else
        {
            Dict.Add(key, new Dictionary<int, string>());
            Dict[key].Add(timestamp, value);
        }
    }
    
    public string Get(string key, int timestamp) {
        if (Dict.TryGetValue(key, out var t) && t.TryGetValue(timestamp, out var val))
        {
            return val;
        }
        else
        {
            return "";
        }
    }
}