using System.Collections.Generic;

namespace LeetCodeChallenges.Easy_Challenges
{
    public class MajorityElement
    //Given an integer array of size n, find all elements that appear more than n/3 times.
    {
        public IList<int> FindMajorityElement(int[] nums)
        {
            List<int> majorityElements = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!majorityElements.Contains(nums[i]))
                {
                    int count = 0;
                    // if majorityElements doesn't already contain the element
                    foreach (int element in nums) if (element == nums[i]) count++;

                    if (count > (nums.Length/3)) majorityElements.Add(nums[i]);

                }
            }
            return majorityElements;
        }
    }
}
