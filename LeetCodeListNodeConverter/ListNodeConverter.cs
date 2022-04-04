using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeListNodeConverter
{
    public static class ListNodeConverter
    {
        public static ListNode<TSource> ConverterToListNode<TSource>(this IEnumerable<TSource> sources)
        {
            var next = new ListNode<TSource>();
            var head = next;
            using (var enumerator = sources.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    var current = new ListNode<TSource>
                    {
                        val = enumerator.Current
                    };
                    next.next = current;
                    next = current;
                }
            }
            head = head.next;
            return head;
        }
    }
}
