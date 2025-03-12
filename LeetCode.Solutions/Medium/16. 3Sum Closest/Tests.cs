using FluentAssertions;

namespace LeetCode.Solutions.Medium._16_3_Sum_Closest;

public class Tests
{
    [TestCase(new[] { -1, 2, 1, -4 }, 1, ExpectedResult = 2)]
    [TestCase(new[] { 0, 0, 0 }, 1, ExpectedResult = 0)]
    [TestCase(new[] { 1, 1, 1, 1 }, 0, ExpectedResult = 3)]
    [TestCase(new[] { 10,20,30,40,50,60,70,80,90 }, 1, ExpectedResult = 60)]
    public int ThreeSumClosest_NormalArray_ReturnsClosestSum(int[] nums, int target)
    {
        return new Solution().ThreeSumClosest(nums, target);
    }
}
