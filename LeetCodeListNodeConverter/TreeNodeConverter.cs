
namespace LeetCodeListNodeConverter
{
    public static class TreeNodeConverter
    {
        public static TreeNode<TSource>? ConverterToTreeNode<TSource>(this IEnumerable<TSource> sources)
        {
            var array = sources.ToArray();
            var root = new TreeNode<TSource>
            {
                val = array[0]
            };
            var queue = new Queue<TreeNode<TSource>?>();
            queue.Enqueue(root);
            var isLeft = true;
            for(var i = 1; i < array.Length; i++)
            {
                var node = queue.Peek();
                if(isLeft)
                {
                    if(array[i] != null)
                    {
                        var tmp = new TreeNode<TSource>
                        {
                            val = array[i]
                        };
                        node!.left = tmp;
                        queue.Enqueue(node.left);
                    }
                    isLeft = false;
                }
                else 
                {
                    if(array[i] != null)
                    {
                        var tmp = new TreeNode<TSource>
                        {
                            val = array[i]
                        };
                        node!.right = tmp;
                         queue.Enqueue(node.right);
                    }
                    queue.Dequeue();
                    isLeft = true;
                }
            }
            return root;
        }
    }
    
}
