using LeetCode.Solutions.DataStructures;

namespace LeetCode.Solutions.Easy._112_Path_Sum;

/// <summary>
///     https://leetcode.com/problems/path-sum/
/// </summary>
public class Solution
{
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        return HasPathSumIterative(root, targetSum);
    }

    private bool HasPathSumRecursive(TreeNode node, int targetSum, int currentSum = 0)
    {
        if (node == null) return false;

        if (node.right == null && node.left == null)
            return currentSum + node.val == targetSum;

        return HasPathSumRecursive(node.right, targetSum, currentSum + node.val)
               || HasPathSumRecursive(node.left, targetSum, currentSum + node.val);
    }

    public bool HasPathSumIterative(TreeNode root, int targetSum)
    {
        if (root == null) return false;
        var stack = new Stack<(TreeNode, int)>();
        stack.Push((root, root.val));

        while (stack.Count > 0)
        {
            (var current, int currentSum) = stack.Pop();

            if (current.left != null)
                stack.Push((current.left, currentSum + current.left.val));

            if (current.right != null)
                stack.Push((current.right, currentSum + current.right.val));

            if (current.left == null && current.right == null && currentSum == targetSum)
                return true;
        }

        return false;
    }
}
