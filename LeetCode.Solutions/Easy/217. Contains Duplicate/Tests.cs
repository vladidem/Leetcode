namespace LeetCode.Solutions.Easy._217_Contains_Duplicate;

public class Tests
{
    [TestCase(new[] { 1, 2, 3, 1 }, ExpectedResult = true)]
    [TestCase(new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, ExpectedResult = true)]
    public bool ContainsDuplicate_ArrayWithDuplicate_ReturnsTrue(int[] nums)
    {
        return new Solution().ContainsDuplicate(nums);
    }

    [TestCase(new[] { 1, 2, 3, 4 }, ExpectedResult = false)]
    public bool ContainsDuplicate_ArrayWithoutDuplicates_ReturnsFalse(int[] nums)
    {
        return new Solution().ContainsDuplicate(nums);
    }
}