// https://leetcode.com/problems/contains-duplicate/

namespace LeetCodeSolutions.Solutions;

public static class ContainsDuplicateSolution
{
    public static bool DoesArrayContainDuplicate(int[] nums)
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
