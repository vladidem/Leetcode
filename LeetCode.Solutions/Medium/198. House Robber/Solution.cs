namespace LeetCode.Solutions.Medium._198_House_Robber;

/// <summary>
///     https://leetcode.com/problems/house-robber/
/// </summary>
public class Solution
{
    private Dictionary<int, int> cache = new();
    private Dictionary<ArraySegment<int>, int> cacheSegment = new();

    public int Rob(int[] nums)
    {
        return RobManual(nums);
    }

    private int RobManual(int[] nums)
    {
        cache = new Dictionary<int, int>();

        return RobManual(nums, 0);
    }

    private int RobManual(int[] nums, int start)
    {
        if (start > nums.Length - 1) return 0;
        if (start == nums.Length - 1) return nums[start];

        if (cache.ContainsKey(start)) return cache[start];

        int includeFirst = nums[start] + RobManual(nums, start + 2);
        int withoutFirst = RobManual(nums, start + 1);

        int result = Math.Max(includeFirst, withoutFirst);
        cache.Add(start, result);

        return result;
    }

    public int RobSegment(int[] nums)
    {
        cacheSegment = new Dictionary<ArraySegment<int>, int>();
        return Rob(new ArraySegment<int>(nums, 0, nums.Length));
    }

    private int Rob(ArraySegment<int> nums)
    {
        if (nums.Count == 0) return 0;
        if (nums.Count == 1) return nums[0];

        if (cacheSegment.ContainsKey(nums)) return cacheSegment[nums];

        int includeFirst = nums[0] + Rob(nums[2..]);
        int withoutFirst = Rob(nums[1..]);

        int result = Math.Max(includeFirst, withoutFirst);
        cacheSegment.Add(nums, result);

        return result;
    }
}
