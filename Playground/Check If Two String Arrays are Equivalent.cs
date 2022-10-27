namespace Playground;

public class Check_If_Two_String_Arrays_are_Equivalent
{
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        return string.Join("", word1) == string.Join("", word2);
    }
}