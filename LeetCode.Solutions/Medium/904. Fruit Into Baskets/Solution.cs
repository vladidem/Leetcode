namespace LeetCode.Solutions.Medium._904_Fruit_Into_Baskets;

/// <summary>
///     https://leetcode.com/problems/fruit-into-baskets/
///     see 340
///     https://leetcode.com/problems/longest-substring-with-at-most-k-distinct-characters/description/
/// </summary>
public class Solution
{
    public int TotalFruit(int[] fruits, int maxBaskets = 2)
    {
        int windowStart = 0;
        int basketsWithFruits = 0;
        var baskets = new Dictionary<int, int>();
        int maxLenght = 0;

        for (int windowEnd = 0; windowEnd < fruits.Length; windowEnd++)
        {
            int endFruit = fruits[windowEnd];
            if (baskets.GetValueOrDefault(endFruit, 0) > 0)
            {
                baskets[endFruit]++;
            }
            else
            {
                baskets[endFruit] = 1;
                basketsWithFruits++;
            }

            while (basketsWithFruits > maxBaskets)
            {
                int startFruit = fruits[windowStart];
                baskets[startFruit]--;
                if (baskets[startFruit] == 0)
                {
                    basketsWithFruits--;
                }

                windowStart++;
            }

            int windowLength = windowEnd - windowStart + 1;
            if (windowLength > maxLenght)
            {
                maxLenght = windowLength;
            }
        }

        return maxLenght;
    }
}