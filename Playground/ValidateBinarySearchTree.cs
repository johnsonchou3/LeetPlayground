using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class ValidateBinarySearchTree
    {
        public bool IsValidBST(TreeNode root)
        {
            var isValid = true;
            DFS(root);
            return isValid;
            void DFS(TreeNode node)
            {
                if(node == null)
                {
                    return;
                }
                if (node.left != null)
                {
                    if (node.left.val >= node.val)
                    {
                        isValid = false;
                    }
                    DFS(node.left);
                }
                if (node.right != null)
                {
                    if (node.right.val <= node.val)
                    {
                        isValid = false;
                    }
                    DFS(node.right);
                }
            }
        }
    }
}
