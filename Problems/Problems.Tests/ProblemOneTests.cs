using System;
using NUnit.Framework;

namespace Problems.Tests
{
    [TestFixture]
    public class ProblemOneTests
    {
        [Test]
        public void Verify_That_Upper_Bound_of_Zero_Yields_Zero()
        {
            var problem = new ProblemOne();

            int solution = problem.Solve(0);

            Assert.AreEqual(0, solution);
        }

        [Test]
        public void Verify_That_Upper_Bound_of_Four_Yields_Three()
        {
            var problem = new ProblemOne();

            int solution = problem.Solve(4);

            Assert.AreEqual(3, solution);
        }

        [Test]
        public void Verify_That_Upper_Bound_of_Six_Yields_Eight()
        {
            var problem = new ProblemOne();

            int solution = problem.Solve(6);

            Assert.AreEqual(8, solution);
        }

        [Test]
        public void Verify_That_Upper_Bound_of_Ten_Yields_TwentyThree()
        {
            var problem = new ProblemOne();

            int solution = problem.Solve(10);

            Assert.AreEqual(23, solution);
        }

        [Test]
        public void Find_Value_When_Upper_Bound_is_OneThousand()
        {
            var problem = new ProblemOne();

            int solution = problem.Solve(1000);

            Console.WriteLine("Solution is {0}", solution);
        }
    }
}