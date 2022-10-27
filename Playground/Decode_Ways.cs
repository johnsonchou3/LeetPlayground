namespace Playground;

public class Decode_Ways
{
    public int NumDecodings(string s)
    {
        var n = s.Length;
        return DecodeChar(0);

        int DecodeChar(int curIndex)
        {
            if (curIndex == n)
            {
                return 1;
            }
            if (s[curIndex] == '0')
            {
                return 0;
            }

            var result = DecodeChar(curIndex + 1);
            if (curIndex + 1 < n && (s[curIndex] == 1 || (s[curIndex] == 2 && "0123456".Contains(s[curIndex + 1]))))
            {
                result += DecodeChar(curIndex + 2);
            }
            return result;
        }
    }
}