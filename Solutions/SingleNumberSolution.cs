// https://leetcode.com/problems/single-number/

namespace LeetCodeSolutions.Solutions;

using System;

internal static class SingleNumberSolution
{
    public static void TestSingleNumber()
    {
        var example = new[] { -336, 513, -560, -481, -174, 101, -997, 40, -527, -784, -283, -336, 513, -560, -481, -174, 101, -997, 40, -527, -784, -283, 354 };

        Console.WriteLine($"SingeNumber: {SingleNumber(example)}");
    }

    private static int SingleNumber(int[] nums)
    {
        Array.Sort(nums);

        var startPosition = 0;

        while (true)
        {
            var currentNum = nums[startPosition];

            try
            {
                var nextNum = nums[startPosition + 1];

                if (currentNum == nextNum)
                {
                    startPosition += 2;
                }
                else
                {
                    return currentNum;
                }
            }
            catch (IndexOutOfRangeException)
            {
                return currentNum;
            }
        }
    }
}
