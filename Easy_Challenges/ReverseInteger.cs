using System;
namespace LeetCodeChallenges.Easy_Challenges
{
    // Reverse whatever integer is passed i.e. 123 -> 321
    public class ReverseInteger
    {
        public int Reverse(int x)
        {
            int placeholder = x;
            int reverse = 0;

            while(Convert.ToBoolean(placeholder))
            {
                int y = placeholder % 10;
                reverse = reverse * 10 + y;
                placeholder = placeholder / 10;
            }
            return reverse;
        }
    }
}
