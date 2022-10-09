namespace Playground;

public class Two_Sum_IV___Input_is_a_BST
{
    public bool FindTarget(TreeNode root, int k)
    {
        var set = new HashSet<int>();
        var hasPair = false;
        DFS(root);
        return hasPair;
        void DFS(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            if (set.Contains(node.val))
            {
                hasPair = true;
                return;
            }
            set.Add(k - node.val);
            DFS(node.left);
            DFS(node.right);
        }
    }
}