namespace Problems
{
    public class ProblemOne
    {
        public int Solve(int upperBound)
        {
            int sum = 0;
            for (int i = 1; i < upperBound; i++)
            {
                if ((i%3 == 0)
                    || (i%5 == 0))
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}