using Problems.Utilities;

namespace Problems
{
    public class ProblemThree
    {
        public long Solve(long solveFor)
        {
            return PrimeFactorCalculator.GetLargestPrimeFactor(solveFor);
        }
    }
}