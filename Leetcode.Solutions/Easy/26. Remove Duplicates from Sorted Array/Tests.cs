namespace Leetcode.Solutions.Easy._26._Remove_Duplicates_from_Sorted_Array;

public class Tests
{
    [TestCase(new[] { 1, 1, 2 }, ExpectedResult = new[] { 1, 2 })]
    [TestCase(new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, ExpectedResult = new[] { 0, 1, 2, 3, 4 })]
    public int[] RemoveDuplicates_DuplicatesExist_ReturnsRightLengthAndChangesInPlace(int[] nums)
    {
        int newLenght = new Solution().RemoveDuplicates(nums);

        return nums.Take(newLenght).ToArray();
    }
}
