using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Problems.Tests
{
    [TestFixture]
    public class ProblemSevenTests
    {
        private ProblemSeven _Problem = new ProblemSeven();

        [Test]
        public void Verify_First_Six_Primes()
        {
            List<long> expected = new List<long> {2, 3, 5, 7, 11, 13};

            List<long> solution = _Problem.GetFirstPrimes(6);

            CollectionAssert.AreEqual(expected, solution);
        }

        [Test]
        public void Verify_Sixth_Prime_Is_Thirteen()
        {
            long solution = _Problem.GetPrime(6);

            Assert.AreEqual(13, solution);
        }

        [Test]
        public void Solve()
        {
            long solution = _Problem.GetPrime(10001);

            Console.WriteLine(solution);
        }
    }
}