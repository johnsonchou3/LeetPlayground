namespace Playground;

public class Minimum_Window_Substring
{
    public string MinWindow(string s, string t)
    {
        string result = null;
        if (s.Length == 0 || t.Length == 0)
        {
            return result;
        }
        // char that we need to start count;
        var dict = new Dictionary<char, CharState>();
        foreach (var c in t)
        {
            if (!dict.TryAdd(c, new CharState(0, 1)))
            {
                dict[c].Target++;
            }
        }

        var targetCount = dict.Select(x => x.Value.Target).Sum();
        var curCount = 0;
        
        var l = 0;
        var r = 0;
        if (dict.ContainsKey(s[0]))
        {
            dict[s[0]].Cur++;
            curCount++;
        }
        
        //case 1: if all keys are satisfied, minimize the substring by moving left;
        // case2: if keys aren't satisfied, try to find keys by moving right;
        while (r < s.Length)
        {
            if (curCount == targetCount) //Allkey satisified
            {
                var substring = s.Substring(l, r);
                if (result == null || result.Length > substring.Length)
                {
                    result = substring;
                }

                l++;
            }
            else
            {
                r++;
                
            }
            
        }

        throw new NotImplementedException();
    }

    public class CharState
    {
        public CharState(int cur, int target)
        {
            Cur = cur;
            Target = target;
        }

        public int Cur { get; set; }
        public int Target { get; set; }
        
    }
}