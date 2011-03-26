using System;

namespace Problems
{
    public class ProblemFour
    {
        public string Reverse(string forwards)
        {
            string backwards = string.Empty;
            for (int i = forwards.Length-1; i >= 0; i--)
            {
                backwards += forwards[i];
            }
            return backwards;
        }

        public bool IsAPalindrome(long value)
        {
            string forwards = value.ToString();
            var backwards = Reverse(forwards);

            return (forwards == backwards);
        }

        public long GetLargestNumberWithDigits(int digits)
        {
            string result = string.Empty;
            for (int i = 0; i < digits; i++)
            {
                result += "9";
            }

            return int.Parse(result);
        }

        public long GetLargestPalindromeWithDigits(int digits)
        {
            long startingPoint = GetLargestNumberWithDigits(digits);
            long result = 0;

            for (long firstTerm = startingPoint; firstTerm > 0; firstTerm--)
            {
                for (long secondTerm = startingPoint; secondTerm > 0 ; secondTerm--)
                {
                    long multiplicand = firstTerm*secondTerm;
                    if (IsAPalindrome(multiplicand) &&
                        multiplicand > result)
                    {
                        Console.WriteLine("{0} * {1} = {2}",
                            firstTerm,
                            secondTerm,
                            multiplicand);
                        result = multiplicand;
                    }
                }
            }

            return result;
        }
    }
}