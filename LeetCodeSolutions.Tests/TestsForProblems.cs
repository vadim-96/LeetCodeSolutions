namespace LeetCodeSolutions.Tests;

using FluentAssertions;
using LeetCodeSolutions.Solutions;

public class TestsForProblems
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
}
