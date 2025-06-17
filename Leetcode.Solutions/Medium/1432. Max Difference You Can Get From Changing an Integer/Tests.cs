namespace Leetcode.Solutions.Medium._1432._Max_Difference_You_Can_Get_From_Changing_an_Integer;

public class Tests
{
    [TestCase(555, ExpectedResult = 888)]
    [TestCase(9, ExpectedResult = 8)]
    [TestCase(123456, ExpectedResult = 820000)]
    public int MaxDiff_NotEmptyNumber_ReturnsMaxDiffAfterPermutations(int num)
    {
        return new Solution().MaxDiff(num);
    }
}
