using LeetCodeChallenges.Easy_Challenges;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCodeChallenges.Tests.Easy_Challenges_Tests
{
    [TestFixture]
    public class GreatestNumberOfCandy_Tests
    {
        private GreatestNumberOfCandy _greatestNumberOfCandy;

        [SetUp]
        public void SetUp()
        {
            _greatestNumberOfCandy = new GreatestNumberOfCandy();
        }

        // LeetCode Test Case
        [Test]
        public void KidsWithCandies_ReturnsValid_Result()
        {
            int[] testArray = new int[] { 2, 3, 5, 1, 3 };
            int testExtraCandies = 3;

            var result = _greatestNumberOfCandy.KidsWithCandies(testArray, testExtraCandies);
            var expectedResult = new List<bool> { true, true, true, false, true};

            Assert.AreEqual(expectedResult, result);
        }
    }
}
