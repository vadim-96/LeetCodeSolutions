namespace LeetCodeSolutions.Tests;

using LeetCodeSolutions.Solutions.Easy;

public class EasyProblemsTests
{
    [Theory]
    [InlineData(new[] { 124, 2, 7, 11, 15, 100, 24 }, 115, new[] { 4, 5 })]
    [InlineData(new[] { 3, 3 }, 6, new[] { 0, 1 })]
    [InlineData(new[] { 2, 3, 4 }, 6, new[] { 0, 2 })]
    public void TestTwoSum(int[] nums, int target, int[] expectedIndices)
    {
        var foundIndices = TwoSumSolution.FindIndicesOfTwoSum(nums, target);

        foundIndices.Should().Equal(expectedIndices);
    }

    [Theory]
    [InlineData("(([]){})", true)]
    [InlineData("{[]}", true)]
    [InlineData("(){[}]", false)]
    [InlineData("]", false)]
    [InlineData("){", false)]
    public void TestValidParentheses(string exampleString, bool expectedResult)
    {
        var areParenthesesValid = ValidParenthesesSolution.AreParenthesesValid(exampleString);

        areParenthesesValid.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData(new[] { -336, 513, -560, -481, -174, 101, -997, 40, -527, -784, -283, -336, 513, -560, -481, -174, 101, -997, 40, -527, -784, -283, 354 }, 354)]
    [InlineData(new[] { 4, 1, 2, 1, 2 }, 4)]
    [InlineData(new[] { 2, 2, 1 }, 1)]
    [InlineData(new[] { 1 }, 1)]
    public void TestSingleNumber(int[] nums, int expectedSingleNumber)
    {
        var singleNumber = SingleNumberSolution.FindSingleNumber(nums);

        singleNumber.Should().Be(expectedSingleNumber);
    }

    [Theory]
    [InlineData(new[] { 9, 8, 9 }, new[] { 9, 9, 0 })]
    [InlineData(new[] { 1, 2, 3 }, new[] { 1, 2, 4 })]
    [InlineData(new[] { 4, 3, 2, 1 }, new[] { 4, 3, 2, 2 })]
    [InlineData(new[] { 9 }, new[] { 1, 0 })]
    public void TestPlusOne(int[] digits, int[] expectedDigits)
    {
        var resultDigits = PlusOneSolution.AddPlusOne(digits);

        resultDigits.Should().Equal(expectedDigits);
    }

    [Theory]
    [InlineData(new[] { "a", "aba", "acb" }, "a")]
    [InlineData(new[] { "flower", "flow", "flight" }, "fl")]
    [InlineData(new[] { "flower", "flow", "flight", "average", "car", "yak", "yak1", "llll", "lllll" }, "")]
    [InlineData(new[] { "dog", "racecar", "car" }, "")]
    public void TestLongestCommonPrefix(string[] strs, string expectedCommonPrefix)
    {
        var commonPrefix = LongestCommonPrefixSolution.FindLongestCommonPrefix(strs);

        commonPrefix.Should().Be(expectedCommonPrefix);
    }

    [Theory]
    [InlineData(new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
    [InlineData(new[] { 1, 2, 3, 1 }, true)]
    [InlineData(new[] { 1, 2, 3, 4 }, false)]
    public void TestDuplicateNumber(int[] nums, bool expectedResult)
    {
        var doesArrayContainDuplicate = ContainsDuplicateSolution.DoesArrayContainDuplicate(nums);

        doesArrayContainDuplicate.Should().Be(expectedResult);
    }
}
