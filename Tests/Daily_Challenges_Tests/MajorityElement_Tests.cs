using LeetCodeChallenges.Easy_Challenges;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCodeChallenges.Tests
{
    public class MajorityElement_Tests
    {
        private MajorityElement _majorityElement;

        [SetUp]
        public void SetUp()
        {
            _majorityElement = new MajorityElement();
        }

        // LeetCode Test Case
        [Test]
        public void MajorityElement_PassedArray_ReturnsExpected()
        {
            int[] testArray = new int[] { 3,2,3 };

            var expectedResult = new List<int>() { 3 };
            var actualResult = _majorityElement.FindMajorityElement(testArray);

            CollectionAssert.AreEqual(expectedResult, actualResult);
        }
    }
}
