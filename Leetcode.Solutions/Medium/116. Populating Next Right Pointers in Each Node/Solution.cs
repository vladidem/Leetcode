using Leetсode.Solutions.DataStructures;

namespace Leetcode.Solutions.Medium._116._Populating_Next_Right_Pointers_in_Each_Node;

/// <summary>
///     https://leetcode.com/problems/populating-next-right-pointers-in-each-node/
/// </summary>
public class Solution
{
    public Node Connect(Node root)
    {
        if (root == null) return root;

        var level = new List<Node> { root };
        while (level.Any())
        {
            for (int i = 0; i < level.Count - 1; i++)
            {
                level[i].next = level[i + 1];
            }

            var nextLevel = new List<Node>();

            foreach (var node in level)
            {
                if (node.left != null)
                    nextLevel.Add(node.left);
                if (node.right != null)
                    nextLevel.Add(node.right);
            }

            level = nextLevel;
        }

        return root;
    }

    public Node ConnectRecursive(Node root)
    {
        if (root == null) return root;

        ConnectRecursiveStep(root);
        return root;
    }

    protected void ConnectRecursiveStep(Node node)
    {
        if (node.left == null || node.right == null)
            return;

        node.left.next = node.right;
        if (node.next != null)
        {
            node.right.next = node.next.left;
        }

        ConnectRecursiveStep(node.left);
        ConnectRecursiveStep(node.right);
    }
}
