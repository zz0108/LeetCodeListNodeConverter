using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeListNodeConverter
{
    public static class TreeNodeConverter
    {
        public static TreeNode<TSource> ConverterToTreeNode<TSource>(this IEnumerable<TSource> sources)
        {
            TreeNode<TSource> head = new TreeNode<TSource>();
            Insert(head, sources.ToArray(), 0);
            return head;
        }

        private static void Insert<TSource>(TreeNode<TSource> node, IReadOnlyList<TSource> sources, int index)
        {
            node.val = sources[index];

            if (index * 2 + 1 < sources.Count)
            {
                node.left = new TreeNode<TSource>();
                Insert(node.left, sources, index * 2 + 1);
            }

            if (index * 2 + 2 < sources.Count)
            {
                node.right = new TreeNode<TSource>();
                Insert(node.right, sources, index * 2 + 2);
            }
        }
    }
}
