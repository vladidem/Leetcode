namespace Leetcode.Solutions.Easy._844._Backspace_String_Compare;

/// <summary>
///     https://leetcode.com/problems/backspace-string-compare/
/// </summary>
public class Solution
{
    private const char DeleteSymbol = '#';

    public bool BackspaceCompare(string s, string t)
    {
        int sPointer = s.Length - 1;
        int tPointer = t.Length - 1;

        while (sPointer >= 0 && tPointer >= 0)
        {
            sPointer = NextNonDeletedCharIndex(sPointer, s);
            tPointer = NextNonDeletedCharIndex(tPointer, t);

            if (tPointer >= 0
                && sPointer >= 0
                && t[tPointer] != s[sPointer])
                return false;

            tPointer--;
            sPointer--;
        }

        sPointer = NextNonDeletedCharIndex(sPointer, s);
        tPointer = NextNonDeletedCharIndex(tPointer, t);

        return tPointer == sPointer;
    }

    private int NextNonDeletedCharIndex(int startIndex, string s)
    {
        int toDelete = 0;
        int pointer = startIndex;

        while (pointer >= 0
               && (toDelete > 0 || s[pointer] == DeleteSymbol))
        {
            if (s[pointer] == DeleteSymbol)
                toDelete++;
            else
                toDelete--;

            pointer--;
        }

        return pointer;
    }
}
