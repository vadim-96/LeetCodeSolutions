// https://leetcode.com/problems/longest-common-prefix/

namespace LeetCodeSolutions.Solutions;

using System.Text;

public static class LongestCommonPrefixSolution
{
    public static string FindLongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 1)
        {
            return strs[0];
        }

        var foundPrefix = new StringBuilder();
        var totalIterations = strs
                .OrderBy(w => w.Length)
                .First()
                .Length;
        var currentIteration = 0;
        var symbolToBeAdded = '\0';
        var shouldSymbolToBeAdded = true;

        while (totalIterations > currentIteration)
        {
            for (var i = 0; i < strs.Length; i++)
            {
                var currentWord = strs[i];
                var symbolOfCurrentWord = currentWord[currentIteration];

                if (currentWord == string.Empty)
                {
                    return string.Empty;
                }

                if (i == 0)
                {
                    symbolToBeAdded = symbolOfCurrentWord;
                }

                if (symbolOfCurrentWord != symbolToBeAdded)
                {
                    shouldSymbolToBeAdded = false;
                    break;
                }
            }

            if (shouldSymbolToBeAdded)
            {
                foundPrefix.Append(symbolToBeAdded);
            }

            currentIteration++;
        }

        return foundPrefix.ToString();
    }

    private static string FindLongestCommonPrefix_1(string[] strs)
    {
        if (strs.Length == 1)
        {
            return strs[0];
        }

        if (strs.Any(el => el == string.Empty))
        {
            return string.Empty;
        }

        var resultWords = new List<string>();
        var foundPrefix = new StringBuilder();

        Array.Sort(strs);

        for (var i = 0; i < strs.Length; i++)
        {
            if (i == 0)
            {
                continue;
            }

            var currentWord = strs[i];
            var previousWord = strs[i - 1];
            var firstSymbolOfCurrentWord = currentWord.ElementAtOrDefault(0);
            var firstSymbolOfPreviousWord = previousWord.ElementAtOrDefault(0);

            if (firstSymbolOfPreviousWord != firstSymbolOfCurrentWord || i == strs.Length - 1)
            {
                if (i == strs.Length - 1)
                {
                    i++;
                }

                var slicedArr = strs
                    .Take(i)
                    .Where(el => el is not null)
                    .ToArray();

                for (var j = 0; j < i; j++)
                {
                    var currentElement = strs[j];

                    if (currentElement is not null)
                    {
                        strs[j] = null;
                    }
                }

                if (slicedArr.Length <= 1)
                {
                    continue;
                }

                FindPrefix(ref slicedArr);

                resultWords.Add(foundPrefix.ToString());
                foundPrefix.Clear();
            }
        }

        void FindPrefix(ref string[] words)
        {
            var totalIterations = words
                .OrderBy(w => w.Length)
                .First()
                .Length;
            var currentIteration = 0;
            var symbolToBeAdded = '\0';
            var shouldSymbolToBeAdded = true;

            while (totalIterations > currentIteration)
            {
                for (var i = 0; i < words.Length; i++)
                {
                    var currentWord = words[i];
                    var symbolOfCurrentWord = currentWord[currentIteration];

                    if (i == 0)
                    {
                        symbolToBeAdded = symbolOfCurrentWord;
                    }

                    if (symbolOfCurrentWord != symbolToBeAdded)
                    {
                        shouldSymbolToBeAdded = false;
                        break;
                    }
                }

                if (shouldSymbolToBeAdded)
                {
                    foundPrefix.Append(symbolToBeAdded);
                }

                currentIteration++;
            }
        }

        if (resultWords.Count == 0)
        {
            return string.Empty;
        }

        var resultWord = resultWords.OrderBy(w => w.Length).Last();

        return resultWord;
    }
}
