using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class ConstructBinaryTreefromPreorderandInorderTraversal
    {
        int[] Preorder;
        int Index = 0;
        Dictionary<int, int> InorderIndexMap = new Dictionary<int, int>();
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            Preorder = preorder;
            for (int i = 0; i < inorder.Length; i++)
            {
                InorderIndexMap.Add(inorder[i], i);
            }
            return Recurse(0, preorder.Length - 1);
        }

        private TreeNode Recurse(int left, int right)
        {
            if (left > right)
            {
                return null;
            }
            int rootValue = Preorder[Index++];
            var root = new TreeNode(rootValue);
            root.left = Recurse(left, InorderIndexMap[rootValue] - 1);
            root.right = Recurse(InorderIndexMap[rootValue] + 1, right);
            return root;
        }
    }
}
