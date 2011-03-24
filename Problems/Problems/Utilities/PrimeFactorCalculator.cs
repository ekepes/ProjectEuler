using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems.Utilities
{
    public class PrimeFactorCalculator
    {
        public static List<long> GetPrimeFactors(long value)
        {
            if (value == 1)
            {
                return new List<long> {1};
            }

            long i = 2;
            long limit = value/2;
            while (i < limit)
            {
                if (value%i == 0)
                {
                    List<long> factors = GetPrimeFactors(value/i);
                    factors.Add(i);

                    return factors;
                }
                i++;
            }

            return new List<long> {value};
        }

        public static long GetLargestPrimeFactor(long value)
        {
            List<long> primeFactors = GetPrimeFactors(value);

            return primeFactors.Max();
        }
    }
}