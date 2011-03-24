using System;
using NUnit.Framework;

namespace Problems.Tests
{
    [TestFixture]
    public class ProblemThreeTests
    {
        [Test]
        public void Verify_Solution_For_TwentyOne_Is_Seven()
        {
            var problem = new ProblemThree();

            long solution = problem.Solve(21);

            Assert.AreEqual(7, solution);
        }

        [Test]
        public void Determine_Solution()
        {
            var problem = new ProblemThree();

            long solution = problem.Solve(600851475143);

            Console.WriteLine("Solution = {0}", solution);
        }
    }
}