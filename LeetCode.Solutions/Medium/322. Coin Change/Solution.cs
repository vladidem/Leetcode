namespace LeetCode.Solutions.Medium._322_Coin_Change;

/// <summary>
///     https://leetcode.com/problems/coin-change/
/// </summary>
public class Solution
{
    private Dictionary<int, int> cache = new();

    public int CoinChange(int[] coins, int amount)
    {
        cache = new Dictionary<int, int>();
        return CoinChangeRecursive(coins, amount);
    }

    private int CoinChangeRecursive(int[] coins, int amount)
    {
        if (amount < 0) return -1;
        if (amount == 0) return 0;
        if (cache.TryGetValue(amount, out int cachedCoinsCount))
            return cachedCoinsCount;

        int coinsCount = -1;

        for (int i = 0; i < coins.Length; i++)
        {
            int coinsCountWithCoinI = CoinChangeRecursive(coins, amount - coins[i]);
            if (coinsCountWithCoinI == -1)
                continue;

            coinsCountWithCoinI++;

            if (coinsCount == -1 || coinsCount > coinsCountWithCoinI)
                coinsCount = coinsCountWithCoinI;
        }

        cache[amount] = coinsCount;

        return coinsCount;
    }
}
