namespace Leetcode.Solutions.Medium._322._Coin_Change;

public class Tests
{
    [TestCase(new[] { 1, 2, 5 }, 11, ExpectedResult = 3)]
    [Timeout(100)]
    public int CoinChangeBottomUp_ChangeExists_ReturnsMinimumAmountOfCoins(int[] coins, int target)
    {
        return new Solution().CoinChange(coins, target);
    }

    [TestCase(new[] { 2 }, 3, ExpectedResult = -1)]
    [Timeout(100)]
    public int CoinChangeBottomUp_ChangeDoesntExist_ReturnsMinusOne(int[] coins, int target)
    {
        return new Solution().CoinChange(coins, target);
    }

    [TestCase(new[] { 1, 2, 5 }, 11, ExpectedResult = 3)]
    [Timeout(100)]
    public int CoinChangeRecursive_ChangeExists_ReturnsMinimumAmountOfCoins(int[] coins, int target)
    {
        return new Solution().CoinChangeRecursive(coins, target);
    }

    [TestCase(new[] { 2 }, 3, ExpectedResult = -1)]
    [Timeout(100)]
    public int CoinChangeRecursive_ChangeDoesntExist_ReturnsMinusOne(int[] coins, int target)
    {
        return new Solution().CoinChangeRecursive(coins, target);
    }
}
