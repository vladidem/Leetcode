namespace Leetcode.Solutions.Medium._322._Coin_Change;

/// <summary>
///     https://leetcode.com/problems/coin-change/
/// </summary>
public class Solution
{
    private Dictionary<int, int> cache = new();

    public int CoinChange(int[] coins, int amount)
    {
        cache = new Dictionary<int, int>();
        return CoinChangeBottomUp(coins, amount);
    }

    private int CoinChangeBottomUp(int[] coins, int amount)
    {
        cache = new Dictionary<int, int>();
        cache[0] = 0;
        for (int i = 1; i <= amount; i++)
        {
            cache[i] = int.MaxValue;
        }

        for (int target = 1; target <= amount; target++)
        {
            for (int i = 0; i < coins.Length; i++)
            {
                if (target - coins[i] < 0)
                    continue;

                if (target - coins[i] >= 0
                    && cache[target - coins[i]] < int.MaxValue)
                {
                    cache[target] = Math.Min(cache[target], cache[target - coins[i]] + 1);
                }
            }
        }

        return cache[amount] != int.MaxValue ? cache[amount] : -1;
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
