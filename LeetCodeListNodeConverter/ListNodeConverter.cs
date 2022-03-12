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
            ListNode<TSource> next = new ListNode<TSource>();
            ListNode<TSource> head = next;
            using (var enumerator = sources.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    ListNode<TSource> curr = new ListNode<TSource>();
                    curr.val = enumerator.Current;
                    next.next = curr;
                    next = curr;
                }
            }
            head = head.next;
            return head;
        }
    }
}
