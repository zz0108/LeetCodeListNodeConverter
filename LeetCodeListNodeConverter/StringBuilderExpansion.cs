using System.Text;

namespace LeetCodeListNodeConverter;

public static class StringBuilderExpansion
{
    public static string Reverse(this StringBuilder source)
    {
        var tmp = new StringBuilder();
        for (var i = source.Length - 1; i >= 0; --i)
            tmp.Append(source[i]);
        return tmp.ToString();
    }

    public static StringBuilder ToStringBuilder<T>(this IEnumerable<T> source)
    {
        StringBuilder res = new StringBuilder();
        using var enumerator = source.GetEnumerator();
        while (enumerator.MoveNext())
        {
            res.Append(enumerator.Current);
        }
        return res;
    }
}
