namespace BrainTraining.Exercises
{
    public class Exercise2
    {
        /*
        Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers.
        Then print the respective minimum and maximum values as a single line of two space-separated long integers.
        */

        public void Sum(int[] arr)
        {
            var countOfAllElements = arr.Length;

            long minSum = 0;
            long maxSum = 0;

            for (int i = 0; i < countOfAllElements - 1; i++)
            {
                var indexOfMin = i;

                for (int j = i; j < countOfAllElements; j++)
                {
                    if (arr[indexOfMin] > arr[j])
                    {
                        indexOfMin = j;
                    }
                }
                Swap(ref arr[i], ref arr[indexOfMin]);
            }

            for (int i = 0; i < countOfAllElements - 1; i++)
            {
                minSum += arr[i];
            }

            for (int i = 1; i < countOfAllElements; i++)
            {
                maxSum += arr[i];
            }

            Console.Write($"{minSum} {maxSum}");
        }

        private void Swap(ref int numOne, ref int numTwo)
        {
            var temp = numOne;
            numOne = numTwo;
            numTwo = temp;
        }

    }
}
