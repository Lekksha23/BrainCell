namespace BrainTraining.Exercises
{
    public class Exercise4
    {
        /*
         * There is a collection of input strings and a collection of query strings. For each query string, 
         * determine how many times it occurs in the list of input strings. Return an array of the results.
         */

        public static List<int> MatchStrings(List<string> strings, List<string> queries)
        {
            var outputList = new List<int>();

            for (int i = 0; i < queries.Count; i++)
            {
                var count = 0;

                for (int j = 0; j < strings.Count; j++)
                {
                    if (queries[i] == strings[j])
                    {
                        count++;
                    }
                }
                outputList.Add(count);
            }

            return outputList;
        }

    }
}
