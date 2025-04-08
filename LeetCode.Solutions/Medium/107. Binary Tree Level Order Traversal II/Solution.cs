using LeetCode.Solutions.DataStructures;

namespace LeetCode.Solutions.Medium._107_Binary_Tree_Level_Order_Traversal_II;

/// <summary>
///     https://leetcode.com/problems/binary-tree-level-order-traversal-ii/
/// </summary>
public class Solution
{
    public IList<IList<int>> LevelOrderBottom(TreeNode root)
    {
        IList<IList<int>> result = new List<IList<int>>();
        if (root == null) return result;
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            int levelSize = queue.Count;
            var level = new List<int>();

            for (int i = 0; i < levelSize; i++)
            {
                var node = queue.Dequeue();
                level.Add(node.val);

                if (node.left != null)
                    queue.Enqueue(node.left);
                if (node.right != null)
                    queue.Enqueue(node.right);
            }

            result.Insert(0, level);
        }

        return result;
    }
}
