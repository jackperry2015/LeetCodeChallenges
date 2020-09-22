using System.Collections.Generic;

namespace LeetCodeChallenges.Easy_Challenges
{
    public class IntegerProductAndSumDifference
    //Given an integer number n, return the difference between the product of its digits and the sum of its digits.
    {
        public int SubtractProductAndSum(int n)
        {
            List<int> allDigits = new List<int>();

            for (; n != 0; n /= 10) allDigits.Add(n % 10);

            int product = 1; int sum = 0;

            foreach(int digit in allDigits)
            {
                product = product * digit;
                sum = sum += digit;
            }

            return product - sum;
        }
    }
}
