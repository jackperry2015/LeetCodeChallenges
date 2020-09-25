using System.Collections.Generic;
using System.Linq;

namespace LeetCodeChallenges.Easy_Challenges
{
    // https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/
    public class GreatestNumberOfCandy
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int mostCandies = candies.Max();
            List<bool> canBeGreatest = new List<bool>();

            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] + extraCandies >= mostCandies) canBeGreatest.Add(true);
                else canBeGreatest.Add(false);
            }
            return canBeGreatest;
        }
    }
}
