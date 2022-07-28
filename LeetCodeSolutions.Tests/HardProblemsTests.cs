namespace LeetCodeSolutions.Tests;

using LeetCodeSolutions.Solutions.Hard;

public class HardProblemsTests
{
    [Theory]
    [InlineData(new[] { 1, 3 }, new[] { 2 }, 2.0)]
    [InlineData(new[] { 1, 2 }, new[] { 3, 4 }, 2.5)]
    public void TestMedianOfTwoSortedArrays(int[] nums1, int[] nums2, double expectedMedian)
    {
        var resultMedian = MedianOfTwoArraysSolution.FindMedianOfTwoSortedArrays(nums1, nums2);

        resultMedian.Should().Be(expectedMedian);
    }
}
