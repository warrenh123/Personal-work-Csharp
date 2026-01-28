using System;
using System.Collections.Generic;

class RaindropCounter
{
    // Memoization table: (index, prevDigit, state, isLess, isStarted)
    static Dictionary<string, long> memo = new Dictionary<string, long>();
    static string limitStr;

    static void Main()
    {
        // 2^63 is 9,223,372,036,854,775,808
        // We use ulong to compute it, then convert to string
        ulong limit = 1UL << 63; 
        limitStr = limit.ToString();

        long result = CountRaindrops(0, 0, 0, false, false);

        Console.WriteLine($"Total raindrop numbers from 0 to 2^63: {result}");
    }

    static long CountRaindrops(int index, int prevDigit, int state, bool isLess, bool isStarted)
    {
        // Base Case: Reached the end of the digits
        if (index == limitStr.Length)
        {
            // A raindrop must have exactly one drop (State 1)
            return state == 1 ? 1 : 0;
        }

        // Check Memo
        string key = $"{index}-{prevDigit}-{state}-{isLess}-{isStarted}";
        if (memo.ContainsKey(key)) return memo[key];

        long count = 0;
        int upper = isLess ? 9 : limitStr[index] - '0';

        for (int d = 0; d <= upper; d++)
        {
            bool nextIsLess = isLess || (d < upper);

            if (!isStarted)
            {
                // Handling leading zeros: If d is 0, we haven't "started" the number yet
                count += CountRaindrops(index + 1, d, 0, nextIsLess, isStarted || (d > 0));
            }
            else
            {
                if (state == 0)
                {
                    if (d >= prevDigit)
                    {
                        // Staying in the first non-decreasing sequence
                        count += CountRaindrops(index + 1, d, 0, nextIsLess, true);
                    }
                    else
                    {
                        // The "Drop" occurs: transition to State 1
                        count += CountRaindrops(index + 1, d, 1, nextIsLess, true);
                    }
                }
                else if (state == 1)
                {
                    if (d >= prevDigit)
                    {
                        // Must stay non-decreasing after the initial drop
                        count += CountRaindrops(index + 1, d, 1, nextIsLess, true);
                    }
                    // If d < prevDigit, it would be a second drop, which is invalid
                }
            }
        }

        return memo[key] = count;
    }
}