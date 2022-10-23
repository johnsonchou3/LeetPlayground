namespace Playground;

public class Integer_to_Roman
{
    private Dictionary<int, string> dict = new()
    {
        {1, "I"},
        {4, "IV"},
        {5, "V"},
        {9, "IX"},
        {10, "X"},
        {40, "XL"},
        {50, "L"},
        {90, "XC"},
        {100, "C"},
        {400, "CD"},
        {500, "D"},
        {900, "CM"},
        {1000, "M"}
    };
    public string IntToRoman(int num)
    {
        var result = "";
        Evaluate(1000);
        Evaluate(900);
        Evaluate(500);
        Evaluate(400);
        Evaluate(100);
        Evaluate(90);
        Evaluate(50);
        Evaluate(40);
        Evaluate(10);
        Evaluate(9);
        Evaluate(5);
        Evaluate(4);
        Evaluate(1);
        return result;
        int Evaluate(int x)
        {
            if (num >= x)
            {
                var count = num / x;
                result += string.Concat(Enumerable.Repeat(dict[x], count));
                num -= count * x;
            }

            return num;
        }
    }
}