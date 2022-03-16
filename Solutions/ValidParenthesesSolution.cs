﻿// https://leetcode.com/problems/valid-parentheses/

namespace LeetCodeSolutions.Solutions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

internal static class ValidParenthesesSolution
{
    public static void TestParentheses()
    {
        var trueExample = "(([]){})";
        var trueExample1 = "{[]}";
        var falseExample = "(){[}]";
        var falseExample1 = "]";
        var falseExample2 = "){";

        Console.WriteLine($"TRUE: {AreParenthesesValid(trueExample)}");
        Console.WriteLine($"TRUE: {AreParenthesesValid(trueExample1)}");
        Console.WriteLine($"FALSE: {AreParenthesesValid(falseExample)}");
        Console.WriteLine($"FALSE: {AreParenthesesValid(falseExample1)}");
        Console.WriteLine($"FALSE: {AreParenthesesValid(falseExample2)}");
    }

    private static bool AreParenthesesValid(string exampleString)
    {
        var exampleStr = new StringBuilder(exampleString);
        int currentLength;

        while (exampleStr.Length != 0)
        {
            currentLength = exampleStr.Length;

            exampleStr.Replace("()", string.Empty);
            exampleStr.Replace("[]", string.Empty);
            exampleStr.Replace("{}", string.Empty);

            if (currentLength == exampleStr.Length)
            {
                return false;
            }
        }

        return true;
    }

    private static bool AreParenthesesValid_1(string exampleString)
    {
        var originChars = exampleString.ToList();
        var slicedChars = new List<char>();

        while (originChars.Count != 0)
        {
            if (slicedChars.Count == 0)
            {
                slicedChars = originChars;
            }

            var currentChar = slicedChars[0];
            var nextChar = slicedChars.ElementAtOrDefault(1);
            var closedBracketIndex = 0;

            switch (currentChar)
            {
                case '(':
                    if (nextChar is not default(char) and ')')
                    {
                        closedBracketIndex = slicedChars.FindIndex(el => el == ')');
                    }
                    else
                    {
                        closedBracketIndex = slicedChars.FindLastIndex(el => el == ')');
                    }

                    break;
                case '[':
                    if (nextChar is not default(char) and ']')
                    {
                        closedBracketIndex = slicedChars.FindIndex(el => el == ']');
                    }
                    else
                    {
                        closedBracketIndex = slicedChars.FindLastIndex(el => el == ']');
                    }

                    break;
                case '{':
                    if (nextChar is not default(char) and '}')
                    {
                        closedBracketIndex = slicedChars.FindIndex(el => el == '}');
                    }
                    else
                    {
                        closedBracketIndex = slicedChars.FindLastIndex(el => el == '}');
                    }

                    break;
                default:
                    closedBracketIndex = default(char);
                    break;
            }

            if (closedBracketIndex == default(char))
            {
                return false;
            }

            slicedChars = slicedChars.GetRange(0, closedBracketIndex + 1);
            if (closedBracketIndex == -1)
            {
                return false;
            }

            slicedChars.RemoveAt(closedBracketIndex);
            slicedChars.RemoveAt(0);

            originChars.RemoveAt(closedBracketIndex);
            originChars.RemoveAt(0);
        }

        return true;
    }
}
