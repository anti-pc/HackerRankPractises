namespace HackerRank.Week1
{
    internal static class TimeConversion
    {
        public static string timeConversion(string s)
        {
            string hours, minutes, seconds;

            if (!string.IsNullOrEmpty(s))
            {
                var isPM = s.Substring(s.Length - 2, 2) == "PM";
                var parsed = s.Substring(0, s.Length - 2).Split(':');

                var hour = int.Parse(parsed[0]);
                minutes = parsed[1];
                seconds = parsed[2];

                if (isPM)
                {
                    if (hour != 12)
                        hour += 12;
                }
                else
                {
                    if (hour == 12)
                        hour = 0;
                }

                hours = hour.ToString("D2");

                return $"{hours}:{minutes}:{seconds}";
            }

            return string.Empty;
        }
    }
}
