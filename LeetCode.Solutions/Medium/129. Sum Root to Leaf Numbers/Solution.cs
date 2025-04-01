using System.Collections.Immutable;
using LeetCode.Solutions.DataStructures;

namespace LeetCode.Solutions.Medium._129_Sum_Root_to_Leaf_Numbers;

/// <summary>
///     https://leetcode.com/problems/sum-root-to-leaf-numbers/
/// </summary>
public class Solution
{
    public int SumNumbers(TreeNode root)
    {
        return SumNumbersRecursive(root);
    }

    public int SumNumbersRecursive(TreeNode node, int sum = 0)
    {
        if (node == null) return 0;
        sum = sum * 10 + node.val;
        if (node.left == null && node.right == null)
            return sum;

        return SumNumbersRecursive(node.left, sum) + SumNumbersRecursive(node.right, sum);
    }


    public int SumNumbersPath(TreeNode root)
    {
        if (root == null) return 0;

        var stack = new Stack<Path>();
        stack.Push(new Path(root, [root.val]));
        var result = 0;

        while (stack.Count > 0)
        {
            var path = stack.Pop();

            if (path.node.right != null)
                stack.Push(path.Add(path.node.right));

            if (path.node.left != null)
                stack.Push(path.Add(path.node.left));

            if (path.node.left == null && path.node.right == null)
                result += path.DigitsSum();
        }

        return result;
    }

    public record Path(TreeNode node, ImmutableList<int> values)
    {
        public Path Add(TreeNode next)
        {
            return new Path(next, values.Add(next.val));
        }

        public int DigitsSum()
        {
            var result = 0;

            foreach (var digit in values)
                result = result * 10 + digit;

            return result;
        }
    }
}