using System;
using NUnit.Framework;

namespace Problems.Tests
{
    [TestFixture]
    public class ProblemSixTests
    {
        private ProblemSix _Problem = new ProblemSix();

        [Test]
        public void Verify_Difference_Between_Sum_of_Squares_and_Square_of_Sums_for_First_Ten()
        {
            long difference = _Problem.GetDifferenceBetweenSumOfSquaresAndSquareOfSums(10);

            Assert.AreEqual(2640, difference);
        }

        [Test]
        public void Solve()
        {
            long difference = _Problem.GetDifferenceBetweenSumOfSquaresAndSquareOfSums(100);

            Console.WriteLine(difference);
        }
    }
}