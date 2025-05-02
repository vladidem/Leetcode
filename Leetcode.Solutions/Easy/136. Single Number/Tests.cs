namespace Leetcode.Solutions.Easy._136._Single_Number;

public class Tests
{
    [TestCase(new[] { 2, 2, 1 }, ExpectedResult = 1)]
    [TestCase(new[] { 4, 1, 2, 1, 2 }, ExpectedResult = 4)]
    [TestCase(new[] { 1 }, ExpectedResult = 1)]
    public int SingleNumber_ResultExist_ReturnsSingleNumber(int[] nums)
    {
        return new Solution().SingleNumber(nums);
    }
}
