using System.Collections.Generic;
using NUnit.Framework;
using Problems.Utilities;

namespace Problems.Tests.Utilities
{
    [TestFixture]
    public class PrimeFactorCalculatorTests
    {
        [Test]
        public void Verify_GetLargestFactor()
        {
            long solution = PrimeFactorCalculator.GetLargestPrimeFactor(10);
            Assert.AreEqual(5, solution);
            solution = PrimeFactorCalculator.GetLargestPrimeFactor(21);
            Assert.AreEqual(7, solution);
            solution = PrimeFactorCalculator.GetLargestPrimeFactor(81);
            Assert.AreEqual(27, solution);
            solution = PrimeFactorCalculator.GetLargestPrimeFactor(2);
            Assert.AreEqual(1, solution);
        }

        [Test]
        public void Verify_Largest_Prime_Factors_Of_TwentySeven()
        {
            long solution = PrimeFactorCalculator.GetLargestPrimeFactor(27);

            Assert.AreEqual(3, solution);
        }

        [Test]
        public void Verify_Prime_Factors_Of_A_Large_Number()
        {
            long solution = PrimeFactorCalculator.GetLargestPrimeFactor(13195);

            Assert.AreEqual(29, solution);
        }
    }
}