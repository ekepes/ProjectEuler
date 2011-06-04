using System;
using System.Collections.Generic;

namespace Problems
{
    public class ProblemEight
    {
        public IList<int> ToIntArray(string s)
        {
            IList<int> list = new List<int>();
            foreach (char c in s)
            {
                list.Add(int.Parse(c.ToString()));
            }

            return list;
        }

        public int FindProductOfDigits(string s, 
            int firstDigit, 
            int digitsToMultiply)
        {
            IList<int> digits = ToIntArray(s);

            return FindProductOfDigits(digits,
                firstDigit, 
                digitsToMultiply);
        }

        private int FindProductOfDigits(IList<int> digits, 
            int firstDigit, 
            int digitsToMultiply)
        {
            int product = 1;
            for (int i = firstDigit; i < firstDigit + digitsToMultiply; i++)
            {
                int digit = digits[i];
                product = product*digit;
            }

            return product;
        }

        public int FindLargestProductOfFiveConsecutiveDigits(string digits)
        {
            int bestSolution = 0;
            IList<int> digitArray = ToIntArray(digits);
            for (int i = 0; i < digitArray.Count-5; i++)
            {
                int candidate = FindProductOfDigits(digitArray,
                                                    i,
                                                    5);
                if (candidate > bestSolution)
                {
                    bestSolution = candidate;
                }
            }

            return bestSolution;
        }
    }
}