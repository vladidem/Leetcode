namespace Leetcode.Solutions.Medium._347._Top_K_Frequent_Elements;

public class Tests
{
    [TestCase(new[] { 1, 1, 1, 2, 2, 3 }, 2, ExpectedResult = new[] { 1, 2 })]
    [TestCase(new[] { 3, 0, 1, 0 }, 1, ExpectedResult = new[] { 0 })]
    public int[] TopKFrequent_KLessThanLength_ReturnsTopFrequentElements(int[] nums, int k)
    {
        return new Solution().TopKFrequent(nums, k).Order().ToArray();
    }

    [TestCase(new[] { 1 }, 1, ExpectedResult = new[] { 1 })]
    public int[] TopKFrequent_KEqualsLength_ReturnsAll(int[] nums, int k)
    {
        return new Solution().TopKFrequent(nums, k).Order().ToArray();
    }
}
