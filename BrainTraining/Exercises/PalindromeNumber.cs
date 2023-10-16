namespace BrainTraining.Exercises
{
    public class PalindromeNumber
    {
        public static bool IsPalindrome(int x)
        {
            string num = x.ToString();
            string reverseNum = "";
            for (int i = num.Length - 1; i >= 0; i--)
                for (int j = 0; j < num.Length; j++)
                {
                    reverseNum += num[i];
                }

            if (reverseNum == num) return true;

            return false;
        }
    }
}
