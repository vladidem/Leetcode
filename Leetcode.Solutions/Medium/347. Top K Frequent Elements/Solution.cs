﻿namespace Leetcode.Solutions.Medium._347._Top_K_Frequent_Elements;

/// <summary>
///     https://leetcode.com/problems/top-k-frequent-elements/
/// </summary>
public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> numFrequencies = new();

        foreach (int num in nums)
        {
            numFrequencies[num] = numFrequencies.GetValueOrDefault(num, 0) + 1;
        }

        var topk = new PriorityQueue<int, int>(numFrequencies.Select(it => (it.Key, it.Value)));

        for (int i = 0; i < numFrequencies.Count - k; i++)
        {
            topk.Dequeue();
        }

        return topk.UnorderedItems.Select(it => it.Element).ToArray();
    }
}
