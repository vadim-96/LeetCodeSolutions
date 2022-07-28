namespace LeetCodeSolutions.Solutions.Easy;

[Url("https://leetcode.com/problems/squares-of-a-sorted-array/")]
public static class SquaresOfSortedArraySolution
{
    public static int[] FindSquaresOfEachNumber(int[] nums)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            var currentElement = nums[i];
            nums[i] = currentElement * currentElement;
        }

        Array.Sort(nums);

        return nums;
    }
}
