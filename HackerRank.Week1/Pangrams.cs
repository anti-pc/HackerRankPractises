namespace HackerRank.Week1
{
    public static class Pangrams
    {

        public static string pangrams(string s)
        {
            HashSet<char> alphabetSet = new HashSet<char>();

            for (char c = 'a'; c <= 'z'; c++)
            {
                alphabetSet.Add(c);
            }

            alphabetSet.Add(' ');

            if (string.IsNullOrEmpty(s)) return "not pangram";

            HashSet<char> inputSet = new HashSet<char>(s.ToLower());

            foreach (char c in alphabetSet)
            {
                if (!inputSet.Contains(c))
                {
                    return "not pangram";
                }
            }

            return "pangram";
        }
    }
}
