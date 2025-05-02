using Leetсode.Solutions.DataStructures;

namespace Leetcode.Solutions.Medium._102._Binary_Tree_Level_Order_Traversal;

/// <summary>
///     https://leetcode.com/problems/binary-tree-level-order-traversal/
/// </summary>
public class Solution
{
    public IList<IList<int>> LevelOrder(TreeNode? root)
    {
        IList<IList<int>> result = new List<IList<int>>();
        if (root == null) return result;

        List<TreeNode?> queue = [root];

        while (queue.Count > 0)
        {
            result.Add(queue.Select(it => it!.val).ToList());

            queue = queue.SelectMany<TreeNode?, TreeNode?>(it => [it!.left, it.right])
                .Where(it => it != null)
                .ToList();
        }

        return result;
    }
}
