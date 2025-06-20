namespace Leetcode.Solutions.Medium._3443._Maximum_Manhattan_Distance_After_K_Changes;

public class Tests
{
    [TestCase("NSWWEW", 3, ExpectedResult = 6)]
    [TestCase("NWSE", 1, ExpectedResult = 3)]
    public int MaxDistance_NotEmptyString_ReturnsMaxDistanceAfterKPermutations(string s, int k)
    {
        return new Solution().MaxDistance(s, k);
    }
}
