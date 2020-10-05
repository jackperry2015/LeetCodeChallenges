using LeetCodeChallenges.Easy_Challenges;
using NUnit.Framework;

namespace LeetCodeChallenges.Tests.Easy_Challenges_Tests
{
    [TestFixture]
    public class NumberOfGoodPairs_Tests
    {
        NumberOfGoodPairs _numberOfGoodPairs;

        [SetUp]
        public void SetUp()
        {
            _numberOfGoodPairs = new NumberOfGoodPairs();
        }

        [TestCase(new int[] { 1,2,3,1,1,3 }, 4)]
        [TestCase(new int[] { 1,1,1,1 }, 6)]
        [TestCase(new int[] { 1,2,3 }, 0)]
        public void Shuffle_Returns_CorrectShuffledArray(int[] ints, int expectedResult)
        {
            Assert.IsTrue(_numberOfGoodPairs.NumIdenticalPairs(ints) == expectedResult);
        }
    }
}
