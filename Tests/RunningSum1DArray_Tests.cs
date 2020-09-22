using LeetCodeChallenges.Easy_Challenges;
using NUnit.Framework;
using System.Collections.ObjectModel;

namespace LeetCodeChallenges.Tests
{
    [TestFixture]
    public class RunningSum1DArray_Tests
    {
        private RunningSum1DArray _runningSum1DArray;

        [SetUp]
        public void SetUp()
        {
            _runningSum1DArray = new RunningSum1DArray();
        }

        // LeetCode Test Case
        [Test]
        public void RunningSum1dArray_Returns_RunningSum()
        {
            int[] expectedResult = new int[] { 1, 3, 6, 10, 15 };
            int[] testCase = new int[] { 1, 2, 3, 4, 5 };

            int[] result = _runningSum1DArray.RunningSum(testCase);

            CollectionAssert.AreEqual(result, expectedResult);
        }
    }
}
