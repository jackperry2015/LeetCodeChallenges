using LeetCodeChallenges.Medium_Challenges;
using NUnit.Framework;

namespace LeetCodeChallenges.Tests.Medium_Challenges
{
    [TestFixture]
    public class SubrectangleQueries_Tests
    {
        SubrectangleQueries _subrectangle;

        private int[][] testArray;

        [SetUp]
        public void SetUp()
        {
            testArray = new int[][]
            {
                new int[] {1, 2, 1},
                new int[] {4, 3, 3},
                new int[] {3, 2, 1},
                new int[] {1, 1, 1}
            };
            _subrectangle = new SubrectangleQueries(testArray);
            
        }

        [Test]
        public void UpdateSubrectangle_Returns_CorrectlyUpdatedRectangle()
        {
            int[][] expectedArray = new int[][]
            {
                new int[] {5,5,5},
                new int[] {5,5,5},
                new int[] {5,5,5},
                new int[] {5,5,5},
            };
            Assert.AreEqual(expectedArray, _subrectangle.UpdateSubrectangle(0,0,3,2,5));
        }

        [TestCase(0,0,1)]
        [TestCase(1, 0, 4)]
        [TestCase(2, 2, 1)]
        public void GetValue_Returns_CorrectValueInArray(int row, int column, int expectedResult)
        {
            Assert.IsTrue(_subrectangle.GetValue(row, column) == expectedResult);
        }



    }
}
