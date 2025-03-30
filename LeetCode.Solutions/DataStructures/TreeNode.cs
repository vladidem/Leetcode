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

    public static TreeNode FromArray(int?[] nums)
    {
        return GetNode(nums, 0);
    }

    private static TreeNode GetNode(int?[] nums, int i)
    {
        if (i >= nums.Length || nums[i] == null) return null;

        var node = new TreeNode(
            nums[i]!.Value,
            GetNode(nums, (i + 1) * 2 - 1),
            GetNode(nums, (i + 1) * 2));

        return node;
    }
}