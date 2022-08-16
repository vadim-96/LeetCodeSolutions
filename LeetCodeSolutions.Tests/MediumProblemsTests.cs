namespace LeetCodeSolutions.Tests;

using LeetCodeSolutions.Solutions.Medium;

public class MediumProblemsTests
{
    [Theory]
    [InlineData(3, new[] { "((()))", "(()())", "(())()", "()(())", "()()()" })]
    [InlineData(1, new[] { "()" })]
    public void TestGeneratingParentheses(int pairsOfParentheses, IList<string> expectedParentheses)
    {
        var allCombinationsOfParentheses = GenerateParenthesesSolution.GenerateParentheses(pairsOfParentheses);

        allCombinationsOfParentheses.Should().Equal(expectedParentheses);
    }
}
