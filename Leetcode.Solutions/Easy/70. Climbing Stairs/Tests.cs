namespace LeetCode.Solutions.Easy._70_Climbing_Stairs;

public class Tests
{
    [TestCase(2, ExpectedResult = 2)]
    [TestCase(3, ExpectedResult = 3)]
    public int ClimbStairs_PositiveN_ReturnsPossibleWays(int n)
    {
        return new Solution().ClimbStairs(n);
    }
}
