namespace BrainTraining.Exercises
{
    public class Exercise9
    {
        // Function that returns sum of even elements of array
        public long GetSumOfEvenElements(int[] array)
        {
            return array.Where(x => x % 2 == 0).Sum(x => (long)x);
        }
    }
}
