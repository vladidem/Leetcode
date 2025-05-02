using FluentAssertions;

namespace Leetcode.Solutions.Easy._202._Happy_Number;

public class Tests
{
    [TestCase(23)]
    [TestCase(19)]
    public void HappyNumber_IsHappy_ReturnsTrue(int num)
    {
        new Solution().IsHappy(num).Should().BeTrue();
    }

    [TestCase(12)]
    public void HappyNumber_NotHappy_ReturnsFalse(int num)
    {
        new Solution().IsHappy(num).Should().BeFalse();
    }
}
