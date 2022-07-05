// https://leetcode.com/problems/two-sum/

namespace LeetCodeSolutions.Solutions;

using System;

internal static class TwoSumSolution
{
    public static void TestTwoSum()
    {
        var nums = new[] { 124, 2, 7, 11, 15, 100, 24 };
        var nums1 = new[] { 2, 3, 4 };
        var target = 115;
        var target1 = 6;

        foreach (var index in FindIndicesOfTwoSum(nums, target))
        {
            Console.WriteLine(index);
        }
    }

    private static int[] FindIndicesOfTwoSum(int[] nums, int target)
    {
        var positionForSearch = 0;

        while (true)
        {
            var firstNum = nums[positionForSearch];

            for (var i = 0; i < nums.Length; i++)
            {
                var secondNum = nums[i];
                var sumOfTwoNum = firstNum + secondNum;

                if (sumOfTwoNum == target && positionForSearch != i)
                {
                    return new int[] { positionForSearch, i };
                }
            }

            positionForSearch++;
        }
    }
}
