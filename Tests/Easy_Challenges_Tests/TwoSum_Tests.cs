using LeetCodeChallenges.Easy_Challenges;
using NUnit.Framework;

namespace LeetCodeChallenges.Tests
{
    [TestFixture]
    public class TwoSum_Tests
    {
        private TwoSum _twoSum;

        [SetUp]
        public void SetUp()
        {
            _twoSum = new TwoSum();
        }

        // LeetCode Test Case
        [Test]
        public void FindTwoSum_ValidInput_Returns01()
        {
            int[] theArray = new int[] { 2,7,11,15 };
            var result = _twoSum.FindTwoSum(theArray, 9);

            Assert.That(result[0] == 0 && result[1] == 1);
        }
    }
}