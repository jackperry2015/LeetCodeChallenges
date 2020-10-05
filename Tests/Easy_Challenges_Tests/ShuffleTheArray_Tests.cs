using LeetCodeChallenges.Easy_Challenges;
using NUnit.Framework;
namespace LeetCodeChallenges.Tests.Daily_Challenges_Tests
{
    [TestFixture]
    public class ShuffleTheArray_Tests
    {
        ShuffleTheArray _shuffleTheArray;
        [SetUp]
        public void SetUp()
        {
            _shuffleTheArray = new ShuffleTheArray();
        }

        [TestCase(new int[] { 1, 1, 2, 2 }, 2, new int[] { 1, 2, 1, 2 })]
        [TestCase(new int[] { 2, 5, 1, 3, 4, 7 }, 3, new int[] { 2, 3, 5, 4, 1, 7 })]
        [TestCase(new int[] { 1, 2, 3, 4, 4, 3, 2, 1 }, 4, new int[] { 1, 4, 2, 3, 3, 2, 4, 1 })]
        public void Shuffle_Returns_CorrectShuffledArray(int[] testArray, int n, int[] expectedResult)
        {
            Assert.AreEqual(_shuffleTheArray.Shuffle(testArray, n), expectedResult);
        }
    }
}
