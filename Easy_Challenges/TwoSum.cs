namespace LeetCodeChallenges.Easy_Challenges
{
    // Given int array, return idices of two numbers that add up to target integer
    // Assumes each input has one solution, and cannot use same array element twice
    public class TwoSum
    {
        // Nested loops to check each value against the others to find the target
        // Ensuring the same value isn't used twice
        public int[] FindTwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int x = 1; x < nums.Length; x++)
                {
                    if (nums[i] + nums[x] == target && i != x) return new int[] { i, x };
                }
            }
            return new int[] { 0, 0 };
        }
    }
}
