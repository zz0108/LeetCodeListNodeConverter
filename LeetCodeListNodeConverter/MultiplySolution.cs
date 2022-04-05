using System.Text;

namespace LeetCodeListNodeConverter;

public static class MultiplySolution
{
    private static readonly List<string> MulList = new List<string>();
    private static int _carry;
    public static string Multiply(string num1, string num2)
    {
        var count = 0;
        for (var i = num1.Length-1; i >= 0; i--)
        {
            var mul = new StringBuilder();
            for (var j = num2.Length-1; j >= 0; j--)
                mul.Append(Mul(num2[j],num1[i]));
            
            if (_carry != 0)
            {
                mul.Append(_carry.ToString());
                _carry = 0;
            }
            var res = mul.Reverse();
            var len = res.Length;
            MulList.Add(res.PadRight(len+count,'0'));
            count++;
        }
        var fir = MulList[0];
        for (var i = 1; i < MulList.Count; i++)
        {
            _carry = 0;
            fir = AddSolution.AddStrings(fir, MulList[i]);
        }
        return fir.All(a => a == '0') ? '0'.ToString() : fir;
    }

    private static string Mul(char num1, char num2)
    {
        var first = int.Parse(num1.ToString());
        var second = int.Parse(num2.ToString());
        var ret = ((_carry + (first * second)) % 10).ToString();
        _carry = (_carry + (first * second)) / 10;
        return ret;
    }
}