using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class CountGoodNodesinBinaryTree
    {
        public int GoodNodes(TreeNode root)
        {
            var count = 1;
            var stack = new Stack<TreeNode>();
            DFS(root);
            return count;

            void DFS(TreeNode treeNode)
            {
                if (stack.Count != 0)
                {
                    if (treeNode.val >= stack.Select(node => node.val).Max())
                    {
                        count++;
                    }
                }
                stack.Push(treeNode);
                if (treeNode.left != null)
                {
                    DFS(treeNode.left);
                }
                if (treeNode.right != null)
                {
                    DFS(treeNode.right);
                }
                stack.Pop();
            }
        }
    }
}
