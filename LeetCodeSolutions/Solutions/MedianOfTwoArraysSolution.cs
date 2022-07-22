// https://leetcode.com/problems/median-of-two-sorted-arrays/

namespace LeetCodeSolutions.Solutions;

public static class MedianOfTwoArraysSolution
{
    public static double FindMedianOfTwoSortedArrays(int[] nums1, int[] nums2)
    {
        _ = nums1.TryGetNonEnumeratedCount(out var nums1Count);
        _ = nums2.TryGetNonEnumeratedCount(out var nums2Count);
        var countOfNums = nums1Count + nums2Count;

        var mergedNums = new int[countOfNums];
        nums1.CopyTo(mergedNums, 0);
        nums2.CopyTo(mergedNums, nums1Count);
        Array.Sort(mergedNums);

        if (countOfNums % 2 == 0)
        {
            var firstIndex = countOfNums / 2;
            var secondIndex = firstIndex - 1;
            double firstNum = mergedNums[firstIndex];
            double secondNum = mergedNums[secondIndex];

            return (firstNum + secondNum) / 2.0;
        }

        var midIndex = countOfNums / 2;
        double median = mergedNums[midIndex];

        return median;
    }
}
