namespace LeetCodeSolutions.Solutions.Medium;

using System.Text;

[Url("https://leetcode.com/problems/generate-parentheses/")]
public static class GenerateParenthesesSolution
{
    public static IList<string> GenerateParentheses(int n)
    {
        var capacityForString = n * 2;
        var currentPair = new StringBuilder(capacityForString, capacityForString);
        var resultParentheses = new List<string>();

        void GenerateBracket(int numberOfOpenBrackets, int numberOfClosedBrackets)
        {
            if (numberOfOpenBrackets == n && numberOfClosedBrackets == n)
            {
                resultParentheses.Add(currentPair.ToString());
                return;
            }

            if (numberOfOpenBrackets < n)
            {
                currentPair.Append('(');
                GenerateBracket(numberOfOpenBrackets + 1, numberOfClosedBrackets);
                currentPair.Remove(currentPair.Length - 1, 1);
            }

            if (numberOfClosedBrackets < numberOfOpenBrackets)
            {
                currentPair.Append(')');
                GenerateBracket(numberOfOpenBrackets, numberOfClosedBrackets + 1);
                currentPair.Remove(currentPair.Length - 1, 1);
            }
        }

        GenerateBracket(0, 0);

        return resultParentheses;
    }
}
