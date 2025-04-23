namespace LeetCode.Solutions.Medium._260_Single_Number_III;

public class Tests
{
    [TestCase(new[] { 1, 2, 1, 3, 2, 5 }, ExpectedResult = new[] { 3, 5 })]
    [TestCase(new[] { -1, 0 }, ExpectedResult = new[] { -1, 0 })]
    public int[] SingleNumber_ResultExist_ReturnsTwoSingleNumbers(int[] nums)
    {
        return new Solution().SingleNumber(nums).OrderBy(x => x).ToArray();
    }
}
