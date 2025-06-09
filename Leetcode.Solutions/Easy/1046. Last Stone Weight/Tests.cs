namespace Leetcode.Solutions.Easy._1046._Last_Stone_Weight;

public class Tests
{
    [TestCase(new[] { 2, 7, 4, 1, 8, 1 }, ExpectedResult = 1)]
    [TestCase(new[] { 1 }, ExpectedResult = 1)]
    public int LastStoneWeight_OneStoneLeft_ReturnsLastStone(int[] stones)
    {
        return new Solution().LastStoneWeight(stones);
    }

    [TestCase(new[] { 2, 2 }, ExpectedResult = 0)]
    public int LastStoneWeight_NoStonesLeft_ReturnsZero(int[] stones)
    {
        return new Solution().LastStoneWeight(stones);
    }
}
