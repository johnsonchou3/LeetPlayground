using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class PathSumII
    {
        public IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {
            var result = new List<IList<int>>();
            if (root == null)
            {
                return result;
            }
            var stack = new Stack<TreeNode>();
            var path = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                var cur = stack.Pop();
                path.Push(cur);
                if (cur.right != null)
                {
                    stack.Push(cur.right);
                }
                if (cur.left != null)
                {
                    stack.Push(cur.left);
                }
                if (cur.left == null && cur.right == null)
                {
                    if (path.Select(x => x.val).Sum() == targetSum)
                    {
                        result.Add(path.Select(x => x.val).ToList());
                    }
                    while (stack.Peek() != path.Peek())
                    {
                        path.Pop();
                    }
                }
            }
            return result;
        }

        public IList<IList<int>> PathSum_Recursive(TreeNode root, int targetSum)
        {
            var result = new List<IList<int>>();
            if (root == null)
            {
                return result;
            }
            var stack = new Stack<TreeNode>();
            stack.Push(root);
            void DFS(TreeNode treeNode)
            {
                stack.Push(treeNode);
                if (treeNode.left ==null && treeNode.right == null )
                {
                    if (stack.Select(x=>x.val).Sum() == targetSum)
                    {
                        result.Add(stack.Select(x=>x.val).ToList());
                    }
                }
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
            return result;
        }
    }
}
