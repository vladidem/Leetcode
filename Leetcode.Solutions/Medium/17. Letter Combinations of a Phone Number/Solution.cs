namespace Leetcode.Solutions.Medium._17._Letter_Combinations_of_a_Phone_Number;

/// <summary>
///     https://leetcode.com/problems/letter-combinations-of-a-phone-number/
/// </summary>
public class Solution
{
    private static readonly IReadOnlyDictionary<char, List<char>> KeyMap = new Dictionary<char, List<char>>
    {
        { '2', ['a', 'b', 'c'] },
        { '3', ['d', 'e', 'f'] },
        { '4', ['g', 'h', 'i'] },
        { '5', ['j', 'k', 'l'] },
        { '6', ['m', 'n', 'o'] },
        { '7', ['p', 'q', 'r', 's'] },
        { '8', ['t', 'u', 'v'] },
        { '9', ['w', 'x', 'y', 'z'] }
    };

    public IList<string> LetterCombinations(string digits)
    {
        if (string.IsNullOrEmpty(digits))
            return [];

        var result = new List<string>
        {
            string.Empty
        };

        foreach (char c in digits)
        {
            var possibleKeys = KeyMap.GetValueOrDefault(c, []);

            result = result.Select(s => possibleKeys.Select(nextKey => s + nextKey)).SelectMany(it => it).ToList();
        }

        return result;
    }
}
