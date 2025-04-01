namespace LeetCode.Solutions.DataStructures;

public class TreeNode
{
    public TreeNode left;
    public TreeNode right;
    public int val;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }

    public static TreeNode FromArray(int?[] tree)
    {
        if (tree.Length == 0 || tree[0] == null) return null;
        var root = new TreeNode(tree[0]!.Value);

        List<TreeNode> level = [root];
        List<TreeNode> nextLevel = [];
        var i = 1;
        while (i < tree.Length)
        {
            foreach (var node in level)
            {
                if (i < tree.Length && tree[i] != null)
                {
                    node.left = new TreeNode(tree[i].Value);
                    nextLevel.Add(node.left);
                }

                i++;

                if (i < tree.Length && tree[i] != null)
                {
                    node.right = new TreeNode(tree[i].Value);
                    nextLevel.Add(node.right);
                }

                i++;
            }

            level = nextLevel;
            nextLevel = new List<TreeNode>();
        }

        return root;
    }
}