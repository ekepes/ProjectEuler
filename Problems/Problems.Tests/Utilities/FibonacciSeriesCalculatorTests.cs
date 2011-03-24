using System.Collections.Generic;
using NUnit.Framework;
using Problems.Utilities;

namespace Problems.Tests.Utilities
{
    [TestFixture]
    public class FibonacciSeriesCalculatorTests
    {
        [Test]
        public void Verify_First_Ten_Fibonacci_Terms()
        {
            List<long> expected = new List<long> { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };

            List<long> series = FibonacciSeriesCalculator.GetFibonacciSeries(10);

            CollectionAssert.AreEquivalent(expected, series);
        }

        [Test]
        public void Verify_Fibonacci_Terms_That_Do_Not_Exceed_OneHundred()
        {
            List<long> expected = new List<long> { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };

            List<long> series = FibonacciSeriesCalculator.GetFibonacciSeriesWithValuesNotExceeding(100);

            CollectionAssert.AreEquivalent(expected, series);
        }
    }
}