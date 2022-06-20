namespace BrainTraining.Exercises
{
    public class Exercise3
    {
        /*
        Given a time in 12-hour AM/PM format, convert it to military(24-hour) time.
        Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
        - 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.
         */

        public static string Print24HourFormat(String str)
        {
            var time = "";

            // Get hours
            int h1 = (int)str[1] - '0';
            int h2 = (int)str[0] - '0';
            int hh = (h2 * 10 + h1 % 10);

            // If time is in "AM"
            if (str[8] == 'A')
            {
                if (hh == 12)
                {
                    time += "00";
                    for (int i = 2; i <= 7; i++)
                        time += str[i];
                }
                else
                {
                    for (int i = 0; i <= 7; i++)
                        time += str[i];
                }
            }
            // If time is in "PM"
            else
            {
                if (hh == 12)
                {
                    time += "12";
                    for (int i = 2; i <= 7; i++)
                        time += str[i];
                }
                else
                {
                    hh = hh + 12;
                    time += hh;
                    for (int i = 2; i <= 7; i++)
                        time += str[i];
                }
            }
            return time;
        }

    }
}
