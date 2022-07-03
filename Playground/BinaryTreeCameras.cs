using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class BinaryTreeCameras
    {
        private int Camera;
        // States: 0  = Unmonitored, 1 = camera, 2 = monitored
        public int MinCameraCover(TreeNode root)
        {
            if (GetState(root) == 0)
            {
                return Camera++;
            }
            return Camera;
        }

        public int GetState(TreeNode node)
        {
            if (node == null)
            {
                return 2;
            }
            var leftState = GetState(node.left);
            var rightState = GetState(node.right);
            if (leftState == 0 || rightState == 0)
            {
                Camera++;
                return 1;
            }
            if (leftState == 2 && rightState == 2)
            {
                return 0;
            }
            return 2;
        }
    }
}
