namespace LeetCodeSolutions.Solutions.Easy;

[Url("https://leetcode.com/problems/two-sum/")]
public static class TwoSumSolution
{
    public static int[] FindIndicesOfTwoSum(int[] nums, int target)
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
