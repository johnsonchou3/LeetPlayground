namespace Playground;

public class Break_a_Palindrome
{
    public string BreakPalindrome(string palindrome)
    {
        if (palindrome.Length == 1)
        {
            return "";
        }

        for (int i = 0; i < palindrome.Length; i++)
        {
            var c = palindrome[i];
            if (c != 'a')
            {
                var arr = palindrome.ToCharArray();
                arr[i] = 'a';
                return new string(arr);
            }
        }
        var brr = palindrome.ToCharArray();
        brr[0] = 'b';
        return new string(brr);
    }
}