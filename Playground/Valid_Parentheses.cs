using System.Collections;

namespace Playground;

public class Valid_Parentheses
{
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();
        var dict = new Dictionary<char, char>();
        dict.Add('(', ')');
        dict.Add('[', ']');
        dict.Add('{', '}');
        for (int i = 0; i < s.Length; i++)
        {
            if (dict.ContainsKey(s[i]))
            {
                stack.Push(s[i]);
            }
            else
            {
                if(stack.Count() != 0 && dict[stack.Peek()] == s[i])
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
        }

        return stack.Count() == 0;
    }
}