namespace LeetCodeChallenges.Easy_Challenges
{
    // https://leetcode.com/problems/number-of-good-pairs/
    public class NumberOfGoodPairs
    {
        public int NumIdenticalPairs(int[] nums)
        {
            int Count = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = 0; j < nums.Length; j++)
                    if (nums[i].Equals(nums[j]) && i < j)
                        Count += 1;
            }
            return Count;
        }
    }
}
