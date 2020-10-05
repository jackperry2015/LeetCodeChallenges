namespace LeetCodeChallenges.Easy_Challenges
{
    // https://leetcode.com/problems/jewels-and-stones/
    public class JewelsandStones
    {
        public int NumJewelsInStones(string J, string S)
        {
            char[] jewels = J.ToCharArray();
            char[] stones = S.ToCharArray();
            
            int numberOfJewelsInStones = 0;

            for (int i = 0; i < jewels.Length; i++)
            {
                for (int y = 0; y < stones.Length; y++)
                {
                    if (jewels[i] == stones[y]) numberOfJewelsInStones++;
                }
            }
            return numberOfJewelsInStones;
        }
    }
}
