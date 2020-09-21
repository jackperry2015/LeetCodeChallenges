using LeetCodeChallenges.Easy_Challenges;
using NUnit.Framework;

namespace LeetCodeChallenges.Tests
{
    [TestFixture]
    public class ReverseInteger_Tests
    {
        private ReverseInteger _reverseInteger;

        [SetUp]
        public void SetUp()
        {
            _reverseInteger = new ReverseInteger();
        }

        // LeetCode Test Case
        [Test]
        public void ReverseInteger_123Input_321Output()
        {
            int testCase = 123;
            var result = _reverseInteger.Reverse(testCase);

            Assert.That(result == 321);
        }
    }
}
