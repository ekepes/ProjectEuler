using System;
using System.Collections.Generic;
using System.Linq;
using Problems.Utilities;

namespace Problems
{
    public class ProblemFive
    {
        public long GetSmallestNumberDivisibleByNumbersUpTo(long topNumber)
        {
            List<long> primeFactors = new List<long>();
            for (int i = 1; i < topNumber; i++)
            {
                primeFactors = CombineLists(primeFactors, 
                    PrimeFactorCalculator.GetPrimeFactors(i));
            }
            
            long result = 1;
            foreach (long primeFactor in primeFactors)
            {
                Console.Write("{0}, ", primeFactor);
                result *= primeFactor;
            }

            return result;
        }

        public List<long> CombineLists(List<long> firstList, List<long> secondList)
        {
            List<long> workingList = new List<long>();
            workingList.AddRange(firstList);
            workingList.AddRange(secondList);
            IEnumerable<long> uniqueFactors = workingList.Distinct();

            List<long> combinedList = new List<long>();
            foreach (long uniqueFactor in uniqueFactors)
            {
                long count = Max(firstList.FindAll(x => x == uniqueFactor).Count(),
                secondList.FindAll(x => x == uniqueFactor).Count());

                for (int i = 0; i < count; i++)
                {
                    combinedList.Add(uniqueFactor);
                }
            }

            return combinedList;
        }

        public long Max(long first, long second)
        {
            if (first > second)
            {
                return first;
            }

            return second;
        }
    }
}