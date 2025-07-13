namespace Leetcode.Solutions.Easy._27._Remove_Element;

public class Tests
{
    [TestCase(new[] { 3, 2, 2, 3 }, 3, ExpectedResult = new[] { 2, 2 })]
    [TestCase(new[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, ExpectedResult = new[] { 0, 1, 3, 0, 4 })]
    public int[] RemoveElement_ElementExist_ReturnsRightLengthAndChangesInPlace(int[] nums, int val)
    {
        int newLenght = new Solution().RemoveElement(nums, val);

        return nums.Take(newLenght).ToArray();
    }
}
