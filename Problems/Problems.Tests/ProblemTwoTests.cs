using System;
using NUnit.Framework;

namespace Problems.Tests
{
    [TestFixture]
    public class ProblemTwoTests
    {
        [Test]
        public void Verify_Solution_For_OneHundred_Is_FortyFour()
        {
            var problem = new ProblemTwo();

            long solution = problem.Solve(100);

            Assert.AreEqual(44, solution);
        }

        [Test]
        public void Determine_Solution()
        {
            var problem = new ProblemTwo();

            long solution = problem.Solve(4000000);

            Console.WriteLine("Solution = {0}", solution);
        }
    }
}