namespace BrainTraining.Exercises
{
    public class Exercise7
    {
        /*
         * The function is expected to return an INTEGER.
         * Given a square matrix, calculate the absolute difference between the sums of its diagonals.
         */

        public static int CalcDiagonalDifference(int[,] matrix, int n)
        {
            var sum1 = 0;
            var sum2 = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // finding sum of primary diagonal
                    if (i == j)
                        sum1 += matrix[i, j];
                    // finding sum of secondary diagonal
                    if (i == n - j - 1)
                        sum2 += matrix[i, j];
                }
            }
            return Math.Abs(sum1 - sum2);
        }

    }
}
