using System;
using NUnit.Framework;

namespace Problems.Tests
{
    [TestFixture]
    public class ProblemFourTests
    {
        ProblemFour _Problem = new ProblemFour();

        [Test]
        public void Verify_OneZeroOne_Reverses_Correctly()
        {
            Assert.AreEqual("101", _Problem.Reverse("101"));
        }

        [Test]
        public void Verify_OneZeroOne_Is_A_Palindrome()
        {
            bool result = _Problem.IsAPalindrome(101);

            Assert.IsTrue(result);
        }
        [Test]
        public void Verify_OneTwoThree_Reverses_Correctly()
        {
            Assert.AreEqual("321", _Problem.Reverse("123"));
        }

        [Test]
        public void Verify_OneTwoThree_Is_A_Not_Palindrome()
        {
            bool result = _Problem.IsAPalindrome(123);

            Assert.IsFalse(result);
        }

        [Test]
        public void Verify_OneDigits_Returns_Nine()
        {
            Assert.AreEqual(9, _Problem.GetLargestNumberWithDigits(1));
        }

        [Test]
        public void Verify_ThreeDigits_Returns_NineNineNine()
        {
            Assert.AreEqual(999, _Problem.GetLargestNumberWithDigits(3));
        }

        [Test]
        public void Verify_NineDigits_Returns_NineNineNineNineNineNineNineNineNine()
        {
            Assert.AreEqual(999999999, _Problem.GetLargestNumberWithDigits(9));
        }

        [Test]
        public void Verify_Largest_Two_Digit_Palidrome_Is_NineZeroZeroNine()
        {
            Assert.AreEqual(9009, _Problem.GetLargestPalindromeWithDigits(2));
        }

        [Test]
        public void Solve()
        {
            Console.WriteLine("Result = {0}", _Problem.GetLargestPalindromeWithDigits(3));
        }
    }
}