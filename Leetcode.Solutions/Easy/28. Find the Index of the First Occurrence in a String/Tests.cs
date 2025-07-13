namespace Leetcode.Solutions.Easy._28._Find_the_Index_of_the_First_Occurrence_in_a_String;

public class Tests
{
    [TestCase("sadbutsad", "sad", ExpectedResult = 0)]
    public int FindNeedleInHaystack_NeedleExists_ReturnsFirstOccurance(string haystack, string needle)
    {
        return new Solution().StrStr(haystack, needle);
    }

    [TestCase("leetcode", "leeto", ExpectedResult = -1)]
    public int FindNeedleInHaystack_NeedleDoesntExist_ReturnsNegativeOne(string haystack, string needle)
    {
        return new Solution().StrStr(haystack, needle);
    }
}
