namespace Leetсode.Solutions.DataStructures;

public class Node
{
    public Node? left;
    public Node? next;
    public Node? right;
    public int val;

    public Node()
    {
    }

    public Node(int _val)
    {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next)
    {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }

    public static Node? FromArray(int?[] tree)
    {
        if (tree.Length == 0 || tree[0] == null) return null;

        var root = new Node(tree[0]!.Value);

        List<Node> level = [root];
        List<Node> nextLevel = [];
        int i = 1;
        while (i < tree.Length)
        {
            foreach (var node in level)
            {
                if (i < tree.Length && tree[i] != null)
                {
                    node.left = new Node(tree[i]!.Value);
                    nextLevel.Add(node.left);
                }

                i++;

                if (i < tree.Length && tree[i] != null)
                {
                    node.right = new Node(tree[i]!.Value);
                    nextLevel.Add(node.right);
                }

                i++;
            }

            level = nextLevel;
            nextLevel = new List<Node>();
        }

        return root;
    }
}
