using System;

namespace LeetCodeChallenges.Easy_Challenges
{
    // https://leetcode.com/problems/shuffle-the-array/
    public class ShuffleTheArray
    {
        public int[] Shuffle(int[] nums, int n)
        {
            int[] result = new int[nums.Length];

            int[] firstHalf = new int[n];
            int[] secondHalf = new int[n];

            Array.Copy(nums, 0, firstHalf, 0, n);
            Array.Copy(nums, n, secondHalf, 0, n);

            int arrayPos = 0;
            for (int i = 0; i < nums.Length; i+=2)
            {
                result[i] = firstHalf[arrayPos];
                result[i+1] = secondHalf[arrayPos];
                arrayPos++;
            }
            return result;
        }
    }
}
