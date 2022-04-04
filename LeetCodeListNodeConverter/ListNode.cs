using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeListNodeConverter
{
    public class ListNode<T>
    {
        public ListNode()
        {
            
        }
        public ListNode(T val, ListNode<T> next)
        {
            this.val = val;
            this.next = next;
        }

        public T val { get; set; }
        public ListNode<T> next { get; set; }
    }
}
