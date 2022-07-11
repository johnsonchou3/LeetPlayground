using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class BinaryTreeRightSideView
    {

        public IList<int> RightSideView(TreeNode root)
        {
            var queue = new Queue<TreeNode>();
            var result = new List<int>();
            var level = 0;
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var temp = new List<TreeNode>();
                while (queue.Count > 0)
                {
                    temp.Add(queue.Dequeue());
                }
                result.Add(temp[0].val);
                foreach (var item in temp)
                {
                    level ++;
                    if (item.right != null)
                    {
                        queue.Enqueue((item.right));
                    }
                    if (item.left != null)
                    {
                        queue.Enqueue((item.left));
                    }
                }
            }
            return result;
        }
    }
}
