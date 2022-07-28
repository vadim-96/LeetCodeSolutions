namespace LeetCodeSolutions.Solutions.Easy;

[Url("https://leetcode.com/problems/single-number/")]
public static class SingleNumberSolution
{
    public static int FindSingleNumber(int[] nums)
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
