using LeetCodeChallenges.Easy_Challenges;
using NUnit.Framework;

namespace LeetCodeChallenges.Tests.Easy_Challenges_Tests
{
    [TestFixture]
    public class IntegerProductAndSumDifference_Tests
    {
        private IntegerProductAndSumDifference _integerProductAndSumDifference;

        [SetUp]
        public void SetUp()
        {
            _integerProductAndSumDifference = new IntegerProductAndSumDifference();
        }

        // LeetCode Test Case
        [Test]
        public void SubtractProductAndSum_Passed234_Returns15()
        {
            int testInt = 234;

            var expectedResult = 15;
            var actualResult = _integerProductAndSumDifference.SubtractProductAndSum(testInt);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
