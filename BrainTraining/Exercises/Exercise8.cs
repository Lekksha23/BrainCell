namespace BrainTraining.Exercises
{
    public class Exercise8
    {
        /*
        * Given two strings consisting of digits 0 and 1 only, find the XOR of the two strings.
        */

        public string FindXOR(string s, string t)
        {
            string res = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == t[i])
                    res += '0';
                else
                    res += '1';
            }
            return res;
        }

    }
}
