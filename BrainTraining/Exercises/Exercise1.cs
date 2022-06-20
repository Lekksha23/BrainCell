namespace BrainTraining.Exercises
{
    public class Exercise1
    {
        /*
        Given an array of integers, calculate the ratios of its elements that are positive, negative and zero.
        Print the decimal value of each fraction on a new line with places after the decimal.
        */

        public void FindRatiosOfArrayNumbers(List<int> arr)
        {
            var lengthOfArray = arr.Count;
            double posCount = 0;
            double negCount = 0;
            double zeroCount = 0;

            for (int i = 0; i < lengthOfArray; i++)
            {
                if (arr[i] > 0)
                {
                    posCount++;
                }
                else if (arr[i] < 0)
                {
                    negCount++;
                }
                else zeroCount++;
            }

            var res1 = (double)posCount / lengthOfArray;
            var res2 = (double)negCount / lengthOfArray;
            var res3 = (double)zeroCount / lengthOfArray;

            Console.WriteLine(Math.Round(res1, 6));
            Console.WriteLine(Math.Round(res2, 6));
            Console.WriteLine(Math.Round(res3, 6));
        }

    }
}
