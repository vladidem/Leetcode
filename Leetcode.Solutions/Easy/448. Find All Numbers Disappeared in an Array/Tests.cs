using FluentAssertions;

namespace Leetcode.Solutions.Easy._448._Find_All_Numbers_Disappeared_in_an_Array;

public class Tests
{
    [TestCase(new[] { 3, 1, 1 }, new[] { 2 })]
    [TestCase(new[] { 4, 3, 2, 7, 8, 2, 3, 1 }, new[] { 5, 6 })]
    public void FindDisappearedNumbers_NumbersAreMissing_ReturnsAllMissing(int[] nums, int[] expected)
    {
        new Solution()
            .FindDisappearedNumbers(nums)
            .Should()
            .BeEquivalentTo(expected.ToList());
    }
}
