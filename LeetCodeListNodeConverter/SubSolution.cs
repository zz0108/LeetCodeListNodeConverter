using System.Security.Cryptography.X509Certificates;

namespace LeetCodeListNodeConverter;

public static class SubSolution
{
    private static int _carry = 0;
    public static string SubStrings(string num1, string num2)
    {
        
        if (num2.Length > num1.Length)
            (num1, num2) = (num2, num1);

        if (num1.Length == num2.Length)
        {
            var index = 0;
            while (index < num1.Length)
            {
                if (num2[index] > num1[index])
                {
                    (num1, num2) = (num2, num1);
                    break;
                }
                index++;
            }
        }

        var num1Right = num1.Length-1;
        var num2Right = num2.Length-1;
        var ret = string.Empty;
        while (num1Right >= 0 || num2Right >= 0)
        {
            var first = num1Right < 0 ? '0' : num1[num1Right];
            var second = num2Right < 0 ? '0' : num2[num2Right];
            ret += Sub(first, second);
            num1Right--;
            num2Right--;
        }
        var tmp = ret.Reverse().ToArray();

        if (tmp.All(a => a == '0'))
            return '0'.ToString();
        
        return new string(tmp).TrimStart('0');
    }
    
    private static string Sub(char num1, char num2)
    {
        var first = int.Parse(num1.ToString());
        var second = int.Parse(num2.ToString());
        var res = 0;
        if (second > first)
        {
            first += 10;
            res = _carry + first + (second * -1);
            _carry--;
        }
        else
        {
            res =  _carry + first + (second * -1);
        }
        return res.ToString();
    }
}