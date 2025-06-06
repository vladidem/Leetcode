using Leetсode.Solutions.DataStructures;

namespace Leetcode.Solutions.Medium._437._Path_Sum_III;

/// <summary>
///     https://leetcode.com/problems/path-sum-iii/
/// </summary>
public class Solution
{
    public int PathSum(TreeNode root, int targetSum)
    {
        return BreadthFirst(root)
            .Select(it => CountPathSumsIterative(it, targetSum))
            .Sum();
    }

    private IEnumerable<TreeNode> BreadthFirst(TreeNode? root)
    {
        if (root == null) yield break;

        var level = new List<TreeNode>
        {
            root
        };
        yield return root;

        while (level.Count > 0)
        {
            var nextLevel = new List<TreeNode>();
            foreach (var node in level)
            {
                if (node.left != null)
                {
                    nextLevel.Add(node.left);
                    yield return node.left;
                }

                if (node.right != null)
                {
                    nextLevel.Add(node.right);
                    yield return node.right;
                }
            }

            level = nextLevel;
        }
    }

    private int CountPathSumsIterative(TreeNode? pathStart, int targetSum)
    {
        if (pathStart == null) return 0;

        int summs = 0;
        var stack = new Stack<(TreeNode, long)>();

        stack.Push((pathStart, pathStart.val));

        while (stack.Count > 0)
        {
            (var current, long currentSum) = stack.Pop();

            if (currentSum == targetSum)
                summs++;

            if (current.left != null)
            {
                stack.Push((current.left, currentSum + current.left.val));
            }

            if (current.right != null)
            {
                stack.Push((current.right, currentSum + current.right.val));
            }
        }

        return summs;
    }
}
