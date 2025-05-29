using FluentAssertions;

namespace Leetcode.Solutions.Medium._567._Permutation_in_String;

public class Tests
{
    [TestCase("ab", "eidbaooo")]
    public void CheckInclusion_PermutationExists_ReturnsTrue(string s1, string s2)
    {
        new Solution().CheckInclusion(s1, s2).Should().BeTrue();
    }

    [TestCase("ab", "eidboaoo")]
    public void CheckInclusion_PermutationDoesntExist_ReturnsFalse(string s1, string s2)
    {
        new Solution().CheckInclusion(s1, s2).Should().BeFalse();
    }


    [TestCase("hello", "ooolleoooleh")]
    public void CheckInclusion_NoPermutationAndSameCharAtStartAndEndWindow_ReturnsFalse(string s1, string s2)
    {
        new Solution().CheckInclusion(s1, s2).Should().BeFalse();
    }
}
