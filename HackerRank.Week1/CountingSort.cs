
namespace HackerRank.Week1
{
    public static class CountingSort
    {
        public static List<int> countingSort(List<int> arr)
        {
            int[] count = new int[100];

            for (int i = 0; i < arr.Count; i++)
            {
                count[arr[i]]++;
            }

            return count.ToList();
        }
    }
}
