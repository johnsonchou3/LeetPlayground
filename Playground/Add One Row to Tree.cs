namespace Playground;

public class Add_One_Row_to_Tree
{
    public TreeNode AddOneRow(TreeNode root, int val, int depth)
    {
        var queue = new Queue<TreeNode>();
        if (depth == 1)
        {
            var temp = new TreeNode(val);
            temp.left = root;
            root = temp;
        }

        BFS(root, 1);
        return root;
        void BFS(TreeNode node, int curDepth)
        {
            queue.Enqueue(node);
            if (curDepth == depth - 1)
            {
                var left = new TreeNode(val);
                left.left = node.left;
                var right = new TreeNode(val);
                right.right = node.right;
                node.left = left;
                node.right = right;
            }
            if (node.left != null)
            {
                BFS(node.left, curDepth + 1);
            }

            if (node.right != null)
            {
                BFS(node.right, curDepth + 1);
            }
            queue.Dequeue();
        }
    }
}