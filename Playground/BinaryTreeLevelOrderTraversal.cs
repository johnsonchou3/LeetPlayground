using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class BinaryTreeLevelOrderTraversal
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            if (root == null)
            {
                return new List<IList<int>>();
            }
            var result = new List<IList<int>>();
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.TryPeek(out _))
            {
                queue.Enqueue(null);
                var levelResult = new List<int>();
                while (queue.TryPeek(out var qq) && qq != null)
                {
                    var temp = queue.Dequeue();
                    levelResult.Add(temp.val);
                    if (temp.left != null)
                    {
                        queue.Enqueue(temp.left);
                    }
                    if (temp.right != null)
                    {
                        queue.Enqueue(temp.right);
                    }
                    //remove null
                }
                result.Add(levelResult);
                queue.Dequeue();
            }
            return result;
        }
    }
}
