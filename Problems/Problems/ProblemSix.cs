namespace Problems.Tests
{
    public class ProblemSix
    {
        public long GetDifferenceBetweenSumOfSquaresAndSquareOfSums(long maximum)
        {
            long sumOfSquares = 0;
            long squareOfSumsBase = 0;
            for (int i = 1; i <= maximum; i++)
            {
                sumOfSquares += i*i;
                squareOfSumsBase += i;
            }
            long squareOfSums = squareOfSumsBase*squareOfSumsBase;

            return squareOfSums - sumOfSquares;
        }
    }
}