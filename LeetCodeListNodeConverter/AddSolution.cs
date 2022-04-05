using System.Text;

namespace LeetCodeListNodeConverter;

public static class AddSolution
{
    private static int _carry = 0;
    public static string AddStrings(string num1, string num2)
    {
        var num1Right = num1.Length-1;
        var num2Right = num2.Length-1;
        var ret = new StringBuilder();
        while (num1Right >= 0 || num2Right >= 0)
        {
            var first = num1Right < 0 ? '0' : num1[num1Right];
            var second = num2Right < 0 ? '0' : num2[num2Right];
            ret.Append(Add(first, second));
            num1Right--;
            num2Right--;
        }

        if(_carry != 0)
            ret.Append(_carry);
        return ret.Reverse();
    }

    private static string Add(char num1, char num2)
    {
        var first = int.Parse(num1.ToString());
        var second = int.Parse(num2.ToString());
        var res = _carry + first + second;
        _carry = res / 10;
        return (res % 10).ToString();
    }
}