namespace LeetCodeSolutions.Solutions.Medium;

using System.Text;

[Url("https://leetcode.com/problems/generate-parentheses/")]
public static class GenerateParenthesesSolution
{
    public static IList<string> GenerateParentheses(int n)
    {
        var capacityForString = n * 2;
        var openBracket = '(';
        var closedBracket = ')';
        var currentPair = new StringBuilder(capacityForString, capacityForString);
        var resultParentheses = new List<string>();

        void AddBracket(int numberOfOpeningBracket, int numberOfClosingBracket)
        {
            if (numberOfOpeningBracket == n && numberOfClosingBracket == n)
            {
                resultParentheses.Add(currentPair.ToString());
                return;
            }

            if (numberOfOpeningBracket < n)
            {
                currentPair.Append(openBracket);
                AddBracket(numberOfOpeningBracket + 1, numberOfClosingBracket);
                currentPair.Remove(currentPair.Length - 1, 1);
            }

            if (numberOfClosingBracket < numberOfOpeningBracket)
            {
                currentPair.Append(closedBracket);
                AddBracket(numberOfOpeningBracket, numberOfClosingBracket + 1);
                currentPair.Remove(currentPair.Length - 1, 1);
            }
        }

        AddBracket(0, 0);

        return resultParentheses;
    }
}
