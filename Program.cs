using LeetCodeChallenges.Easy_Challenges;
using System;

namespace LeetCodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoSum twosum = new TwoSum();
            int[] theArray = new int[] { 2,5,5,11};
            int[] result = twosum.FindTwoSum(theArray, 10);
            foreach (int num in result)
            {
                Console.WriteLine(num);
            }
        }
    }
}
