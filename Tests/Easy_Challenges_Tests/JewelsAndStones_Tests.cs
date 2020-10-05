using LeetCodeChallenges.Easy_Challenges;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallenges.Tests.Easy_Challenges_Tests
{
    [TestFixture]
    public class JewelsAndStones_Tests
    {
        JewelsandStones _jewelsandStones;

        [SetUp]
        public void SetUp()
        {
            _jewelsandStones = new JewelsandStones();
        }

        [TestCase("aA", "aAAbbbb", 3)]
        [TestCase("z", "ZZ", 0)]

        public void NumJewelsInStones_Returns_NumberOfJewelsInStones(string jewels, string stones, int nOfJewels)
        {
            Assert.IsTrue(_jewelsandStones.NumJewelsInStones(jewels, stones) == nOfJewels);
        }
    }
}
