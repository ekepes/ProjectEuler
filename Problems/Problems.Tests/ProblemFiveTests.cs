using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Problems.Tests
{
    [TestFixture]
    public class ProblemFiveTests
    {
        private ProblemFive _Problem = new ProblemFive();

        [Test]
        public void Verify_Max_Fuction_Returns_Max_When_Same()
        {
            long max = _Problem.Max(1, 1);

            Assert.AreEqual(1, max);
        }

        [Test]
        public void Verify_Max_Fuction_Returns_Max_When_First_Larger()
        {
            long max = _Problem.Max(3, 1);

            Assert.AreEqual(3, max);
        }

        [Test]
        public void Verify_Max_Fuction_Returns_Max_When_Second_Larger()
        {
            long max = _Problem.Max(1, 3);

            Assert.AreEqual(3, max);
        }

        [Test]
        public void Verify_Combine_Lists_With_Distinct_Elements()
        {
            List<long> combineLists = _Problem.CombineLists(new List<long> {1, 2, 3}, new List<long> {4, 5, 6});

            CollectionAssert.AreEqual(new List<long> { 1, 2, 3, 4, 5, 6 }, combineLists);
        }

        [Test]
        public void Verify_Combine_Lists_With_First_Set_Empty()
        {
            List<long> combineLists = _Problem.CombineLists(new List<long>(), new List<long> { 4, 5, 6 });

            CollectionAssert.AreEqual(new List<long> { 4, 5, 6 }, combineLists);
        }

        [Test]
        public void Verify_Combine_Lists_With_Second_Set_Empty()
        {
            List<long> combineLists = _Problem.CombineLists(new List<long> { 1, 2, 3 }, new List<long>());

            CollectionAssert.AreEqual(new List<long> { 1, 2, 3 }, combineLists);
        }

        [Test]
        public void Verify_Combine_Lists_With_First_List_Has_Multiples()
        {
            List<long> combineLists = _Problem.CombineLists(new List<long> { 1, 2, 2, 3 }, new List<long> { 4, 5, 6 });

            CollectionAssert.AreEqual(new List<long> { 1, 2, 2, 3, 4, 5, 6 }, combineLists);
        }

        [Test]
        public void Verify_Combine_Lists_With_Second_List_Has_Multiples()
        {
            List<long> combineLists = _Problem.CombineLists(new List<long> { 1, 2, 3 }, new List<long> { 4, 5,5, 6 });

            CollectionAssert.AreEqual(new List<long> { 1, 2, 3, 4, 5, 5, 6 }, combineLists);
        }

        [Test]
        public void Verify_Combine_Lists_With_Both_Lists_Have_Multiples()
        {
            List<long> combineLists = _Problem.CombineLists(new List<long> { 1, 2, 2, 3 }, new List<long> { 4, 5, 5, 6 });

            CollectionAssert.AreEqual(new List<long> { 1, 2, 2, 3, 4, 5,5, 6 }, combineLists);
        }

        [Test]
        public void Verify_Combine_Lists_With_Same_Lists()
        {
            List<long> combineLists = _Problem.CombineLists(new List<long> { 1, 2, 3 }, new List<long> { 1,2,3 });

            CollectionAssert.AreEqual(new List<long> { 1, 2, 3 }, combineLists);
        }

        [Test]
        public void Verify_Combine_Lists_With_Hardcore()
        {
            List<long> combineLists = _Problem.CombineLists(new List<long> { 1, 2, 2, 2, 3 }, new List<long> { 1, 2, 2, 3, 3 });

            CollectionAssert.AreEqual(new List<long> { 1, 2, 2, 2, 3, 3 }, combineLists);
        }

        [Test]
        public void Verify_Smallest_Number_Divisible_By_All_Numbers_From_One_To_Ten_Is_TwoFiveTwoZero()
        {
            long solution = _Problem.GetSmallestNumberDivisibleByNumbersUpTo(10);

            Assert.AreEqual(2520, solution);
        }

        [Test]
        public void Solve()
        {
            long solution = _Problem.GetSmallestNumberDivisibleByNumbersUpTo(20);

            Console.WriteLine(solution);
        }
    }
}