namespace Leetcode.Solutions.Medium._198._House_Robber;

public class Tests
{
    [TestCase(new[] { 1, 2, 3, 1 }, ExpectedResult = 4)]
    [TestCase(new[]
        {
            114, 117, 207, 117, 235, 82, 90, 67, 143, 146, 53, 108, 200, 91,
            80, 223, 58, 170, 110, 236, 81, 90, 222, 160, 165, 195,
            187, 199, 114, 235, 197, 187, 69, 129, 64, 214, 228, 78, 188, 67, 205, 94, 205, 169, 241, 202, 144, 240
        },
        ExpectedResult = 4173)]
    [MaxTime(5000)]
    public int RobManual_NotEmptyArray_ReturnsMaxAmountOfMoneyToRob(int[] nums)
    {
        return new Solution().Rob(nums);
    }

    [TestCase(new[] { 1, 2, 3, 1 }, ExpectedResult = 4)]
    [TestCase(new[]
        {
            114, 117, 207, 117, 235, 82, 90, 67, 143, 146, 53, 108, 200, 91,
            80, 223, 58, 170, 110, 236, 81, 90, 222, 160, 165, 195,
            187, 199, 114, 235, 197, 187, 69, 129, 64, 214, 228, 78, 188, 67, 205, 94, 205, 169, 241, 202, 144, 240
        },
        ExpectedResult = 4173)]
    [MaxTime(5000)]
    public int RobSegment_NotEmptyArray_ReturnsMaxAmountOfMoneyToRob(int[] nums)
    {
        return new Solution().RobSegment(nums);
    }
}
