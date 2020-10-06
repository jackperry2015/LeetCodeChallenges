namespace LeetCodeChallenges.Medium_Challenges
{
    // https://leetcode.com/problems/subrectangle-queries/submissions/
    public class SubrectangleQueries
    {
        int[][] Rectangle;
        public SubrectangleQueries(int[][] rectangle)
        {
            Rectangle = rectangle;
        }

        // Replaces a rectangle of values within the given rows and columns with new value
        public int[][] UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
        {
            for (var i = row1; i <= row2; i++)
            {
                for (var y = col1; y <= col2; y++)
                {
                    Rectangle[i][y] = newValue;
                }
            }

            return Rectangle;
        }

        public int GetValue(int row, int col) 
        {
            return Rectangle[row][col];
        }
    }
}
