using FluentAssertions;

namespace LeetCode.Solutions.Medium._451_Sort_Characters_By_Frequency;

public class Tests
{
    public static TestData[] FrequencySort_NotEmptyString_ReturnsSortedByFrequencyCases =
    {
        new(
            "cccaaa",
            ["cccaaa", "aaaccc"]
        ),
        new(
            "Aabb",
            ["bbAa", "bbaA"]
        )
    };

    [TestCaseSource(nameof(FrequencySort_NotEmptyString_ReturnsSortedByFrequencyCases))]
    public void FrequencySort_NotEmptyString_ReturnsSortedByFrequency(TestData testData)
    {
        string result = new Solution().FrequencySort(testData.s);

        result.Should().BeOneOf(testData.correctResults);
    }

    public record TestData(string s, string[] correctResults);
}
