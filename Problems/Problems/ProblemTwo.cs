using System.Collections.Generic;
using Problems.Utilities;

namespace Problems
{
    public class ProblemTwo
    {
        public long Solve(long solveFor)
        {
            List<long> series = FibonacciSeriesCalculator.GetFibonacciSeriesWithValuesNotExceeding(solveFor);
            long sum = 0;
            foreach (long element in series)
            {
                if (element%2 == 0)
                {
                    sum += element;
                }
            }

            return sum;
        }
    }
}