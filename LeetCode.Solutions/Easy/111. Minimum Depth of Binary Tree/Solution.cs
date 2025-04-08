using LeetCode.Solutions.DataStructures;

namespace LeetCode.Solutions.Easy._111_Minimum_Depth_of_Binary_Tree;

/// <summary>
///     https://leetcode.com/problems/minimum-depth-of-binary-tree/
/// </summary>
public class Solution
{
    public int MinDepth(TreeNode root)
    {
        if (root == null) return 0;
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int depth = 1;

        while (queue.Count > 0)
        {
            int levelSize = queue.Count;

            for (int i = 0; i < levelSize; i++)
            {
                var node = queue.Dequeue();

                if (node.left == null && node.right == null)
                    return depth;

                if (node.left != null)
                    queue.Enqueue(node.left);

                if (node.right != null)
                    queue.Enqueue(node.right);
            }

            depth++;
        }

        return depth;
    }
}
