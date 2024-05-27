namespace HackerRank.Week1
{
    internal static class LonelyInteger
    {
        public static int lonelyinteger(List<int> a)
        {
            if (a.Count == 1)
                return a[0];

            foreach (var item in a)
            {
                if (a.Count(x => x == item) > 1)
                    continue;

                else return item;
            }

            return 0;
        }


    }
}
