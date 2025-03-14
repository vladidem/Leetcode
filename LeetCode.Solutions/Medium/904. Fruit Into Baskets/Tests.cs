namespace LeetCode.Solutions.Medium._904_Fruit_Into_Baskets;

public class Tests
{
    [TestCase(new[] { 1, 2, 1 }, ExpectedResult = 3)]
    [TestCase(new[] { 0, 1, 2, 2 }, ExpectedResult = 3)]
    [TestCase(new[] { 1, 2, 3, 2, 2 }, ExpectedResult = 4)]
    public int TotalFruit_NormalTrees_ReturnsMostFruitsCollectable(int[] fruits)
    {
        return new Solution().TotalFruit(fruits);
    }
}