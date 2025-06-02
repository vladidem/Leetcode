using FluentAssertions;
using Leetсode.Solutions.DataStructures;

namespace Leetcode.Solutions.Medium._116._Populating_Next_Right_Pointers_in_Each_Node;

public class Tests
{
    public static TestData[] PopulatingNextRightPointers_NotEmpty_ConnectsLevelsCases =
    {
        new(
            [1, 2, 3, 4, 5, 6, 7],
            [[1], [2, 3], [4, 5, 6, 7]]
        )
    };

    [TestCaseSource(nameof(PopulatingNextRightPointers_NotEmpty_ConnectsLevelsCases))]
    public void PopulatingNextRightPointers_NotEmpty_ConnectsLevels(TestData testData)
    {
        var root = Node.FromArray(testData.Tree)!;
        root = new Solution().Connect(root);

        var currentNode = root;
        int depth = 0;

        while (currentNode != null)
        {
            var levelNode = currentNode;
            var level = new List<int>();
            while (levelNode != null)
            {
                level.Add(levelNode.val);
                levelNode = levelNode.next;
            }

            level.Should().BeEquivalentTo(
                testData.ExpectedLevels[depth],
                options => options.WithStrictOrdering());

            currentNode = currentNode.left;
            depth++;
        }
    }

    [TestCase]
    public void PopulatingNextRightPointers_Empty_NoException()
    {
        new Solution().Connect(null).Should().BeNull();
    }

    public record TestData(int?[] Tree, List<IList<int>> ExpectedLevels);
}
