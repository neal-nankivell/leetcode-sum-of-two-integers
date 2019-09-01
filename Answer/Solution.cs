using System;

namespace Answer
{
    /*
    Calculate the sum of two integers a and b,
    but you are not allowed to use the operator + and -.

    Example 1:

    Input: a = 1, b = 2
    Output: 3
    Example 2:

    Input: a = -2, b = 3
    Output: 1
    */
    public class Solution
    {
        public int GetSum(int a, int b)
        {
            var result = a | b;
            var remainder = a & b;

            while (remainder != 0) // some bits have been counted twice
            {
                result &= ~remainder; // Subtract the remainder

                remainder <<= 1; // bit shift up one position

                var newRemainder = result & remainder; // calculate the new overlapping bits

                result |= remainder; // add the remainder on

                remainder = newRemainder; // update the remainder used in the loop
            }

            return result;
        }
    }
}
