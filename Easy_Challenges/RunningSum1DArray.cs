namespace LeetCodeChallenges.Easy_Challenges
{
    // Given an array nums. We define a running sum of an array as 
    // runningSum[i] = sum(nums[0]…nums[i]). Return the running sum of nums.
    public class RunningSum1DArray
    {
        int[] inputArray = new int[] { 1, 2, 3, 4, 5 };

        public int[] RunningSum(int[] nums)
        {
            int[] runningSum = new int[nums.Length];
            runningSum[0] = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                runningSum[i] = runningSum[i - 1] + nums[i];
            }

            return runningSum;
        }
    }
}
