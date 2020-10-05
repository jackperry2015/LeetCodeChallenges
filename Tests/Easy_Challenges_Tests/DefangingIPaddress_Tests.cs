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
    public class DefangingIPaddress_Tests
    {
        DefangingIPaddress _defangingIPaddress;

        [SetUp]
        public void SetUp()
        {
            _defangingIPaddress = new DefangingIPaddress();
        }

        [TestCase("1.1.1.1", "1[.]1[.]1[.]1")]
        [TestCase("255.168.0.1", "255[.]168[.]0[.]1")]
        public void DefangIPaddr_Returns_DefangedIPaddress(string inputIP, string expectedDefangedIP)
        {
            Assert.IsTrue(_defangingIPaddress.DefangIPaddr(inputIP) == expectedDefangedIP);
        }

    }
}
