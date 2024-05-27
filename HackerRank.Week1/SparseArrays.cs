namespace HackerRank.Week1
{
    internal static class SparseArrays
    {
        public static List<int> matchingStrings(List<string> strings, List<string> queries)
        {
            List<int> indexList = new List<int>();
            foreach (var query in queries)
            {
                indexList.Add(strings.Count(s => s == query));
            }


            return indexList;
        }
    }
}
