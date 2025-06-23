namespace Leetcode.Solutions.Hard._2081._Sum_of_k_Mirror_Numbers;

public class Tests
{
    [TestCase(2, 5, ExpectedResult = 25)]
    [TestCase(3, 7, ExpectedResult = 499)]
    [TestCase(7, 17, ExpectedResult = 20379000)]
    [Timeout(100)]
    public long MedianSlidingWindow_NotEmptySequence_ReturnsMediansForWindows(int k, int n)
    {
        return new Solution().KMirror(k, n);
    }
}
