using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeListNodeConverter
{
    public class ListNode<T>
    {
        public T val { get; set; }
        public ListNode<T> next { get; set; }
    }
}
