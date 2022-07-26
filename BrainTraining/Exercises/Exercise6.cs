namespace BrainTraining.Exercises
{
    public class Exercise6
    {
        /*
         * The function is expected to return an INTEGER.
         * Given an array of integers, where all elements but one occur twice, find the unique element.
         */

        public static int FindUniqueNumber(List<int> list)
        {
            var uniqueNumber = 0;
            for (int i = 0; i < list.Count; i++)
            {
                var count = 0;
                for (int j = 0; j < list.Count; j++)
                {
                    if (j == i)
                        continue;
                    if (list[i] == list[j])
                        count++;
                }

                if (count == 0)
                    uniqueNumber = list[i];
            }
            return uniqueNumber;
        }

    }
}
