using System.Collections.Immutable;
using Leetсode.Solutions.DataStructures;

namespace Leetcode.Solutions.Medium._113._Path_Sum_II;

/// <summary>
///     https://leetcode.com/problems/path-sum-ii/
/// </summary>
public class Solution
{
    public IList<IList<int>> PathSum(TreeNode root, int targetSum)
    {
        if (root == null) return [];

        var stack = new Stack<Path>();
        stack.Push(new Path(root, [root.val], root.val));
        IList<IList<int>> result = new List<IList<int>>();

        while (stack.Count > 0)
        {
            var path = stack.Pop();

            if (path.node.right != null)
                stack.Push(path.Add(path.node.right));

            if (path.node.left != null)
                stack.Push(path.Add(path.node.left));

            if (path.node.left == null && path.node.right == null && path.sum == targetSum)
                result.Add(path.values);
        }

        return result;
    }

    public record Path(TreeNode node, ImmutableList<int> values, int sum)
    {
        public Path Add(TreeNode next)
        {
            return new Path(next, values.Add(next.val), sum + next.val);
        }
    }
}
