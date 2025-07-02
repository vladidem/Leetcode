using FluentAssertions;

namespace Leetcode.Solutions.Medium._2241._Design_an_ATM_Machine;

public class Tests
{
    public static TestData[] DesigningATM_ValidOperations_ReturnsExpectedMoneyCases =
    [
        new(
            [
                new Deposit([0, 0, 1, 2, 1]),
                new Withdraw(600),
                new Deposit([0, 1, 0, 1, 1]),
                new Withdraw(600),
                new Withdraw(550)
            ],
            [null, [0, 0, 1, 0, 1], null, [-1], [0, 1, 0, 0, 1]]
        )
    ];

    [TestCaseSource(nameof(DesigningATM_ValidOperations_ReturnsExpectedMoneyCases))]
    public void DesigningATM_ValidOperations_ReturnsExpectedMoney(TestData testData)
    {
        var atm = new ATM();
        for (int i = 0; i < testData.Operations.Count; i++)
        {
            if (testData.Operations[i] is Deposit deposit)
            {
                atm.Deposit(deposit.Amounts);
            }
            else if (testData.Operations[i] is Withdraw withdraw)
            {
                int[] result = atm.Withdraw(withdraw.Amount);
                result.Should().BeEquivalentTo(testData.Expected[i]);
            }
        }
    }

    public interface IOperation
    {
    }

    public record Deposit(int[] Amounts) : IOperation;

    public record Withdraw(int Amount) : IOperation;

    public record TestData(List<IOperation> Operations, int[]?[] Expected);
}
