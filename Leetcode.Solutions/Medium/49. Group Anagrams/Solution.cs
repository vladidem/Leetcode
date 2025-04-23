namespace LeetCode.Solutions.Medium._49_Group_Anagrams;

/// <summary>
///     https://leetcode.com/problems/group-anagrams/
/// </summary>
public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var groups = new Dictionary<string, IList<string>>();

        foreach (string str in strs)
        {
            string sortedStr = SortString(str);
            var group = groups.GetValueOrDefault(sortedStr, new List<string>());
            group.Add(str);
            groups[sortedStr] = group;
        }

        return groups.Select(group => group.Value).ToList();
    }

    private static string SortString(string input)
    {
        char[] characters = input.ToArray();
        Array.Sort(characters);
        return new string(characters);
    }
}
