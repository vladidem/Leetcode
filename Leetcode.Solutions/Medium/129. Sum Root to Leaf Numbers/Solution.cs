using System.Collections.Immutable;
using Leetсode.Solutions.DataStructures;

namespace Leetcode.Solutions.Medium._129._Sum_Root_to_Leaf_Numbers;

/// <summary>
///     https://leetcode.com/problems/sum-root-to-leaf-numbers/
/// </summary>
public class Solution
{
    public int SumNumbers(TreeNode? root)
    {
        return SumNumbersRecursive(root);
    }

    public int SumNumbersRecursive(TreeNode? node, int sum = 0)
    {
        if (node == null) return 0;

        sum = sum * 10 + node.val;
        if (node.left == null && node.right == null)
            return sum;

        return SumNumbersRecursive(node.left, sum) + SumNumbersRecursive(node.right, sum);
    }


    public int SumNumbersPath(TreeNode? root)
    {
        if (root == null) return 0;

        var stack = new Stack<Path>();
        stack.Push(new Path(root, [root.val]));
        int result = 0;

        while (stack.Count > 0)
        {
            var path = stack.Pop();

            if (path.Node.right != null)
                stack.Push(path.Add(path.Node.right));

            if (path.Node.left != null)
                stack.Push(path.Add(path.Node.left));

            if (path.Node.left == null && path.Node.right == null)
                result += path.DigitsSum();
        }

        return result;
    }

    public record Path(TreeNode Node, ImmutableList<int> Values)
    {
        public Path Add(TreeNode next)
        {
            return new Path(next, Values.Add(next.val));
        }

        public int DigitsSum()
        {
            int result = 0;

            foreach (int digit in Values)
            {
                result = result * 10 + digit;
            }

            return result;
        }
    }
}
