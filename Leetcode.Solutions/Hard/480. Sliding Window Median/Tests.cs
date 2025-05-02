using FluentAssertions;

namespace Leetcode.Solutions.Hard._480._Sliding_Window_Median;

public class Tests
{
    [TestCase(3, new[] { 1, 3, -1, -3, 5, 3, 6, 7 }, new[] { 1.00000, -1.00000, -1.00000, 3.00000, 5.00000, 6.00000 })]
    [TestCase(3,
        new[] { 1, 2, 3, 4, 2, 3, 1, 4, 2 },
        new[] { 2.00000, 3.00000, 3.00000, 3.00000, 2.00000, 3.00000, 2.00000 })]
    public void MedianSlidingWindow_NotEmptySequence_ReturnsMediansForWindows(int k, int[] numbers, double[] result)
    {
        double[] solution = new Solution().MedianSlidingWindow(numbers, k);
        solution.Should().BeEquivalentTo(result, opt => opt.WithStrictOrdering());
    }

    [TestCase(2,
        new[] { 2147483647, 1, 2, 3, 4, 5, 6, 7, 2147483647 },
        new[] { 1073741824.00000, 1.50000, 2.50000, 3.50000, 4.50000, 5.50000, 6.50000, 1073741827.00000 })]
    [TestCase(3,
        new[]
        {
            -2147483648, -2147483648, 2147483647, -2147483648, -2147483648, -2147483648, 2147483647, 2147483647,
            2147483647, 2147483647, -2147483648, 2147483647, -2147483648
        },
        new[]
        {
            -2147483648.00000, -2147483648.00000, -2147483648.00000, -2147483648.00000, -2147483648.00000,
            2147483647.00000, 2147483647.00000, 2147483647.00000, 2147483647.00000, 2147483647.00000, -2147483648.00000
        })]
    public void MedianSlidingWindow_Overflow_ReturnsMediansForWindows(int k, int[] numbers, double[] result)
    {
        double[] solution = new Solution().MedianSlidingWindow(numbers, k);
        solution.Should().BeEquivalentTo(result, opt => opt.WithStrictOrdering());
    }
}
