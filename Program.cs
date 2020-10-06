using LeetCodeChallenges.Easy_Challenges;
using System;
using LeetCodeChallenges.Medium_Challenges;

namespace LeetCodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] a =
            {
                new int[] {1,2,1},
                new int[] {4,3,3},
                new int[] {3,2,1},
                new int[] {1,1,1}
            };
   
            SubrectangleQueries subrec = new SubrectangleQueries(a);
            subrec.UpdateSubrectangle(0,0,3,2,5);
        }
    }
}
