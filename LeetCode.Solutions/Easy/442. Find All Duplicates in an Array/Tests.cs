using FluentAssertions;

namespace LeetCode.Solutions.Easy._448_Find_All_Duplicates_in_an_Array;

public class Tests
{
    [TestCase(new[] { 3, 1, 1 }, new[] { 1 })]
    [TestCase(new[] { 4, 3, 2, 7, 8, 2, 3, 1 }, new[] { 3, 2 })]
    public void FindDuplicates_DuplicatesExist_ReturnsDuplicates(int[] nums, int[] expected)
    {
        new Solution()
            .FindDuplicates(nums)
            .Should()
            .BeEquivalentTo(expected.ToList());
    }
}