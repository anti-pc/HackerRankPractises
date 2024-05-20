namespace HackerRank.Week1
{
    public static class MiniMaxSum
    {
        public static void miniMaxSum(List<int> arr)
        {
            long total = 0;
            long minVal = long.MaxValue;
            long maxVal = long.MinValue;

            foreach (int num in arr)
            {
                total += num;
                if (num < minVal)
                {
                    minVal = num;
                }
                if (num > maxVal)
                {
                    maxVal = num;
                }
            }

            long minSum = total - maxVal;
            long maxSum = total - minVal;

            Console.WriteLine(minSum + " " + maxSum);
        }
    }
}
