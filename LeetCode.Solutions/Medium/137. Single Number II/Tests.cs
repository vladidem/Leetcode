namespace LeetCode.Solutions.Medium._137_Single_Number_II;

public class Tests
{
    [TestCase(new[] { 2, 2, 3, 2 }, ExpectedResult = 3)]
    [TestCase(new[] { 0, 1, 0, 1, 0, 1, 99 }, ExpectedResult = 99)]
    public int SingleNumber_ResultExist_ReturnsSingleNumber(int[] nums)
    {
        return new Solution().SingleNumber(nums);
    }
}
