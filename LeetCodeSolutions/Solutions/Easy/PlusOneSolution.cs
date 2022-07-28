namespace LeetCodeSolutions.Solutions.Easy;

[Url("https://leetcode.com/problems/plus-one/")]
public static class PlusOneSolution
{
    public static int[] AddPlusOne(int[] digits)
    {
        if (digits.Length == 1)
        {
            if (digits[0] == 9)
            {
                return new int[] { 1, 0 };
            }

            digits[0] = digits[0] + 1;
            return digits;
        }

        if (digits[^1] != 9)
        {
            digits[^1] = digits[^1] + 1;
            return digits;
        }

        var resultList = new List<int>(digits);
        resultList.Reverse();

        try
        {
            var i = 0;
            int currentNum;
            do
            {
                currentNum = resultList[i];
                if (currentNum == 9)
                {
                    resultList[i] = 0;
                }
                else
                {
                    resultList[i] += 1;
                }

                i++;
            }
            while (currentNum == 9);
        }
        catch (ArgumentOutOfRangeException)
        {
            resultList.Add(1);
        }

        resultList.Reverse();
        return resultList.ToArray();
    }

    private static int[] ConvertPlusOne_1(int[] digits)
    {
        if (!digits.TryGetNonEnumeratedCount(out var digitsLength))
        {
            digitsLength = digits.Length;
        }

        if (digitsLength == 1)
        {
            if (digits[0] == 9)
            {
                return new int[] { 1, 0 };
            }

            digits[0] = digits[0] + 1;
            return digits;
        }

        if (digits[^1] != 9)
        {
            digits[^1] = digits[^1] + 1;
            return digits;
        }

        var shouldExtendList = false;
        Span<int> resultList = stackalloc int[digitsLength];
        digits.CopyTo(resultList);
        resultList.Reverse();

        try
        {
            var i = 0;
            int currentNum;
            do
            {
                currentNum = resultList[i];
                if (currentNum == 9)
                {
                    resultList[i] = 0;
                }
                else
                {
                    resultList[i] += 1;
                }

                i++;
            }
            while (currentNum == 9);
        }
        catch (IndexOutOfRangeException)
        {
            shouldExtendList = true;
        }

        if (shouldExtendList)
        {
            Span<int> extendList = stackalloc int[digitsLength + 1];
            resultList.CopyTo(extendList);
            extendList[^1] = 1;

            extendList.Reverse();
            return extendList.ToArray();
        }

        resultList.Reverse();
        return resultList.ToArray();
    }
}
