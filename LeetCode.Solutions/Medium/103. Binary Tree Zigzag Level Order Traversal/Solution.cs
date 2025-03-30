using LeetCode.Solutions.DataStructures;

namespace LeetCode.Solutions.Medium._103_Binary_Tree_Zigzag_Level_Order_Traversal;

/// <summary>
///     https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal/
/// </summary>
public class Solution
{
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
    {
        IList<IList<int>> result = new List<IList<int>>();
        if (root == null) return result;
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        var depth = 1;

        while (queue.Count > 0)
        {
            var levelSize = queue.Count;
            var level = new List<int>();

            for (var i = 0; i < levelSize; i++)
            {
                var node = queue.Dequeue();
                level.Add(node.val);

                if (node.left != null)
                    queue.Enqueue(node.left);
                if (node.right != null)
                    queue.Enqueue(node.right);
            }

            if (depth % 2 == 0)
                level.Reverse();
            depth++;
            result.Add(level);
        }

        return result;
    }
}