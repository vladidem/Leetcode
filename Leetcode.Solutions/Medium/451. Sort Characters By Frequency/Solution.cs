using System.Text;

namespace LeetCode.Solutions.Medium._451_Sort_Characters_By_Frequency;

/// <summary>
///     https://leetcode.com/problems/sort-characters-by-frequency/
/// </summary>
public class Solution
{
    public string FrequencySort(string s)
    {
        Dictionary<char, int> charFrequencies = new();

        foreach (char c in s)
        {
            charFrequencies[c] = charFrequencies.GetValueOrDefault(c, 0) + 1;
        }

        var maxHeap = new PriorityQueue<char, int>(
            charFrequencies.Select(it => (it.Key, it.Value)),
            Comparer<int>.Create((x, y) => y.CompareTo(x)));

        var result = new StringBuilder();

        for (int i = 0; i < charFrequencies.Count; i++)
        {
            bool notEmpty = maxHeap.TryDequeue(out char c, out int frequency);
            if (!notEmpty) break;

            result.Append(Enumerable.Repeat(c, frequency).ToArray());
        }

        return result.ToString();
    }
}
