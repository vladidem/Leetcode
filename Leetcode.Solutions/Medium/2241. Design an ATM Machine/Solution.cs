namespace Leetcode.Solutions.Medium._2241._Design_an_ATM_Machine;

/// <summary>
///     https://leetcode.com/problems/design-an-atm-machine/
/// </summary>
public class ATM
{

    private readonly int[] _banknotesCounts =
    [
        0,
        0,
        0,
        0,
        0
    ];

    private readonly int[] _banknotesValue =
    [
        20,
        50,
        100,
        200,
        500
    ];

    public void Deposit(int[] banknotesCount)
    {
        for (int banknote = 0; banknote < banknotesCount.Length; banknote++)
        {
            _banknotesCounts[banknote] += banknotesCount[banknote];
        }
    }

    public int[] Withdraw(int amount)
    {
        int[] banknotesToDraw = Enumerable.Range(0, 5).Select(_ => 0).ToArray();
        for (int banknote = _banknotesCounts.Length - 1; banknote >= 0 && amount > 0; banknote--)
        {
            if (amount >= _banknotesValue[banknote]
                && _banknotesCounts[banknote] > banknotesToDraw[banknote]
               )
            {
                int toDraw = Math.Min(_banknotesCounts[banknote], amount / _banknotesValue[banknote]);
                amount -= _banknotesValue[banknote] * toDraw;
                banknotesToDraw[banknote] += toDraw;
            }
        }

        if (amount == 0)
        {
            for (int banknote = 0; banknote < banknotesToDraw.Length; banknote++)
            {
                _banknotesCounts[banknote] -= banknotesToDraw[banknote];
            }

            return banknotesToDraw;
        }

        return [-1];
    }
}
