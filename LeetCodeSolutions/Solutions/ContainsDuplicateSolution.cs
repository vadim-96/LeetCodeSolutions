// https://leetcode.com/problems/contains-duplicate/

namespace LeetCodeSolutions.Solutions;

internal static class ContainsDuplicateSolution
{
    public static void TestContainsDuplicate()
    {
        var example = new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };

        Console.WriteLine($"ContainsDuplicate: {DoesArrayContainDuplicate(example)}");
    }

    private static bool DoesArrayContainDuplicate(int[] nums)
    {
        var uniqueNumbers = nums.Distinct();
        var countOfMergedNumbers = nums.Union(uniqueNumbers).Count();

        if (countOfMergedNumbers == nums.Length)
        {
            return false;
        }

        return true;
    }
}
