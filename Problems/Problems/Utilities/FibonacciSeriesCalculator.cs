using System;
using System.Collections.Generic;

namespace Problems.Utilities
{
    public class FibonacciSeriesCalculator
    {
        public static List<long> GetFibonacciSeries(int terms)
        {
            if (terms < 2)
            {
                throw new ArgumentException("Must be at least 1 term.");
            }

            long termOne = 1;
            long termTwo = 2;
            List<long> series = new List<long> { 1 };

            for (int i = 1; i < terms; i++)
            {
                series.Add(termTwo);
                long newTerm = termOne + termTwo;
                termOne = termTwo;
                termTwo = newTerm;
            }

            return series;
        }

        public static List<long> GetFibonacciSeriesWithValuesNotExceeding(long maxValue)
        {
            long termOne = 1;
            long termTwo = 2;
            List<long> series = new List<long> { 1 };
            
            while (termTwo < maxValue)
            {
                series.Add(termTwo);
                long newTerm = termOne + termTwo;
                termOne = termTwo;
                termTwo = newTerm;
            }

            return series;
        }
    }
}